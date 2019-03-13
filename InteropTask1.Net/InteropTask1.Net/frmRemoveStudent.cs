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
    public partial class frmRemoveStudent : Form
    {
        public frmRemoveStudent()
        {
            InitializeComponent();
            getAllData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getSearchedData();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            getAllData();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void grdCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            int k = e.RowIndex;
            btnDelete.Enabled = true;
            DeleteData(e);
        }
        private void getAllData()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=InteropTasks;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Students", connection);
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
                grdDeleteStudent.DataSource = dt;
            }

        }

        private void getSearchedData()
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
                    grdDeleteStudent.DataSource = dt;
                }

            }

        }
        private void DeleteData(DataGridViewCellEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=InteropTasks;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("DeleteStudent", connection))
                {

                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", grdDeleteStudent.Rows[e.RowIndex].Cells["Name"].Value);  //object k = grdShow.Rows[6].Cells["Number"].Value;
                    cmd.Parameters.AddWithValue("@Surname", grdDeleteStudent.Rows[e.RowIndex].Cells["Surname"].Value);
                    cmd.ExecuteNonQuery();
                }

            }
        }
    }
}

