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
    public partial class Form1 : Form
    {

        static string connString = "Server=mysql.aldpesiupui.dreamhosters.com;Port=3306;Database=capstone_brunner2;Uid=programaster;password=programaster123;";

        public Form1()
        {
            InitializeComponent();
            createEmployeeList();
            createScheduleGrid();
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
            dragLabel.DoDragDrop(dragLabel.BackColor, DragDropEffects.Move);
        }

        private void scheduleGrid_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void scheduleGrid_DragDrop(object sender, DragEventArgs e)
        {
            int columnPlaced = 1;
            int rowPlaced = 1;
            Label cellLabel = new Label();
            cellLabel.AutoSize = true;
            Color myColor = (Color)e.Data.GetData(typeof(Color));
            cellLabel.BackColor = myColor;
            cellLabel.Text = "Hello World";
            //Console.WriteLine();
            Point screenTestPoint = new Point(e.X, e.Y);
            Point testPoint = scheduleGrid.PointToClient(new Point(e.X, e.Y));

            TableLayoutPanel tempPanel = (TableLayoutPanel)sender;
            int scrollAmount = (tempPanel.VerticalScroll.Value / tempPanel.VerticalScroll.Maximum)*100;

            rowPlaced = (int)testPoint.Y / 20;
            Console.WriteLine(tempPanel.VerticalScroll.Maximum);
            
            //scheduleGrid.Controls.Add(cellLabel, 2, 2);
        }

        
    }
}
