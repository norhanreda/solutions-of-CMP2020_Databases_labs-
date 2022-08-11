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
    public partial class welcome : Form
    {
        Controller controllerObj;
        public welcome()
        {
            InitializeComponent();
        }

        private void welcome_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }

      
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            Showdatabase forms = new Showdatabase();
            forms.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Edit_database1 forme = new Edit_database1();
            forme.Show();

           /* Editdatabase1 forme = new Editdatabase1();
            forme.Show();*/
        }



    }
}
