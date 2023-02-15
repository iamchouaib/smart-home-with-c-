using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminPage
{
    public partial class ConsultUsers : Form
    {
        public ConsultUsers()
        {
            InitializeComponent();
        } 
        
        
        private void ConsultUsers_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //e6747c
        }

        private void addPersone_Click(object sender, EventArgs e)
        {
            using (AddUser form = new AddUser())
            {
                form.ShowDialog();

                this.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            using (AllUsers form = new AllUsers())
            {
                form.ShowDialog();
               
                this.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Security form = new Security())
            {
                form.ShowDialog();

                this.Refresh();
            }
        }

       
    }
}
