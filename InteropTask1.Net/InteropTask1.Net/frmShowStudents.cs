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
    public partial class frmShowStudents : Form
    {
        public frmShowStudents()
        {
            InitializeComponent();
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
                grdShow.DataSource = dt;
            }
        }
    }
}
