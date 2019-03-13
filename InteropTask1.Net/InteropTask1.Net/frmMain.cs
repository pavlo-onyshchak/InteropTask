using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InteropTask1.Net
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddStudent frmAddStudent = new frmAddStudent();
            frmAddStudent.Show();
        }
        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            frmRemoveStudent RemoveStudent = new frmRemoveStudent();
            RemoveStudent.Show();
        }
        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            frmShowStudents ShowStudent = new frmShowStudents();
            ShowStudent.Show();
        }
        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            frmStudentSearch StudentSearch = new frmStudentSearch();
            StudentSearch.Show();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
