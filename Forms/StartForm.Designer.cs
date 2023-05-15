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
            B_ConnectDB = new Button();
            TV_Structure = new TreeView();
            GB_AddEmployee = new GroupBox();
            B_AddEmployee = new Button();
            TB_SecondName = new TextBox();
            TB_FirstName = new TextBox();
            TB_LastName = new TextBox();
            CB_Subdivisions = new ComboBox();
            GB_TransferAndDelete = new GroupBox();
            B_DeleteEmployee = new Button();
            B_TransferEmployee = new Button();
            L_ToSubdivision = new Label();
            CB_ToSubdivisions = new ComboBox();
            L_FromSubdivison = new Label();
            CB_FIO = new ComboBox();
            CB_FromSubdivisions = new ComboBox();
            GB_AddEmployee.SuspendLayout();
            GB_TransferAndDelete.SuspendLayout();
            SuspendLayout();
            // 
            // B_ConnectDB
            // 
            B_ConnectDB.Location = new Point(651, 495);
            B_ConnectDB.Name = "B_ConnectDB";
            B_ConnectDB.Size = new Size(153, 61);
            B_ConnectDB.TabIndex = 0;
            B_ConnectDB.Text = "Подключиться к бд";
            B_ConnectDB.UseVisualStyleBackColor = true;
            // 
            // TV_Structure
            // 
            TV_Structure.Location = new Point(12, 12);
            TV_Structure.Name = "TV_Structure";
            TV_Structure.Size = new Size(318, 544);
            TV_Structure.TabIndex = 1;
            // 
            // GB_AddEmployee
            // 
            GB_AddEmployee.Controls.Add(B_AddEmployee);
            GB_AddEmployee.Controls.Add(TB_SecondName);
            GB_AddEmployee.Controls.Add(TB_FirstName);
            GB_AddEmployee.Controls.Add(TB_LastName);
            GB_AddEmployee.Controls.Add(CB_Subdivisions);
            GB_AddEmployee.Location = new Point(336, 12);
            GB_AddEmployee.Name = "GB_AddEmployee";
            GB_AddEmployee.Size = new Size(154, 174);
            GB_AddEmployee.TabIndex = 2;
            GB_AddEmployee.TabStop = false;
            GB_AddEmployee.Text = "Добавление сотрудника";
            // 
            // B_AddEmployee
            // 
            B_AddEmployee.Location = new Point(31, 138);
            B_AddEmployee.Name = "B_AddEmployee";
            B_AddEmployee.Size = new Size(95, 30);
            B_AddEmployee.TabIndex = 4;
            B_AddEmployee.Text = "Принять";
            B_AddEmployee.UseVisualStyleBackColor = true;
            // 
            // TB_SecondName
            // 
            TB_SecondName.Location = new Point(6, 109);
            TB_SecondName.Name = "TB_SecondName";
            TB_SecondName.PlaceholderText = "Отчество";
            TB_SecondName.Size = new Size(142, 23);
            TB_SecondName.TabIndex = 3;
            // 
            // TB_FirstName
            // 
            TB_FirstName.Location = new Point(6, 80);
            TB_FirstName.Name = "TB_FirstName";
            TB_FirstName.PlaceholderText = "Имя";
            TB_FirstName.Size = new Size(142, 23);
            TB_FirstName.TabIndex = 2;
            // 
            // TB_LastName
            // 
            TB_LastName.Location = new Point(6, 51);
            TB_LastName.Name = "TB_LastName";
            TB_LastName.PlaceholderText = "Фамилия";
            TB_LastName.Size = new Size(142, 23);
            TB_LastName.TabIndex = 1;
            // 
            // CB_Subdivisions
            // 
            CB_Subdivisions.DisplayMember = "Text";
            CB_Subdivisions.FormattingEnabled = true;
            CB_Subdivisions.Location = new Point(6, 22);
            CB_Subdivisions.Name = "CB_Subdivisions";
            CB_Subdivisions.Size = new Size(142, 23);
            CB_Subdivisions.TabIndex = 0;
            CB_Subdivisions.ValueMember = "Value";
            // 
            // GB_TransferAndDelete
            // 
            GB_TransferAndDelete.Controls.Add(B_DeleteEmployee);
            GB_TransferAndDelete.Controls.Add(B_TransferEmployee);
            GB_TransferAndDelete.Controls.Add(L_ToSubdivision);
            GB_TransferAndDelete.Controls.Add(CB_ToSubdivisions);
            GB_TransferAndDelete.Controls.Add(L_FromSubdivison);
            GB_TransferAndDelete.Controls.Add(CB_FIO);
            GB_TransferAndDelete.Controls.Add(CB_FromSubdivisions);
            GB_TransferAndDelete.Location = new Point(496, 12);
            GB_TransferAndDelete.Name = "GB_TransferAndDelete";
            GB_TransferAndDelete.Size = new Size(308, 174);
            GB_TransferAndDelete.TabIndex = 3;
            GB_TransferAndDelete.TabStop = false;
            GB_TransferAndDelete.Text = "Перевод и увольнение сотрудника";
            GB_TransferAndDelete.Visible = false;
            // 
            // B_DeleteEmployee
            // 
            B_DeleteEmployee.Location = new Point(207, 44);
            B_DeleteEmployee.Name = "B_DeleteEmployee";
            B_DeleteEmployee.Size = new Size(95, 30);
            B_DeleteEmployee.TabIndex = 6;
            B_DeleteEmployee.Text = "Уволить";
            B_DeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // B_TransferEmployee
            // 
            B_TransferEmployee.Location = new Point(63, 109);
            B_TransferEmployee.Name = "B_TransferEmployee";
            B_TransferEmployee.Size = new Size(95, 30);
            B_TransferEmployee.TabIndex = 5;
            B_TransferEmployee.Text = "Перевести";
            B_TransferEmployee.UseVisualStyleBackColor = true;
            // 
            // L_ToSubdivision
            // 
            L_ToSubdivision.AutoSize = true;
            L_ToSubdivision.Location = new Point(6, 83);
            L_ToSubdivision.Name = "L_ToSubdivision";
            L_ToSubdivision.Size = new Size(14, 15);
            L_ToSubdivision.TabIndex = 5;
            L_ToSubdivision.Text = "В";
            // 
            // CB_ToSubdivisions
            // 
            CB_ToSubdivisions.FormattingEnabled = true;
            CB_ToSubdivisions.Location = new Point(33, 80);
            CB_ToSubdivisions.Name = "CB_ToSubdivisions";
            CB_ToSubdivisions.Size = new Size(168, 23);
            CB_ToSubdivisions.TabIndex = 4;
            // 
            // L_FromSubdivison
            // 
            L_FromSubdivison.AutoSize = true;
            L_FromSubdivison.Location = new Point(6, 25);
            L_FromSubdivison.Name = "L_FromSubdivison";
            L_FromSubdivison.Size = new Size(21, 15);
            L_FromSubdivison.TabIndex = 4;
            L_FromSubdivison.Text = "Из";
            // 
            // CB_FIO
            // 
            CB_FIO.FormattingEnabled = true;
            CB_FIO.Location = new Point(6, 51);
            CB_FIO.Name = "CB_FIO";
            CB_FIO.Size = new Size(195, 23);
            CB_FIO.TabIndex = 2;
            // 
            // CB_FromSubdivisions
            // 
            CB_FromSubdivisions.FormattingEnabled = true;
            CB_FromSubdivisions.Location = new Point(33, 22);
            CB_FromSubdivisions.Name = "CB_FromSubdivisions";
            CB_FromSubdivisions.Size = new Size(168, 23);
            CB_FromSubdivisions.TabIndex = 1;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 568);
            Controls.Add(GB_TransferAndDelete);
            Controls.Add(GB_AddEmployee);
            Controls.Add(TV_Structure);
            Controls.Add(B_ConnectDB);
            Name = "StartForm";
            Text = "StartForm";
            GB_AddEmployee.ResumeLayout(false);
            GB_AddEmployee.PerformLayout();
            GB_TransferAndDelete.ResumeLayout(false);
            GB_TransferAndDelete.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button B_ConnectDB;
        private TreeView TV_Structure;
        private GroupBox GB_AddEmployee;
        private TextBox TB_LastName;
        private ComboBox CB_Subdivisions;
        private TextBox TB_SecondName;
        private TextBox TB_FirstName;
        private Button B_AddEmployee;
        private GroupBox GB_TransferAndDelete;
        private ComboBox CB_FromSubdivisions;
        private Label L_ToSubdivision;
        private ComboBox CB_ToSubdivisions;
        private Label L_FromSubdivison;
        private ComboBox CB_FIO;
        private Button B_DeleteEmployee;
        private Button B_TransferEmployee;
    }
}