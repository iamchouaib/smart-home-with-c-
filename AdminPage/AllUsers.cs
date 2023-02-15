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

    public partial class AllUsers : Form
    {

      IRemoteServer.ManageAPInterface admin =
              (IRemoteServer.ManageAPInterface)Activator.GetObject(typeof(IRemoteServer.ManageAPInterface), "tcp://localhost:1756/obj");


      DataTable dt;
        public AllUsers()
        {
            InitializeComponent();



      

            dataGridView1.ReadOnly = false;

            DataTable dt = new DataTable();
            this.dt = dt;
          
            dt.Columns.Add("Full Name", typeof(string));
            dt.Columns.Add("User Name", typeof(string));
            dt.Columns.Add("Relation Ship", typeof(string));
            dt.Columns.Add("Autorized", typeof(Boolean));


          

        



            dataGridView1.DataSource = dt;


                // Add a button column to the DataGridView
            DataGridViewButtonColumn buttonUpdate = new DataGridViewButtonColumn();
            buttonUpdate.Name = "Update";
            buttonUpdate.Text = "Update";
            buttonUpdate.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonUpdate);

            DataGridViewButtonColumn buttonDelete = new DataGridViewButtonColumn();
            buttonUpdate.Name = "Delete";
            buttonUpdate.Text = "Delete";
            buttonUpdate.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(buttonDelete);






            List<IRemoteServer.Person> users = admin.allUsers();


            foreach (var user in users)
            {
                dt.Rows.Add(user.FullName, user.UserName, user.Zone, user.IsAutorised);
            }

         //   this.dataGridView1.AllowUserToAddRows = false;


            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 150;

            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.ForeColor = Color.Black;
            dataGridView1.BackgroundColor = Color.White;

           


          

        }

  


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                   

                    string selectedRowId = row.Cells["User Name"].Value.ToString();
                    DeleteRecordFromDatabase(selectedRowId , e);

                    this.Refresh();
                }

                if (e.ColumnIndex == dataGridView1.Columns[""].Index)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                  
                    string currentId = row.Cells["Full Name"].Value.ToString();
                    string currentName = row.Cells["Relation Ship"].Value.ToString();
                    string userName = row.Cells["User Name"].Value.ToString();
                    using (UpdateForm form = new UpdateForm(currentId, currentName , userName))
                    {
                        form.ShowDialog();
                        dataGridView1.Refresh();
                        this.Refresh();
                    }
                }

                if (e.ColumnIndex == dataGridView1.Columns["Autorized"].Index)
                {
                   

                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    string currentName = row.Cells["User Name"].Value.ToString();
                    Boolean AutorizedCurrent =bool.Parse( row.Cells["Autorized"].Value.ToString());

                    if (admin.AutorisePerson(currentName, !AutorizedCurrent))
                    {


                        label3.Text = currentName + " " + (!AutorizedCurrent ? "autorazed" : "unatorazed");

                    }
                    else
                    {
                        label3.Text = "Error in qlq par";
                    }
                  
                 
                  //  dt.Rows[e.RowIndex]["Autorized"] = AutorizedCurrent;
                }
            }
   }

            private void DeleteRecordFromDatabase(string id , DataGridViewCellEventArgs e)
{

    DialogResult result = MessageBox.Show("Are you sure you want to delete this User?", "Confirmation", MessageBoxButtons.YesNo);
    if (result == DialogResult.Yes)
    {

      Boolean isOk =   admin.deletePerson(id);


      if (!isOk)
      {
          label2.ForeColor = Color.Red;
          label2.Text = "Some Problem with DB Connection please try letter ";
          DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
          int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
          dataGridView1.Rows.RemoveAt(selectedRowIndex);
          dt.Rows[selectedRowIndex].Delete();
          dataGridView1.Refresh();

        
      }
      else
      {

          label2.ForeColor = Color.Green;
          label2.Text = "Deleted with success !";
      }
    
    }
 
}

            private void AllUsers_Load(object sender, EventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }



     
    }
}
