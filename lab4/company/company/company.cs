using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace company
{
    public partial class company : Form
    {
        Controller controllerObj;
        public company()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller(); 
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
       
       

           int result = controllerObj.InsertDepartment(Departmentname.Text, Int32.Parse(Departmentnumber.Text), Int32.Parse(manegerssn.Text), dateTimePicker1.Text);
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new department failed");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully!");
            }




        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            int result = controllerObj.UpdateEmployee(Int32.Parse(ssn.Text), Int32.Parse(salary.Text));
            if (result == 0)
            {
                MessageBox.Show("No rows are updated");
            }
            else
            {
                MessageBox.Show("The row is updated successfully");
            }




        }

        private void getnameBTN_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectManegername(Int32.Parse(Dnum.Text));
            companyDataGrid.DataSource = dt;
            companyDataGrid.Refresh();
           
       

        }

        private void deleteprojectBTN_Click(object sender, EventArgs e)
        {
            int result = controllerObj.DeleteProject(projectname.Text);
            if (result == 0)
            {
                MessageBox.Show("No rows are deleted");
            }
            else
            {
                MessageBox.Show("The row is deleted successfully!");
            }





        }

        private void projectname_TextChanged(object sender, EventArgs e)
        {

        }





    }
}
