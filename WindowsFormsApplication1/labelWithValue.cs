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
        public labelWithValue()
        {
            InitializeComponent();
        }

        public void setEmpID(int ID)
        {
            empID = ID;
        }

        public int getEmpID()
        {
            return empID;
        }

        public void addEmployeeToList(string empName)
        {
            empList.Add(empName);
        }

        public string getEmployeeList()
        {
            string fullList = "";
            foreach (string item in empList)
            {
                fullList += item + System.Environment.NewLine;
            }

            return fullList;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
