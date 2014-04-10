using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class labelWithValue : System.Windows.Forms.Label
    {
        private int empID;
        private List<string> empList = new List<string>();
        private List<Color> colorList = new List<Color>();
        public labelWithValue()
        {
            InitializeComponent();
        }

        public int lastIndexOfEmployeeList()
        {
            return empList.Count - 1;
        }

        public int lastIndexOfColorList()
        {
            return colorList.Count - 1;
        }

        public void setEmpID(int ID)
        {
            empID = ID;
        }

        public int getEmpID()
        {
            return empID;
        }

        public void addEmployeeToList(string empName, Color labelColor)
        {
            empList.Add(empName);
            colorList.Add(labelColor);
        }

        public string getEmployeeList(int index)
        {
            return empList[index];
        }

        public Color getEmployeeColor(int index)
        {
            return colorList[index];
        }

        public string getEmployeeFullList()
        {
            string fullList = "";
            foreach (string item in empList)
            {
                fullList += item + System.Environment.NewLine;
            }

            return fullList;
        }

        public bool searchList(string empName)
        {
            string result = empList.Find(item => item == empName);
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getNumElementsInList()
        {
            return empList.Count;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
