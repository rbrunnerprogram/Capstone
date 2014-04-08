namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginUserName = new System.Windows.Forms.TextBox();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.employeeList = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleGrid = new System.Windows.Forms.TableLayoutPanel();
            this.Monday = new System.Windows.Forms.Label();
            this.Tuesday = new System.Windows.Forms.Label();
            this.Wednesday = new System.Windows.Forms.Label();
            this.Thursday = new System.Windows.Forms.Label();
            this.Friday = new System.Windows.Forms.Label();
            this.Saturday = new System.Windows.Forms.Label();
            this.Sunday = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.overallPanel = new System.Windows.Forms.Panel();
            this.dayLabels = new System.Windows.Forms.TableLayoutPanel();
            this.popUpInfo = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.dayLabels.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(138, 3);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(29, 13);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Hello World";
            // 
            // loginUserName
            // 
            this.loginUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginUserName.Location = new System.Drawing.Point(0, 0);
            this.loginUserName.Name = "loginUserName";
            this.loginUserName.Size = new System.Drawing.Size(100, 20);
            this.loginUserName.TabIndex = 1;
            // 
            // loginPassword
            // 
            this.loginPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPassword.Location = new System.Drawing.Point(0, 0);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.PasswordChar = '*';
            this.loginPassword.Size = new System.Drawing.Size(100, 20);
            this.loginPassword.TabIndex = 1;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.Location = new System.Drawing.Point(300, 100);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 30);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Login Button";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // employeeList
            // 
            this.employeeList.AutoScroll = true;
            this.employeeList.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.employeeList.Location = new System.Drawing.Point(465, 50);
            this.employeeList.Name = "employeeList";
            this.employeeList.Size = new System.Drawing.Size(220, 339);
            this.employeeList.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.editEmployeeToolStripMenuItem});
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.managerToolStripMenuItem.Text = "Manager";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // editEmployeeToolStripMenuItem
            // 
            this.editEmployeeToolStripMenuItem.Name = "editEmployeeToolStripMenuItem";
            this.editEmployeeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.editEmployeeToolStripMenuItem.Text = "Edit Employee";
            this.editEmployeeToolStripMenuItem.Click += new System.EventHandler(this.editEmployeeToolStripMenuItem_Click);
            // 
            // scheduleGrid
            // 
            this.scheduleGrid.AutoScroll = true;
            this.scheduleGrid.ColumnCount = 8;
            this.scheduleGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.scheduleGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.scheduleGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.scheduleGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.scheduleGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.scheduleGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.scheduleGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.scheduleGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.scheduleGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.scheduleGrid.Location = new System.Drawing.Point(14, 50);
            this.scheduleGrid.Name = "scheduleGrid";
            this.scheduleGrid.RowCount = 48;
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.scheduleGrid.Size = new System.Drawing.Size(445, 339);
            this.scheduleGrid.TabIndex = 0;
            // 
            // Monday
            // 
            this.Monday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Monday.AutoSize = true;
            this.Monday.Location = new System.Drawing.Point(9, 5);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(31, 13);
            this.Monday.TabIndex = 0;
            this.Monday.Text = "Mon.";
            // 
            // Tuesday
            // 
            this.Tuesday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tuesday.AutoSize = true;
            this.Tuesday.Location = new System.Drawing.Point(60, 5);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(29, 13);
            this.Tuesday.TabIndex = 1;
            this.Tuesday.Text = "Tue.";
            // 
            // Wednesday
            // 
            this.Wednesday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Wednesday.AutoSize = true;
            this.Wednesday.Location = new System.Drawing.Point(108, 5);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(33, 13);
            this.Wednesday.TabIndex = 2;
            this.Wednesday.Text = "Wed.";
            // 
            // Thursday
            // 
            this.Thursday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Thursday.AutoSize = true;
            this.Thursday.Location = new System.Drawing.Point(160, 5);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(29, 13);
            this.Thursday.TabIndex = 3;
            this.Thursday.Text = "Thu.";
            // 
            // Friday
            // 
            this.Friday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Friday.AutoSize = true;
            this.Friday.Cursor = System.Windows.Forms.Cursors.Default;
            this.Friday.Location = new System.Drawing.Point(214, 5);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(21, 13);
            this.Friday.TabIndex = 4;
            this.Friday.Text = "Fri.";
            // 
            // Saturday
            // 
            this.Saturday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Saturday.AutoSize = true;
            this.Saturday.Location = new System.Drawing.Point(262, 5);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(26, 13);
            this.Saturday.TabIndex = 5;
            this.Saturday.Text = "Sat.";
            // 
            // Sunday
            // 
            this.Sunday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sunday.AutoSize = true;
            this.Sunday.Location = new System.Drawing.Point(312, 5);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(29, 13);
            this.Sunday.TabIndex = 6;
            this.Sunday.Text = "Sun.";
            // 
            // userLabel
            // 
            this.userLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userLabel.Location = new System.Drawing.Point(0, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(100, 20);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "Username:";
            // 
            // passLabel
            // 
            this.passLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passLabel.Location = new System.Drawing.Point(0, 0);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(100, 20);
            this.passLabel.TabIndex = 1;
            this.passLabel.Text = "Password:";
            // 
            // overallPanel
            // 
            this.overallPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overallPanel.Location = new System.Drawing.Point(0, 24);
            this.overallPanel.Name = "overallPanel";
            this.overallPanel.Size = new System.Drawing.Size(704, 376);
            this.overallPanel.TabIndex = 2;
            // 
            // dayLabels
            // 
            this.dayLabels.BackColor = System.Drawing.SystemColors.Control;
            this.dayLabels.ColumnCount = 7;
            this.dayLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dayLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dayLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dayLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dayLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dayLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dayLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.dayLabels.Controls.Add(this.Monday, 0, 0);
            this.dayLabels.Controls.Add(this.Tuesday, 1, 0);
            this.dayLabels.Controls.Add(this.Wednesday, 2, 0);
            this.dayLabels.Controls.Add(this.Thursday, 3, 0);
            this.dayLabels.Controls.Add(this.Friday, 4, 0);
            this.dayLabels.Controls.Add(this.Saturday, 5, 0);
            this.dayLabels.Controls.Add(this.Sunday, 6, 0);
            this.dayLabels.Location = new System.Drawing.Point(90, 4);
            this.dayLabels.Name = "dayLabels";
            this.dayLabels.RowCount = 1;
            this.dayLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.dayLabels.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.dayLabels.Size = new System.Drawing.Size(354, 22);
            this.dayLabels.TabIndex = 0;
            // 
            // popUpInfo
            // 
            this.popUpInfo.AutomaticDelay = 10;
            this.popUpInfo.AutoPopDelay = 100000;
            this.popUpInfo.InitialDelay = 10;
            this.popUpInfo.ReshowDelay = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 400);
            this.Controls.Add(this.scheduleGrid);
            this.Controls.Add(this.dayLabels);
            this.Controls.Add(this.employeeList);
            this.Controls.Add(this.overallPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.loginUserName);
            this.Controls.Add(this.loginPassword);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.passLabel);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(720, 430);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.dayLabels.ResumeLayout(false);
            this.dayLabels.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Panel employeeList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel scheduleGrid;
        private System.Windows.Forms.Label Monday;
        private System.Windows.Forms.Label Tuesday;
        private System.Windows.Forms.Label Wednesday;
        private System.Windows.Forms.Label Thursday;
        private System.Windows.Forms.Label Friday;
        private System.Windows.Forms.Label Saturday;
        private System.Windows.Forms.Label Sunday;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.Panel overallPanel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.TextBox loginUserName;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TableLayoutPanel dayLabels;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolTip popUpInfo; 


    }
}

