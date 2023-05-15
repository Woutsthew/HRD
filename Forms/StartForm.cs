using HRD.Classes.Controllers;
using HRD.Classes.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                        Invoke(new Action(() => { B_ConnectDB.Visible = false;
                            B_CreateStructure.PerformClick(); }));
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
                Invoke(new Action(() => B_CreateStructure.PerformClick()));
            };
            B_CreateStructure.Click += (s, e) =>
            {
                var dt = DTP_Structure.Value;

                hrd.ChangeTracker.Clear();
                var tranfers = hrd.SubdivisionTransfers.Where(t => t.atDateTime > dt).OrderByDescending(t => t.atDateTime).ToList();

                var employees = hrd.Employees.IgnoreQueryFilters().Where(e => (e.DismissalDate > dt && e.HireDate == null)
                    || (dt >= e.HireDate && e.DismissalDate == null) || (e.DismissalDate > dt && dt >= e.HireDate)).ToList();

                var subdivisions = hrd.Subdivisions.ToList();
                subdivisions.ForEach(s => s.Employees.Clear());

                foreach (var employee in employees)
                {
                    employee.SubdivisionId = employee.Transfers.FirstOrDefault(
                         new SubdivisionTransfers { FromSubdivisionId = employee.SubdivisionId }).FromSubdivisionId
                         ?? throw new Exception("CS0162");
                    subdivisions.Find(s => s.Id == employee.SubdivisionId)!.Employees.Add(employee);
                }

                CreateStructure(subdivisions);
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
