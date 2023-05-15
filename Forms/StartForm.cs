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
                        CreateStructure();
                        Invoke(new Action(() => B_ConnectDB.Visible = false));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message} \nStackTrace: {ex.StackTrace}", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
            };
            B_AddEmployee.Click += (s, e) =>
            {
                var employee = new Employee { LastName = TB_LastName.Text, FirstName = TB_FirstName.Text,
                    SecondName = TB_SecondName.Text, SubdivisionId = (int)CB_Subdivisions.SelectedValue };
                hrd.Employees.Add(employee);
                hrd.SaveChanges();
                CreateStructure();
            };
        }

        private async void CreateStructure()
        {
            var subdivisions = await hrd.Subdivisions.Include(s => s.Employees).ToListAsync();
            Invoke(new Action(() =>
            {
                TV_Structure.Nodes.Clear();
                TV_Structure.Nodes.AddRange(TreeStructure.CreateTreeStructure(subdivisions));
                TV_Structure.ExpandAll();
                //CB_Subdivisions1.Items.AddRange(subdivisions.Select(s => new { Text = s.Name, Value = s }).ToArray());
                CB_Subdivisions.DataSource = subdivisions.Select(s => new { Text = s.Name, Value = s.Id }).ToArray();
            }));
        }
    }
}
