using HRD.Controllers;

namespace HRD.Forms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            this.Load += (s, e) =>
            {
                Task.Run(() =>
                {
                    var subdivisions = Subdivisions.GetSubdivisionsAsDymanic();
                    Invoke(() => { CB_Subdivisions1.DataSource = subdivisions; CB_Subdivisions2.DataSource = subdivisions.Clone(); });
                });
            };

            B_AddEmployee.Click += (s, e) =>
            {
                var id = Employees.CreateEmployee(TB_LastName.Text, TB_FirstName.Text,
                    TB_SecondName.Text, (int)CB_Subdivisions1.SelectedValue);
            };

            B_CreateStructure.Click += (s, e) =>
            {
                var dt = DTP_Structure.Value;
                var tree = Subdivisions.GetTreeStructureByDateTime(dt);
                TV_Structure.Nodes.Clear();
                TV_Structure.Nodes.AddRange(tree);
                TV_Structure.ExpandAll();
            };

            B_EmployeesOnSubdivision.Click += (s, e) =>
            {
                var subdivisionId = (int)CB_Subdivisions2.SelectedValue;
                var dtStart = DTP_StartPeriod.Value;
                var dtEnd = DTP_EndPeriod.Value;
                var empBySub = Employees.GetEmployeesBySubdivisionOnPeriod(subdivisionId, dtStart, dtEnd);
                TV_EmployeesOnSubdivision.Nodes.Clear();
                TV_EmployeesOnSubdivision.Nodes.AddRange(empBySub);
            };
        }
    }
}
