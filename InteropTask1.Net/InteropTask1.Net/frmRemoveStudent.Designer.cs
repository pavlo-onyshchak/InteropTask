using System.Windows.Forms;
using System.Drawing;

namespace InteropTask1.Net
{
    partial class frmRemoveStudent
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
            btnSearch = new Button();
            btnDelete = new Button();
            btnCancel = new Button();
            lblName = new Label();
            lblSurname = new Label();
            txbName = new TextBox();
            txbSurname = new TextBox();
            grdDeleteStudent = new DataGridView();
            //
            //btnSearch
            //
            btnSearch.Location = new System.Drawing.Point(270, 30);
            btnSearch.Size = new System.Drawing.Size(75, 23);
            btnSearch.Text = "Search";
            btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //
            //btnDelete
            //
            btnDelete.Location = new System.Drawing.Point(270, 70);
            btnDelete.Size = new System.Drawing.Size(75, 23);
            btnDelete.Text = "Delete";
            btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            btnDelete.Enabled = false;
            //
            //btnCancel
            //
            btnCancel.Size = new Size(60, 25);
            btnCancel.Location = new Point(400, 215);
            btnCancel.BackColor = Color.White;
            btnCancel.Text = "Cancel";
            btnCancel.Click += new System.EventHandler(btnCancel_Click);
            //
            // lblName
            //
            this.lblName.Location = new System.Drawing.Point(15, 30);
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.Text = "Name:";
            //
            // lblSurname
            //
            this.lblSurname.Location = new System.Drawing.Point(15, 70);
            this.lblSurname.Size = new System.Drawing.Size(100, 23);
            this.lblSurname.Text = "Surname:";
            //
            // txbName
            //
            this.txbName.Location = new System.Drawing.Point(120, 30);
            this.txbName.Size = new System.Drawing.Size(100, 20);
            //
            // txbSurname
            //
            this.txbSurname.Location = new System.Drawing.Point(120, 70);
            this.txbSurname.Size = new System.Drawing.Size(100, 20);
            //
            //grdDeleteStudent
            //
            grdDeleteStudent.Size = new Size(300, 127);
            grdDeleteStudent.Location = new Point(30, 115);
            grdDeleteStudent.ColumnHeadersDefaultCellStyle.Font = new Font(grdDeleteStudent.Font, FontStyle.Bold);
            grdDeleteStudent.AllowUserToResizeColumns = false;
            grdDeleteStudent.ReadOnly = true;
            grdDeleteStudent.RowHeadersVisible = false;
            grdDeleteStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdDeleteStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdDeleteStudent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grdDeleteStudent.CellClick += new DataGridViewCellEventHandler(grdCell_Click);

            // Icon icon = Icon.ExtractAssociatedIcon("..\\..\\resources\\icon.ico");
            // this.Icon = icon;
            this.Controls.Add(btnSearch);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnCancel);
            this.Controls.Add(lblName);
            this.Controls.Add(lblSurname);
            this.Controls.Add(txbName);
            this.Controls.Add(txbSurname);
            this.Controls.Add(grdDeleteStudent);


            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new Size(500, 300);
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Remove Student";
        }

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.DataGridView grdDeleteStudent;

        #endregion
    }
}