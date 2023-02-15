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
    public partial class AddPersone : Form
    {
        public AddPersone()
        {
            InitializeComponent();
        }

        private void fName_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void AddPersone_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            ConsultUsers cu = new ConsultUsers();
            cu.Show();
            this.Hide();
         
        }
    }
}
