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
    public partial class Requests : Form
    {


        IRemoteServer.ManageAPInterface admin =
            (IRemoteServer.ManageAPInterface)Activator.GetObject(typeof(IRemoteServer.ManageAPInterface), "tcp://localhost:1756/obj");
        public Requests()
        {
            InitializeComponent();

           DataTable dt = new DataTable();
         








            dt.Columns.Add("الحالة", typeof(string));
            dt.Columns.Add("العلاقة", typeof(string));

            dt.Columns.Add("التاريخ", typeof(string));

            dt.Columns.Add("الاسم الكامل", typeof(string));













            List<IRemoteServer.RequestDoorcs> requests = admin.getRequsts();


            foreach (var request in requests)
            {
                dt.Rows.Add(request.Accepte ? "سماح" : "رفض", request.Zone, request.Date, request.FullName);
            }

            //   this.dataGridView1.AllowUserToAddRows = false;


            dataGridView1.DataSource = dt;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
