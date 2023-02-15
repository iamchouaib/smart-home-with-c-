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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();

            
        }

      
        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  ConsultUsers cu = new ConsultUsers();
          //  cu.ShowDialog();


            IRemoteServer.ManageAPInterface  admin =
              (IRemoteServer.ManageAPInterface)Activator.GetObject(typeof(IRemoteServer.ManageAPInterface), "tcp://localhost:1756/obj");


           
            
            if(passwordInput.Text.Equals("") || nameInput.Text.Equals("")){

                label8.Text = "فشلت المهمة";
                label8.ForeColor = Color.Red;
            return ;}


            if (admin.AddPerson(nameInput.Text,passwordInput.Text,zoneInput.Text))
            {
                label8.Text = "تم اضافة المستخدم بنجاح";

                nameInput.Text = "";
                passwordInput.Text = "" ;
                zoneInput.Text = "";


            }
            else
            {

                label8.Text = "فشلت المهمة";
                label8.ForeColor = Color.Red;


            }

            
            

            //Call addPersone Method



          //  this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //go to all users
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void zoneInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
