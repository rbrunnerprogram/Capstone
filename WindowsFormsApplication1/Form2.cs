using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        static string connString = "Server=mysql.aldpesiupui.dreamhosters.com;Port=3306;Database=capstone_brunner2;Uid=programaster;password=programaster123;";
        private bool editButton = false;


        public Form2()
        {
            InitializeComponent();
            createDepartmentDropdown();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void createDepartmentDropdown()
        {
            Dictionary<string, string> departmentList = new Dictionary<string, string>();
            Dictionary<string, string> jobList = new Dictionary<string, string>();
            
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT ID, dName FROM Department";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string deptID = reader["ID"].ToString();
                    string deptName = reader["dName"].ToString();
                    departmentList.Add(deptName, deptID);
                }
            }
            catch (MySqlException ex)
            {
                //Console.WriteLine(ex.Message);

                switch (ex.Number)
                {
                    case 1042:
                        MessageBox.Show("Unable to Connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 0:
                        MessageBox.Show("Access Denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    default:
                        break;
                }
            }
            finally
            {
                conn.Close();
            }

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT ID, JobTitle FROM Job";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string jobID = reader["ID"].ToString();
                    string jobTitle = reader["JobTitle"].ToString();
                    jobList.Add(jobTitle, jobID);
                }
            }
            catch (MySqlException ex)
            {
                //Console.WriteLine(ex.Message);

                switch (ex.Number)
                {
                    case 1042:
                        MessageBox.Show("Unable to Connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 0:
                        MessageBox.Show("Access Denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    default:
                        break;
                }
            }
            finally
            {
                conn.Close();
            }

            departmentBox.DataSource = new BindingSource(departmentList, null);
            departmentBox.DisplayMember = "Key";
            departmentBox.ValueMember = "Value";

            jobTitleBox.DataSource = new BindingSource(jobList, null);
            jobTitleBox.DisplayMember = "Key";
            jobTitleBox.ValueMember = "Value";
        }

        //Checks to see if the job position is critical
        private void jobTitleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = ((KeyValuePair<string, string>)jobTitleBox.SelectedItem).Value;
            MySqlConnection conn = new MySqlConnection(connString);
            bool checkCritical = true;
            

            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                
                cmd.CommandText = "SELECT isCritical FROM Job WHERE ID = @theID";
                cmd.Parameters.AddWithValue("@theID", value);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    checkCritical = (bool)reader["isCritical"];
                }
            }
            catch (MySqlException ex)
            {
                //Console.WriteLine(ex.Message);

                switch (ex.Number)
                {
                    case 1042:
                        MessageBox.Show("Unable to Connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 0:
                        MessageBox.Show("Access Denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    default:
                        break;
                }
            }
            finally
            {
                conn.Close();
            }

            //Checks the critical box if the employee is critical
            if (checkCritical)
            {
                criticalBox.Checked = true;
            }
            else
            {
                criticalBox.Checked = false;
            }
            
        }

        public void checkIfEditPressed(bool editStatus)
        {
            Dictionary<string, string> employeeList = new Dictionary<string, string>();
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT ID, fName, lName FROM Employee ORDER BY lName";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string empID = reader["ID"].ToString();
                    string empName = reader["lName"].ToString() + ", " + reader["fName"].ToString();
                    employeeList.Add(empName, empID);
                }
            }
            catch (MySqlException ex)
            {
                //Console.WriteLine(ex.Message);

                switch (ex.Number)
                {
                    case 1042:
                        MessageBox.Show("Unable to Connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    case 0:
                        MessageBox.Show("Access Denied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    default:
                        break;
                }
            }
            finally
            {
                conn.Close();
            }

            empChoiceBox.DataSource = new BindingSource(employeeList, null);
            empChoiceBox.DisplayMember = "Key";
            empChoiceBox.ValueMember = "Value";

            editButton = editStatus;
            EmployeefName.Location = new System.Drawing.Point(25, 83);
            EmployeelName.Location = new System.Drawing.Point(25, 106);
            firstName.Location = new System.Drawing.Point(93, 80);
            lastName.Location = new System.Drawing.Point(93, 106);
            UserNameLabel.Location = new System.Drawing.Point(25, 135);
            usernameBox.Location = new System.Drawing.Point(93, 132);
            EmployeePasswordLabel.Location = new System.Drawing.Point(25, 162);
            textBox1.Location = new System.Drawing.Point(93, 159);
            criticalBox.Location = new System.Drawing.Point(93, 240);
            departmentBox.Location = new System.Drawing.Point(93, 185);
            deparmentLabel.Location = new System.Drawing.Point(25, 188);
            jobTitleBox.Location = new System.Drawing.Point(93, 213);
            jobLabel.Location = new System.Drawing.Point(25, 216);
            addEmployLabel.Text = "Edit an Employee";
            chooseEmpLabel.Visible = true;
            empChoiceBox.Visible = true;
        }

        public void checkIfAddPressed(bool editStatus)
        {
            editButton = editStatus;
            EmployeefName.Location = new System.Drawing.Point(25, 53);
            EmployeelName.Location = new System.Drawing.Point(25, 76);
            firstName.Location = new System.Drawing.Point(93, 50);
            lastName.Location = new System.Drawing.Point(93, 76);
            UserNameLabel.Location = new System.Drawing.Point(25, 105);
            usernameBox.Location = new System.Drawing.Point(93, 102);
            EmployeePasswordLabel.Location = new System.Drawing.Point(25, 132);
            textBox1.Location = new System.Drawing.Point(93, 129);
            criticalBox.Location = new System.Drawing.Point(93, 210);
            departmentBox.Location = new System.Drawing.Point(93, 155);
            deparmentLabel.Location = new System.Drawing.Point(25, 158);
            jobTitleBox.Location = new System.Drawing.Point(93, 183);
            jobLabel.Location = new System.Drawing.Point(25, 186);
            addEmployLabel.Text = "Add an Employee";
            chooseEmpLabel.Visible = false;
            empChoiceBox.Visible = false;
        }

        private void empChoiceBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
