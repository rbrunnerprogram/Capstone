namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.EmployeefName = new System.Windows.Forms.Label();
            this.EmployeelName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.EmployeePasswordLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addEmployLabel = new System.Windows.Forms.Label();
            this.criticalBox = new System.Windows.Forms.CheckBox();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.deparmentLabel = new System.Windows.Forms.Label();
            this.jobTitleBox = new System.Windows.Forms.ComboBox();
            this.jobLabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.permLabel = new System.Windows.Forms.Label();
            this.addEmployeeBox = new System.Windows.Forms.CheckBox();
            this.empChoiceBox = new System.Windows.Forms.ComboBox();
            this.chooseEmpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmployeefName
            // 
            this.EmployeefName.AutoSize = true;
            this.EmployeefName.Location = new System.Drawing.Point(25, 53);
            this.EmployeefName.Name = "EmployeefName";
            this.EmployeefName.Size = new System.Drawing.Size(60, 13);
            this.EmployeefName.TabIndex = 0;
            this.EmployeefName.Text = "First Name:";
            // 
            // EmployeelName
            // 
            this.EmployeelName.AutoSize = true;
            this.EmployeelName.Location = new System.Drawing.Point(25, 76);
            this.EmployeelName.Name = "EmployeelName";
            this.EmployeelName.Size = new System.Drawing.Size(61, 13);
            this.EmployeelName.TabIndex = 1;
            this.EmployeelName.Text = "Last Name:";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(93, 50);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(163, 20);
            this.firstName.TabIndex = 2;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(93, 76);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(163, 20);
            this.lastName.TabIndex = 3;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(25, 105);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(58, 13);
            this.UserNameLabel.TabIndex = 4;
            this.UserNameLabel.Text = "Username:";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(93, 102);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(163, 20);
            this.usernameBox.TabIndex = 5;
            // 
            // EmployeePasswordLabel
            // 
            this.EmployeePasswordLabel.AutoSize = true;
            this.EmployeePasswordLabel.Location = new System.Drawing.Point(25, 132);
            this.EmployeePasswordLabel.Name = "EmployeePasswordLabel";
            this.EmployeePasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.EmployeePasswordLabel.TabIndex = 6;
            this.EmployeePasswordLabel.Text = "Password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 7;
            // 
            // addEmployLabel
            // 
            this.addEmployLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.addEmployLabel.AutoSize = true;
            this.addEmployLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addEmployLabel.Location = new System.Drawing.Point(62, 9);
            this.addEmployLabel.Name = "addEmployLabel";
            this.addEmployLabel.Size = new System.Drawing.Size(170, 25);
            this.addEmployLabel.TabIndex = 8;
            this.addEmployLabel.Text = "Add An Employee";
            // 
            // criticalBox
            // 
            this.criticalBox.AutoSize = true;
            this.criticalBox.Enabled = false;
            this.criticalBox.Location = new System.Drawing.Point(93, 210);
            this.criticalBox.Name = "criticalBox";
            this.criticalBox.Size = new System.Drawing.Size(116, 17);
            this.criticalBox.TabIndex = 9;
            this.criticalBox.Text = "Employee is Critical";
            this.criticalBox.UseVisualStyleBackColor = true;
            // 
            // departmentBox
            // 
            this.departmentBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.Location = new System.Drawing.Point(93, 155);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(121, 21);
            this.departmentBox.TabIndex = 10;
            // 
            // deparmentLabel
            // 
            this.deparmentLabel.AutoSize = true;
            this.deparmentLabel.Location = new System.Drawing.Point(25, 158);
            this.deparmentLabel.Name = "deparmentLabel";
            this.deparmentLabel.Size = new System.Drawing.Size(65, 13);
            this.deparmentLabel.TabIndex = 11;
            this.deparmentLabel.Text = "Department:";
            // 
            // jobTitleBox
            // 
            this.jobTitleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jobTitleBox.FormattingEnabled = true;
            this.jobTitleBox.Location = new System.Drawing.Point(93, 183);
            this.jobTitleBox.Name = "jobTitleBox";
            this.jobTitleBox.Size = new System.Drawing.Size(121, 21);
            this.jobTitleBox.TabIndex = 12;
            this.jobTitleBox.SelectedIndexChanged += new System.EventHandler(this.jobTitleBox_SelectedIndexChanged);
            // 
            // jobLabel
            // 
            this.jobLabel.AutoSize = true;
            this.jobLabel.Location = new System.Drawing.Point(25, 186);
            this.jobLabel.Name = "jobLabel";
            this.jobLabel.Size = new System.Drawing.Size(50, 13);
            this.jobLabel.TabIndex = 13;
            this.jobLabel.Text = "Job Title:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(459, 261);
            this.shapeContainer1.TabIndex = 14;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 280;
            this.lineShape1.X2 = 280;
            this.lineShape1.Y1 = 11;
            this.lineShape1.Y2 = 246;
            // 
            // permLabel
            // 
            this.permLabel.AutoSize = true;
            this.permLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.permLabel.Location = new System.Drawing.Point(303, 36);
            this.permLabel.Name = "permLabel";
            this.permLabel.Size = new System.Drawing.Size(88, 17);
            this.permLabel.TabIndex = 15;
            this.permLabel.Text = "Permissions:";
            // 
            // addEmployeeBox
            // 
            this.addEmployeeBox.AutoSize = true;
            this.addEmployeeBox.Location = new System.Drawing.Point(306, 56);
            this.addEmployeeBox.Name = "addEmployeeBox";
            this.addEmployeeBox.Size = new System.Drawing.Size(121, 17);
            this.addEmployeeBox.TabIndex = 16;
            this.addEmployeeBox.Text = "Can Add Employees";
            this.addEmployeeBox.UseVisualStyleBackColor = true;
            // 
            // empChoiceBox
            // 
            this.empChoiceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.empChoiceBox.FormattingEnabled = true;
            this.empChoiceBox.Location = new System.Drawing.Point(120, 49);
            this.empChoiceBox.Name = "empChoiceBox";
            this.empChoiceBox.Size = new System.Drawing.Size(121, 21);
            this.empChoiceBox.TabIndex = 10;
            this.empChoiceBox.Visible = false;
            this.empChoiceBox.SelectedIndexChanged += new System.EventHandler(this.empChoiceBox_SelectedIndexChanged);
            // 
            // chooseEmpLabel
            // 
            this.chooseEmpLabel.AutoSize = true;
            this.chooseEmpLabel.Location = new System.Drawing.Point(12, 52);
            this.chooseEmpLabel.Name = "chooseEmpLabel";
            this.chooseEmpLabel.Size = new System.Drawing.Size(95, 13);
            this.chooseEmpLabel.TabIndex = 17;
            this.chooseEmpLabel.Text = "Choose Employee:";
            this.chooseEmpLabel.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 261);
            this.Controls.Add(this.chooseEmpLabel);
            this.Controls.Add(this.addEmployeeBox);
            this.Controls.Add(this.permLabel);
            this.Controls.Add(this.jobLabel);
            this.Controls.Add(this.jobTitleBox);
            this.Controls.Add(this.deparmentLabel);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.criticalBox);
            this.Controls.Add(this.addEmployLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.EmployeePasswordLabel);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.EmployeelName);
            this.Controls.Add(this.EmployeefName);
            this.Controls.Add(this.empChoiceBox);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeefName;
        private System.Windows.Forms.Label EmployeelName;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label EmployeePasswordLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label addEmployLabel;
        private System.Windows.Forms.CheckBox criticalBox;
        private System.Windows.Forms.ComboBox departmentBox;
        private System.Windows.Forms.Label deparmentLabel;
        private System.Windows.Forms.ComboBox jobTitleBox;
        private System.Windows.Forms.ComboBox empChoiceBox;
        private System.Windows.Forms.Label jobLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label permLabel;
        private System.Windows.Forms.CheckBox addEmployeeBox;
        private System.Windows.Forms.Label chooseEmpLabel;
    }
}