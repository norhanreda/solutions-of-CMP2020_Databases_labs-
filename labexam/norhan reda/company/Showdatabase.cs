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
    public partial class Showdatabase : Form
    {
        Controller controllerObj;
        public Showdatabase()
        {
            InitializeComponent();
        }

        private void Showdatabase_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }

       

      

       

        private void button1_Click_1(object sender, EventArgs e)
        {

            DataTable dt = controllerObj.SelectAllemployees();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           DataTable dt = controllerObj.SelectAlldependents();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAlldepartments();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectAlljobs();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DataTable dt = controllerObj.SelectAlllocations();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            DataTable dt = controllerObj.SelectAllcountries();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            DataTable dt = controllerObj.SelectAllregions();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }


    }
}
