using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    
    public partial class Form1 : Form
    {
        string n;
        string g;
        bool valid;
        int counta, countb, countc, countd, counte, countf;
        
        public Form1()
        {
            InitializeComponent();
            counta = 0;
            countb = 0;
            countc = 0;
            countd = 0;
            counte = 0;
            countf = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
          
            n = textBox1.Text;
            g = comboBox1.Text;
             valid=true;
            if (n == "")
                valid = false;
            if (g != "A" && g != "B" && g != "C" && g != "D" && g != "E" && g != "F")
                valid = false;

            if (valid)
            {
                Object[] data = { n, g };



                dataGridView1.Rows.Add(data);
                if (g == "A")
                    counta++;
               if (g == "B")
                    countb++;
                if (g == "C")
                    countc++;
                 if (g == "D")
                    countd++;
                if (g == "E")
                    counte++;
                 if (g == "F")
                    countf++;

            }
            else
                MessageBox.Show("please enter valid values");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f=new Form2();
            f.Show();
            f.dataGridView2.Rows.Add("A",counta);
            f.dataGridView2.Rows.Add("B", countb);
            f.dataGridView2.Rows.Add("C", countc);
            f.dataGridView2.Rows.Add("D", countd);
            f.dataGridView2.Rows.Add("E", counte);
            f.dataGridView2.Rows.Add("F", countf);

            
            

        }
    }
}
