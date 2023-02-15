using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        IRemoteAuth.AuthInterface auth =
            (IRemoteAuth.AuthInterface)Activator.GetObject(typeof(IRemoteAuth.AuthInterface), "tcp://localhost:1756/login");


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {



            //           obj.AddPerson(p);


            String email = emailInput.Text;
            String passowrd = passwordInput.Text;


            logo.Text = "Loading ... ";
            IRemoteServer.Person p = auth.login(email, passowrd);

            if (p != null)
            {
                logo.Text = "Succes , Welcome Again";

                //check if admin 

                if (p.Type.Equals("admin"))
                {
                    AdminPage.ConsultUsers admin = new AdminPage.ConsultUsers();
                    this.Hide();
                    admin.Show();
                }
                else
                {
                    person.Form1 f= new person.Form1(p);

                    
                    this.Hide();
                    f.Show();
                }


                //Else if a Persone 

            }
            else
            {
                logo.Text = "Error to authenticate";
                passwordInput.Text = "";

            }






        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }




    }
}
