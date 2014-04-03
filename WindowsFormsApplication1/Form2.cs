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

        
    }
}
