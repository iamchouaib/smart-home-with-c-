using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace person
{
    public partial class Form1 : Form
    {
        IRemoteServer.Person p = null;
        public Form1(IRemoteServer.Person p)
        {
            this.p = p;
            InitializeComponent();
        }
        IRemoteSurveillance.ManageSurveillaneInterface th =
    (IRemoteSurveillance.ManageSurveillaneInterface)Activator.GetObject(typeof(IRemoteSurveillance.ManageSurveillaneInterface), "tcp://localhost:1757/survimpl");

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dfToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = p.FullName;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            temp.Text = th.viewTemp();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_Click(object sender, EventArgs e)
        {
            temp.Text = th.viewTemp() + "°C";
            pt.Visible = true;
            ph.Visible = false;
            ps.Visible = false;
        }

        private void bh_Click(object sender, EventArgs e)
        {
            label3.Text = th.viewHum() + "%";
            ph.Visible = true;
            pt.Visible = false;
            ps.Visible = false;
        }

        private void br_Click(object sender, EventArgs e)
        {
            ps.Visible = true;
            ph.Visible = false;
            pt.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IRemoteSecurity.ReqInterface req =
    (IRemoteSecurity.ReqInterface)Activator.GetObject(typeof(IRemoteSecurity.ReqInterface), "tcp://localhost:1758/rq");

        

            if (req.request(p.Id, textBox1.Text))
            {

                label6.ForeColor = Color.Green;
                label6.Text = "تم فتح الباب بنجاح .";
            }else{
                label6.ForeColor = Color.Red;
                label6.Text = "سنقر لا تسرق .";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temp.Text = th.viewTemp() + "°C";
            label3.Text = th.viewHum() + "%";
            label1.Text = p.FullName;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            label3.Text = th.viewHum() + "%";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ps_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Menu_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pt_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ph_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
