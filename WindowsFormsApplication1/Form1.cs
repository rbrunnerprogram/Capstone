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
using System.Security.Cryptography;
using System.IO;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {

        static string connString = "Server=mysql.aldpesiupui.dreamhosters.com;Port=3306;Database=capstone_brunner2;Uid=programaster;password=programaster123;";
        private Color labelColor;
        private Label[] labelList= new Label[336];
        private bool loginBool = false;
        private const string ENCRYPTION_KEY = "ENmtH6kEeV1.I";
        //Hello World is encryption key string

        private readonly static byte[] SALT = Encoding.ASCII.GetBytes(ENCRYPTION_KEY);
        private readonly byte[] key;
        private readonly byte[] iv;
        private readonly Rfc2898DeriveBytes keyGenerator;
        
        public Form1()
        {
            keyGenerator = new Rfc2898DeriveBytes(ENCRYPTION_KEY, SALT);
            key = keyGenerator.GetBytes(32);
            iv = keyGenerator.GetBytes(16);

            InitializeComponent(loginBool);
            //if (loginBool)
            //{
                createEmployeeList();
                createScheduleGrid();
            //}
            labelColor = Color.White;
        }

        private void setLoginBool(bool loginStatus)
        {
            loginBool = loginStatus;
        }

        private bool getLoginBool()
        {
            return loginBool;
        }

        private void setLabels(Label currLabel, int labelNum)
        {
            labelList[labelNum] = currLabel;
        }

        private Label getLabels(int labelNum)
        {
            return labelList[labelNum];
        }

        private void setColor(Color currColor)
        {
            labelColor = currColor;
        }

        private Color getColor()
        {
            return labelColor;
        }

        private void createEmployeeList()
        {
            int labelXLocation = 0;
            int labelYLocation = 0;
            int labelHeight = 50;
            int labelWidth = 200;

            int[] redcolorList = new int[10];
            int[] bluecolorList = new int[10];
            int[] greencolorList = new int[10];

            //Critical Employee Color
            redcolorList[0] = 255;
            bluecolorList[0] = 128;
            greencolorList[0] = 128;

            //Standard Employee Color
            redcolorList[1] = 128;
            bluecolorList[1] = 128;
            greencolorList[1] = 255;

            for (int counter = 1; counter < 10; counter++)
            {
                
            }

            bool isConn = false;        
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
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
                //conn.Close();
            }

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT fName, lName, jobStatus FROM Employee";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string labelFirstName = reader["fName"].ToString();
                string labelLastName = reader["lName"].ToString();
                string isCritical = reader["jobStatus"].ToString();
                Label testLabel = new Label();
                testLabel.Name = labelFirstName+labelLastName;
                testLabel.Text = labelFirstName + " " + labelLastName;
                if (reader["jobStatus"].ToString() == "True")
                {
                    testLabel.BackColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    testLabel.BackColor = Color.FromArgb(128, 255, 128);
                }
                testLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                testLabel.Cursor = System.Windows.Forms.Cursors.Hand;
                testLabel.Location = new Point(labelXLocation, labelYLocation);
                labelYLocation += labelHeight;
                testLabel.Size = new Size(labelWidth, labelHeight);
                employeeList.Controls.Add(testLabel);
                testLabel.MouseDown += new MouseEventHandler(labelClick);
            }

            conn.Close();
            

        }

        private void createScheduleGrid()
        {
            bool thirty = false;
            bool morning = true;
            bool DoThis = false;
            string timeStamp = "";
            int SpaceCounter = 1;
            int listCounter = 0;

            for (int counter = 0; counter < 24; counter++)
            {
                
                Label timeLabel = new Label();
                timeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
                timeLabel.AutoSize = true;
                timeLabel.TabIndex = 0;
                if (counter == 0 && !DoThis)
                {
                    timeStamp = "12:00 AM";
                    DoThis = true;
                    counter--;
                }
                else if(counter == 0 && DoThis){
                    timeStamp = "12:30 AM";
                    DoThis = false;
                }
                else
                {
                    if (counter % 12 == 0)
                    {
                        morning = false;
                    }

                    if (thirty)
                    {
                        if (counter % 12 == 0)
                        {
                            timeStamp = "12:30";
                        }
                        else
                        {
                            timeStamp = counter % 12 + ":30";
                        }
                        thirty = false;
                    }
                    else
                    {
                        if (counter % 12 == 0)
                        {
                            timeStamp = "12:00";
                        }
                        else
                        {
                            timeStamp = counter % 12 + ":00";
                        }
                        counter--;
                        thirty = true;
                    }

                    if (morning)
                    {
                        timeStamp = timeStamp + " AM";
                    }
                    else
                    {
                        timeStamp = timeStamp + " PM";
                    }

                }

                timeLabel.Text = timeStamp;
                scheduleGrid.Controls.Add(timeLabel, 0, SpaceCounter);
                SpaceCounter++;
                timeStamp = "";
            }

            for (int rowCount = 1; rowCount <= scheduleGrid.RowCount; rowCount++)
            {
                for (int colCount = 1; colCount < scheduleGrid.ColumnCount; colCount++)
                {
                    Label cellLabel = new Label();
                    cellLabel.AutoSize = false;
                    cellLabel.BackColor = Color.White;
                    cellLabel.AllowDrop = true;
                    cellLabel.Name = "cellLabel" + listCounter;
                    cellLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
                    cellLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    scheduleGrid.Controls.Add(cellLabel, colCount, rowCount);
                    cellLabel.DragEnter += new DragEventHandler(scheduleGrid_DragEnter);
                    cellLabel.DragDrop += new DragEventHandler(scheduleGrid_DragDrop);
                    cellLabel.DragLeave += new EventHandler(scheduleGrid_DragLeave);
                    listCounter++;
                }
            }
            overallPanel.Visible = false;
            scheduleGrid.Visible = false;
            employeeList.Visible = false;
        }

        private void Form1_SizeChanged(object sender, System.EventArgs e)
        {
            Control control = (Control)sender;
            
            employeeList.Location = new Point(control.Width - 250, 50);
            employeeList.Height = control.Height - 100;
            if (control.Height - 100 < 960)
            {
                scheduleGrid.Height = control.Height - 100;
            }
            else
            {
                scheduleGrid.Height = 960;
            }
            scheduleGrid.Width = control.Width - 270;
            if (control.Width < 925)
            {
                Monday.Text = "Mon.";
                Tuesday.Text = "Tues.";
                Wednesday.Text = "Wed.";
                Thursday.Text = "Thu.";
                Friday.Text = "Fri.";
                Saturday.Text = "Sat.";
                Sunday.Text = "Sun.";
            }
            else
            {
                Monday.Text = "Monday";
                Tuesday.Text = "Tuesday";
                Wednesday.Text = "Wednesday";
                Thursday.Text = "Thursday";
                Friday.Text = "Friday";
                Saturday.Text = "Saturday";
                Sunday.Text = "Sunday";
            }

        }


        //OnMouseDown event handler for employee list labels
        private void labelClick(object sender, MouseEventArgs e)
        {
            Label dragLabel = (Label)sender;
            dragLabel.DoDragDrop(dragLabel, DragDropEffects.Move);
        }

        private void scheduleGrid_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
            Label currentLabel = (Label)sender;
            setColor(currentLabel.BackColor);
            currentLabel.BackColor = Color.Cyan;
        }

        private void scheduleGrid_DragDrop(object sender, DragEventArgs e)
        {
            Label currentLabel = (Label)sender;
            Label myLabel = (Label)e.Data.GetData(typeof(Label));
            currentLabel.BackColor = myLabel.BackColor;
            currentLabel.Text = myLabel.Text;
            Point position = new Point(scheduleGrid.GetCellPosition(currentLabel).Column, scheduleGrid.GetCellPosition(currentLabel).Row);
        }

        private void scheduleGrid_DragLeave(object sender, EventArgs e)
        {
            Label currentLabel = (Label)sender;
            currentLabel.BackColor = getColor();
            
        }

        private string EncryptPassword(string textBoxPassword)
        {
            RijndaelManaged rijndaelCipher = new RijndaelManaged { Key = key, IV = iv };
            byte[] plainText = Encoding.Unicode.GetBytes(textBoxPassword);

            using (ICryptoTransform encryptor = rijndaelCipher.CreateEncryptor())
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plainText, 0, plainText.Length);
                        cryptoStream.FlushFinalBlock();
                        return Convert.ToBase64String(memoryStream.ToArray());
                    }
                }
            }
        }

        void loginButton_Click(object sender, System.EventArgs e)
        {
            setLoginBool(true);

            loginButton.Visible = false;
            loginLabel.Visible = false;
            loginPassword.Visible = false;
            loginUserName.Visible = false;

            employeeList.Visible = true;
            scheduleGrid.Visible = true;

            //testString = String.Join("", testString.Split(';'));

            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
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
                //conn.Close();
            }

            //MySqlCommand cmd = conn.CreateCommand();
            //cmd.CommandText = "Update Employee SET username = '" + loginUserName.Text + "', password = '" + EncryptPassword(loginPassword.Text) + "' WHERE lName = 'Ragsdell'";
            //cmd.ExecuteNonQuery();

            conn.Close();

            //throw new System.NotImplementedException();
        }

        
    }
}
