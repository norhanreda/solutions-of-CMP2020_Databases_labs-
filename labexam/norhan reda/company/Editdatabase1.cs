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
    public partial class Edit_database1 : Form
    {
        Controller controllerObj;
        public Edit_database1()
        {
            controllerObj = new Controller();
            InitializeComponent();
            DataTable dt = controllerObj.SelectAllid();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember="employee_id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" )
                MessageBox.Show("please enter all values");
            else
            {
                int v;

                if (Int32.TryParse(textBox1.Text, out v))
                {
                    if (v > 0)
                    {
                        DataTable dt = controllerObj.SelectAll1(v);
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();
                    }
                    else
                        MessageBox.Show("please enter correct values ");
                }

                else
                {
                    MessageBox.Show("please enter correct values ");

                }
           
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                MessageBox.Show("please enter all values");
            else
            {
                int v;

                if (Int32.TryParse(textBox2.Text, out v))
                {
                    DataTable dt = controllerObj.SelectAll2(v);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();

                }

                else
                {
                    MessageBox.Show("please enter correct values ");

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAll3();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
                MessageBox.Show("please enter all values");
            else
            {
               
                    DataTable dt = controllerObj.SelectAll4(textBox3.Text);
                    dataGridView1.DataSource = dt;
                    dataGridView1.Refresh();

              

            }

        }

        private void Edit_database1_Load(object sender, EventArgs e)
        {

        }
    }
}
