using HRD.Classes.Model;
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
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using HRDContext db = new();
            var e1 = db.Employees.Where(emp => emp.DismissalDate == null).FirstOrDefault();

            Button qwe = sender as Button;
            qwe.Text = e1?.FIO ?? "Таблица пуста";
        }
    }
}
