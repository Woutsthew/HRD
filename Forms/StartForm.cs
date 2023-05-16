using HRD.Classes.Controllers;
using HRD.Classes.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace HRD.Forms
{
    public partial class StartForm : Form
    {
        private HRDContext? hrd;
        public StartForm()
        {
            InitializeComponent();

            B_ConnectDB.Click += async (s, e) =>
            {
                await Task.Run(() =>
                {
                    try
                    {
                        hrd = new HRDContext();
                        Invoke(new Action(() =>
                        {
                            B_ConnectDB.Visible = false;
                            B_CreateStructure.PerformClick();
                        }));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message} \nStackTrace: {ex.StackTrace}", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            };
            B_AddEmployee.Click += (s, e) =>
            {
                var employee = new Employee
                {
                    LastName = TB_LastName.Text,
                    FirstName = TB_FirstName.Text,
                    SecondName = TB_SecondName.Text,
                    SubdivisionId = (int)CB_Subdivisions.SelectedValue
                };
                hrd.Employees.Add(employee);
                hrd.SaveChanges();
                hrd.ChangeTracker.Clear();
            };
            B_CreateStructure.Click += (s, e) =>
            {
                var dt = DTP_Structure.Value;

                hrd.ChangeTracker.Clear();
                var subdivisions = hrd.Subdivisions.ToList();
                hrd.ChangeTracker.Clear();

                var employees = hrd.Employees.Where(e => (dt >= e.HireDate && e.DismissalDate == null) || (e.DismissalDate > dt && dt >= e.HireDate))
                    .Include(emp => emp.Transfers.OrderBy(t => t.atDateTime).Where(t => t.atDateTime > dt).Take(1))
                    .ToList();

                foreach (var employee in employees)
                {
                    var subdivisionId = employee.Transfers.Count != 0 ? employee.Transfers.First().FromSubdivisionId : employee.SubdivisionId;
                    subdivisions.Find(s => s.Id == subdivisionId)!.Employees.Add(employee);
                }

                CreateStructure(subdivisions);
                hrd.ChangeTracker.Clear();
            };
        }

        private void CreateStructure(List<Subdivision> subdivisions)
        {
            TV_Structure.Nodes.Clear();
            TV_Structure.Nodes.AddRange(TreeStructure.CreateTreeStructure(subdivisions));
            TV_Structure.ExpandAll();
            CB_Subdivisions.DataSource = subdivisions.Select(s => new { Text = s.Name, Value = s.Id }).ToArray();
        }
    }
}
