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



            int result = controllerObj.InsertEmployee(textBox1.Text,textBox2.Text,textBox3.Text,Int32.Parse(textBox4.Text),Int32.Parse(textBox5.Text));
            if (result == 0)
            {
                MessageBox.Show("The insertion of a new Employee failed");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully!");
            }




        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            int result = controllerObj.InsertProject(textBox6.Text,Int32.Parse(textBox7.Text),textBox8.Text,Int32.Parse(textBox9.Text));
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
            int result = controllerObj.Insertwork(Int32.Parse(textBox10.Text), Int32.Parse(textBox11.Text),float.Parse(textBox12.Text));
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

        private void Departmentname_TextChanged(object sender, EventArgs e)
        {

        }

        private void manegerssn_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Essn_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }





    }
}
