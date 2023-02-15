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
    public partial class UpdateForm : Form
    {

        private string userName;
        IRemoteServer.ManageAPInterface admin =
             (IRemoteServer.ManageAPInterface)Activator.GetObject(typeof(IRemoteServer.ManageAPInterface), "tcp://localhost:1756/obj");


        public UpdateForm(string fullName, string Zone , string userName)
        {
            InitializeComponent();

            this.userName = userName;
            nameInput.Text = fullName;
            zoneInput.Text = Zone;
            textBox1.Text = userName;

            label8.Text = label8.Text + " " +  fullName.ToUpper();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {



            if (admin.updatePerson(nameInput.Text, zoneInput.Text, textBox1.Text, userName))
            {

                this.Close();
            }
            else
            {
                label8.Text = "Some Problem with DB connection .";
            }

        }

    }
}
