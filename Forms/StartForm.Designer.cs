namespace HRD.Forms
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TV_Structure = new TreeView();
            GB_AddEmployee = new GroupBox();
            B_AddEmployee = new Button();
            TB_SecondName = new TextBox();
            TB_FirstName = new TextBox();
            TB_LastName = new TextBox();
            CB_Subdivisions1 = new ComboBox();
            GB_EmployeesOnSubdivision = new GroupBox();
            TV_EmployeesOnSubdivision = new TreeView();
            CB_Subdivisions2 = new ComboBox();
            B_CreateStructure = new Button();
            DTP_Structure = new DateTimePicker();
            GB_Structure = new GroupBox();
            B_EmployeesOnSubdivision = new Button();
            DTP_StartPeriod = new DateTimePicker();
            DTP_EndPeriod = new DateTimePicker();
            L_StartPeriod = new Label();
            L_EndPeriod = new Label();
            L_Structure = new Label();
            L_EmployeesOnSubdivision = new Label();
            GB_AddEmployee.SuspendLayout();
            GB_EmployeesOnSubdivision.SuspendLayout();
            GB_Structure.SuspendLayout();
            SuspendLayout();
            // 
            // TV_Structure
            // 
            TV_Structure.Location = new Point(6, 22);
            TV_Structure.Name = "TV_Structure";
            TV_Structure.Size = new Size(306, 516);
            TV_Structure.TabIndex = 1;
            // 
            // GB_AddEmployee
            // 
            GB_AddEmployee.Controls.Add(B_AddEmployee);
            GB_AddEmployee.Controls.Add(TB_SecondName);
            GB_AddEmployee.Controls.Add(TB_FirstName);
            GB_AddEmployee.Controls.Add(TB_LastName);
            GB_AddEmployee.Controls.Add(CB_Subdivisions1);
            GB_AddEmployee.Location = new Point(336, 12);
            GB_AddEmployee.Name = "GB_AddEmployee";
            GB_AddEmployee.Size = new Size(180, 174);
            GB_AddEmployee.TabIndex = 2;
            GB_AddEmployee.TabStop = false;
            GB_AddEmployee.Text = "Добавление сотрудника";
            // 
            // B_AddEmployee
            // 
            B_AddEmployee.Location = new Point(31, 138);
            B_AddEmployee.Name = "B_AddEmployee";
            B_AddEmployee.Size = new Size(123, 30);
            B_AddEmployee.TabIndex = 4;
            B_AddEmployee.Text = "Принять";
            B_AddEmployee.UseVisualStyleBackColor = true;
            // 
            // TB_SecondName
            // 
            TB_SecondName.Location = new Point(6, 109);
            TB_SecondName.Name = "TB_SecondName";
            TB_SecondName.PlaceholderText = "Отчество";
            TB_SecondName.Size = new Size(168, 23);
            TB_SecondName.TabIndex = 3;
            // 
            // TB_FirstName
            // 
            TB_FirstName.Location = new Point(6, 80);
            TB_FirstName.Name = "TB_FirstName";
            TB_FirstName.PlaceholderText = "Имя";
            TB_FirstName.Size = new Size(168, 23);
            TB_FirstName.TabIndex = 2;
            // 
            // TB_LastName
            // 
            TB_LastName.Location = new Point(6, 51);
            TB_LastName.Name = "TB_LastName";
            TB_LastName.PlaceholderText = "Фамилия";
            TB_LastName.Size = new Size(168, 23);
            TB_LastName.TabIndex = 1;
            // 
            // CB_Subdivisions1
            // 
            CB_Subdivisions1.DisplayMember = "Text";
            CB_Subdivisions1.FormattingEnabled = true;
            CB_Subdivisions1.Location = new Point(6, 22);
            CB_Subdivisions1.Name = "CB_Subdivisions1";
            CB_Subdivisions1.Size = new Size(168, 23);
            CB_Subdivisions1.TabIndex = 0;
            CB_Subdivisions1.ValueMember = "Value";
            // 
            // GB_EmployeesOnSubdivision
            // 
            GB_EmployeesOnSubdivision.Controls.Add(TV_EmployeesOnSubdivision);
            GB_EmployeesOnSubdivision.Controls.Add(CB_Subdivisions2);
            GB_EmployeesOnSubdivision.Location = new Point(522, 12);
            GB_EmployeesOnSubdivision.Name = "GB_EmployeesOnSubdivision";
            GB_EmployeesOnSubdivision.Size = new Size(282, 544);
            GB_EmployeesOnSubdivision.TabIndex = 3;
            GB_EmployeesOnSubdivision.TabStop = false;
            GB_EmployeesOnSubdivision.Text = "Сотрудники подразеления";
            // 
            // TV_EmployeesOnSubdivision
            // 
            TV_EmployeesOnSubdivision.Location = new Point(6, 51);
            TV_EmployeesOnSubdivision.Name = "TV_EmployeesOnSubdivision";
            TV_EmployeesOnSubdivision.Size = new Size(270, 487);
            TV_EmployeesOnSubdivision.TabIndex = 2;
            // 
            // CB_Subdivisions2
            // 
            CB_Subdivisions2.DisplayMember = "Text";
            CB_Subdivisions2.FormattingEnabled = true;
            CB_Subdivisions2.Location = new Point(6, 22);
            CB_Subdivisions2.Name = "CB_Subdivisions2";
            CB_Subdivisions2.Size = new Size(270, 23);
            CB_Subdivisions2.TabIndex = 1;
            CB_Subdivisions2.ValueMember = "Value";
            // 
            // B_CreateStructure
            // 
            B_CreateStructure.Location = new Point(336, 254);
            B_CreateStructure.Name = "B_CreateStructure";
            B_CreateStructure.Size = new Size(180, 23);
            B_CreateStructure.TabIndex = 5;
            B_CreateStructure.Text = "Отобразить структуру";
            B_CreateStructure.UseVisualStyleBackColor = true;
            // 
            // DTP_Structure
            // 
            DTP_Structure.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            DTP_Structure.Format = DateTimePickerFormat.Custom;
            DTP_Structure.Location = new Point(336, 225);
            DTP_Structure.Name = "DTP_Structure";
            DTP_Structure.Size = new Size(180, 23);
            DTP_Structure.TabIndex = 6;
            // 
            // GB_Structure
            // 
            GB_Structure.Controls.Add(TV_Structure);
            GB_Structure.Location = new Point(12, 12);
            GB_Structure.Name = "GB_Structure";
            GB_Structure.Size = new Size(318, 544);
            GB_Structure.TabIndex = 7;
            GB_Structure.TabStop = false;
            GB_Structure.Text = "Структура организации";
            // 
            // B_EmployeesOnSubdivision
            // 
            B_EmployeesOnSubdivision.Location = new Point(336, 432);
            B_EmployeesOnSubdivision.Name = "B_EmployeesOnSubdivision";
            B_EmployeesOnSubdivision.Size = new Size(180, 38);
            B_EmployeesOnSubdivision.TabIndex = 8;
            B_EmployeesOnSubdivision.Text = "Отобразить сотрудников подразделения";
            B_EmployeesOnSubdivision.UseVisualStyleBackColor = true;
            // 
            // DTP_StartPeriod
            // 
            DTP_StartPeriod.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            DTP_StartPeriod.Format = DateTimePickerFormat.Custom;
            DTP_StartPeriod.Location = new Point(336, 359);
            DTP_StartPeriod.Name = "DTP_StartPeriod";
            DTP_StartPeriod.Size = new Size(180, 23);
            DTP_StartPeriod.TabIndex = 9;
            // 
            // DTP_EndPeriod
            // 
            DTP_EndPeriod.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            DTP_EndPeriod.Format = DateTimePickerFormat.Custom;
            DTP_EndPeriod.Location = new Point(336, 403);
            DTP_EndPeriod.Name = "DTP_EndPeriod";
            DTP_EndPeriod.Size = new Size(180, 23);
            DTP_EndPeriod.TabIndex = 10;
            // 
            // L_StartPeriod
            // 
            L_StartPeriod.AutoSize = true;
            L_StartPeriod.Location = new Point(376, 341);
            L_StartPeriod.Name = "L_StartPeriod";
            L_StartPeriod.Size = new Size(98, 15);
            L_StartPeriod.TabIndex = 11;
            L_StartPeriod.Text = "Начало периода";
            // 
            // L_EndPeriod
            // 
            L_EndPeriod.AutoSize = true;
            L_EndPeriod.Location = new Point(380, 385);
            L_EndPeriod.Name = "L_EndPeriod";
            L_EndPeriod.Size = new Size(90, 15);
            L_EndPeriod.TabIndex = 12;
            L_EndPeriod.Text = "Конец периода";
            // 
            // L_Structure
            // 
            L_Structure.AutoSize = true;
            L_Structure.Location = new Point(342, 207);
            L_Structure.Name = "L_Structure";
            L_Structure.Size = new Size(166, 15);
            L_Structure.TabIndex = 13;
            L_Structure.Text = "Структура на выбраную дату";
            // 
            // L_EmployeesOnSubdivision
            // 
            L_EmployeesOnSubdivision.AutoSize = true;
            L_EmployeesOnSubdivision.Location = new Point(342, 326);
            L_EmployeesOnSubdivision.Name = "L_EmployeesOnSubdivision";
            L_EmployeesOnSubdivision.Size = new Size(166, 15);
            L_EmployeesOnSubdivision.TabIndex = 14;
            L_EmployeesOnSubdivision.Text = "Структура на выбраную дату";
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 568);
            Controls.Add(L_EmployeesOnSubdivision);
            Controls.Add(L_Structure);
            Controls.Add(L_EndPeriod);
            Controls.Add(L_StartPeriod);
            Controls.Add(DTP_EndPeriod);
            Controls.Add(DTP_StartPeriod);
            Controls.Add(B_EmployeesOnSubdivision);
            Controls.Add(GB_Structure);
            Controls.Add(DTP_Structure);
            Controls.Add(B_CreateStructure);
            Controls.Add(GB_EmployeesOnSubdivision);
            Controls.Add(GB_AddEmployee);
            Name = "StartForm";
            Text = "StartForm";
            GB_AddEmployee.ResumeLayout(false);
            GB_AddEmployee.PerformLayout();
            GB_EmployeesOnSubdivision.ResumeLayout(false);
            GB_Structure.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TreeView TV_Structure;
        private GroupBox GB_AddEmployee;
        private TextBox TB_LastName;
        private ComboBox CB_Subdivisions1;
        private TextBox TB_SecondName;
        private TextBox TB_FirstName;
        private Button B_AddEmployee;
        private GroupBox GB_EmployeesOnSubdivision;
        private ComboBox CB_Subdivisions2;
        private Button B_CreateStructure;
        private DateTimePicker DTP_Structure;
        private TreeView TV_EmployeesOnSubdivision;
        private GroupBox GB_Structure;
        private Button B_EmployeesOnSubdivision;
        private DateTimePicker DTP_StartPeriod;
        private DateTimePicker DTP_EndPeriod;
        private Label L_StartPeriod;
        private Label L_EndPeriod;
        private Label L_Structure;
        private Label L_EmployeesOnSubdivision;
    }
}