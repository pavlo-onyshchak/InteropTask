using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InteropTask1.Net
{
    public partial class frmStudentSearch : Form
    {
        public frmStudentSearch()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Controls.Add(grdSearch);
            getData();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getData()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=InteropTasks;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("StudentSearch", connection))
                {


                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", txbName.Text);
                    cmd.Parameters.AddWithValue("@Surname", txbSurname.Text);

                    DataTable dt = new DataTable();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    dt.Columns.Add("Name");
                    dt.Columns.Add("Surname");
                    dt.Columns.Add("Average Mark");

                    while (rdr.Read())
                    {
                        DataRow dr = dt.NewRow();
                        dr["Name"] = rdr["Name"];
                        dr["Surname"] = rdr["Surname"];
                        dr["Average Mark"] = rdr["AverageMark"];
                        dt.Rows.Add(dr);
                    }
                    grdSearch.DataSource = dt;
                }

            }
            // object k = grdShow.Rows[6].Cells["Number"].Value;
        }
    }
}
