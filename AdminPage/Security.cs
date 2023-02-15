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
    public partial class Security : Form
    {

        IRemoteServer.ManageAPInterface admin =
             (IRemoteServer.ManageAPInterface)Activator.GetObject(typeof(IRemoteServer.ManageAPInterface), "tcp://localhost:1756/obj");

        IRemoteSurveillance.ManageSurveillaneInterface th =
 (IRemoteSurveillance.ManageSurveillaneInterface)Activator.GetObject(typeof(IRemoteSurveillance.ManageSurveillaneInterface), "tcp://localhost:1757/survimpl");


      
        
        public Security()
        {

            
            InitializeComponent();




            if(!admin.checkDoorState()){
button1.Text = "فتح الباب";
              
button1.BackColor = Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(167)))), ((int)(((byte)(119)))));


            }else{
                button1.Text = " غلق الباب";
                button1.BackColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            }




           

            DataTable dt = new DataTable();
            




            
            
           
           
dt.Columns.Add("الحالة", typeof(string));
 dt.Columns.Add("العلاقة", typeof(string));

 dt.Columns.Add("التاريخ", typeof(string));

dt.Columns.Add("الاسم الكامل", typeof(string));



          


         






            List<IRemoteServer.RequestDoorcs> requests = admin.getRequsts();

            
            foreach (var request in requests)
            {
                dt.Rows.Add(request.Accepte.ToString() ,request.Zone,request.Date,request.FullName);
            }

            //   this.dataGridView1.AllowUserToAddRows = false;


            dataGridView1.DataSource = dt;

            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

      
        }


      
      
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
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_Click(object sender, EventArgs e)
        {
            door.Visible = false;
            request.Visible = true;
            panel3.Visible = false;

            new Requests().ShowDialog();

            

          
        }

        private void bh_Click(object sender, EventArgs e)
        {
          
           label3.Text = th.viewHum() + "%";
          label2.Text = th.viewTemp() + "°C"; 


           
            panel3.Visible = true;
         
            door.Visible = false;
            request.Visible = false;
          
          
        }

        private void br_Click(object sender, EventArgs e)
        {
            door.Visible = false;
            panel3.Visible = false;
            request.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin.toggleDoor();

            

            if (!admin.checkDoorState())
            {
                button1.Text = "فتح الباب";

                button1.BackColor = Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(167)))), ((int)(((byte)(119)))));


            }
            else
            {
                button1.Text = " غلق الباب";
                button1.BackColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            }



        }

     

        private void button2_Click_1(object sender, EventArgs e)
        {
            door.Visible = true;
            request.Visible = false;
           
            panel3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (admin.changePassword(textBox1.Text, textBox2.Text)){
               label8.Text = " تم تغيير كلمة المرور بنجناح";

                label8.ForeColor = Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(167)))), ((int)(((byte)(119)))));


            }
            else{
                label8.Text = " كلمة المرور خاظئة";
                label8.ForeColor = Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(68)))), ((int)(((byte)(78)))));
            }
        }

        private void door_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

      
    }
}
