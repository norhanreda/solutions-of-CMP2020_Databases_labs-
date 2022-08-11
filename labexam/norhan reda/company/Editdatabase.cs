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
    public partial class Editdatabase : Form
    {
        Controller controllerObj;
        public Editdatabase()
        {
            InitializeComponent();
        }

        private void Editdatabase_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();

          /*  DataTable dt1 = controllerObj.SelectAllStudentsid();
            comboBox2.DataSource = dt1;
            comboBox2.DisplayMember = "ID";

            DataTable dt2 = controllerObj.SelectAllCoursescode();
            comboBox3.DataSource = dt2;
            comboBox3.DisplayMember = "CourseCode";*/
        }

       
      



      

        
      private void button1_Click_1(object sender, EventArgs e)
        {
            /*if (textBox1.Text == "" || textBox2.Text == "" )
                MessageBox.Show("please enter all values");
            else
            {
                int v;
                int result;
                if(Int32.TryParse(textBox2.Text,out v))
                 result = controllerObj.insertStudent(textBox1.Text, Int32.Parse(textBox2.Text), comboBox1.SelectedItem.ToString(), dateTimePicker1.Text);
                else 
                {
                    MessageBox.Show("please enter correct values ");
                    result = 0;
                }
                if (result == 0)
                {
                    MessageBox.Show("The insertion  failed");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully!");
                }
            }*/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*if(textBox4.Text=="" || textBox5.Text=="" || textBox6.Text=="")
                MessageBox.Show("please enter all values");
            else
            {
                int v;
                int result;
                if (Int32.TryParse(textBox6.Text, out v))

                    result = controllerObj.insertCourse(textBox4.Text, textBox5.Text, v);
                else
                {
                    MessageBox.Show("please enter correct values ");
                    result = 0;
                }
            if (result == 0)
            {
                MessageBox.Show("The insertion  failed");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully!");
            }
            }*/
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            

            /*int result = controllerObj.register(Convert.ToInt32(comboBox2.Text), comboBox3.Text); 

            if (result == 0)
            {
                MessageBox.Show("The insertion  failed");
            }
            else
            {
                MessageBox.Show("The row is inserted successfully!");
            }*/

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
           /* DataTable dt = controllerObj.SelectAll();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();*/

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           /* DataTable dt = controllerObj.Selecthours(Int32.Parse(comboBox2.Text));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();*/
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }









    }



}
