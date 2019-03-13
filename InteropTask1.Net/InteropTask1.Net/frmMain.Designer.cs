using System.Windows.Forms;
using System.Drawing;
namespace InteropTask1.Net
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            btnAddStudent = new Button();
            btnRemoveStudent = new Button();
            btnShowStudents = new Button();
            btnStudentSearch = new Button();
            btnCancel = new Button();

            //btnAddStudent
            btnAddStudent.Size = new Size(110, 25);
            btnAddStudent.Location = new Point(100, 50);
            btnAddStudent.BackColor = Color.White;
            btnAddStudent.Text = "Add student";
            btnAddStudent.Click += new System.EventHandler(btnAddStudent_Click);


            //btnRemoveStudent
            btnRemoveStudent.Size = new Size(110, 25);
            btnRemoveStudent.Location = new Point(100, 75);
            btnRemoveStudent.BackColor = Color.White;
            btnRemoveStudent.Text = "Remove student";
            btnRemoveStudent.Click += new System.EventHandler(btnRemoveStudent_Click);

            //btnShowStudents
            btnShowStudents.Size = new Size(110, 25);
            btnShowStudents.Location = new Point(100, 100);
            btnShowStudents.BackColor = Color.White;
            btnShowStudents.AutoSize = true;
            btnShowStudents.Text = "Show student";
            btnShowStudents.Click += new System.EventHandler(btnShowStudents_Click);

            //btnStudentSearch
            btnStudentSearch.Size = new Size(110, 25);
            btnStudentSearch.Location = new Point(100, 125);
            btnStudentSearch.BackColor = Color.White;
            btnStudentSearch.Text = "Student search";
            btnStudentSearch.Click += new System.EventHandler(btnStudentSearch_Click);

            //btnCancel
            btnCancel.Size = new Size(60, 25);
            btnCancel.Location = new Point(120, 200);
            btnCancel.BackColor = Color.White;
            btnCancel.Text = "Cancel";
            btnCancel.Click += new System.EventHandler(btnCancel_Click);



            this.Controls.Add(btnAddStudent);
            this.Controls.Add(btnRemoveStudent);
            this.Controls.Add(btnShowStudents);
            this.Controls.Add(btnStudentSearch);
            this.Controls.Add(btnCancel);

           // Icon icon = Icon.ExtractAssociatedIcon("..\\..\\resources\\icon.ico");
            //this.Icon = icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;


            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = ".NET Form";
        }

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Button btnShowStudents;
        private System.Windows.Forms.Button btnStudentSearch;
        private System.Windows.Forms.Button btnCancel;
        #endregion
    }
}