using System.Windows.Forms;
using System.Drawing;

namespace InteropTask1.Net
{
    partial class frmShowStudents
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
            grdShow = new DataGridView();
            btnCancel = new Button();

            //btnCancel
            btnCancel.Size = new Size(60, 25);
            btnCancel.Location = new Point(120, 130);
            btnCancel.Text = "Cancel";
            btnCancel.Click += new System.EventHandler(btnCancel_Click);
            //grdShow
            grdShow.Location = new Point(7,5);
            grdShow.Size = new Size(280,100);
            grdShow.ColumnHeadersDefaultCellStyle.Font = new Font(grdShow.Font, FontStyle.Bold);
            grdShow.AllowUserToResizeColumns = false;
            grdShow.ReadOnly = true;
            grdShow.RowHeadersVisible = false;
           // grdShow.Dock = DockStyle.Fill;
            grdShow.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grdShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdShow.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            this.Controls.Add(grdShow);
            this.Controls.Add(btnCancel);

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Size = new Size(300, 200);
            this.Location = new Point(50, 100);
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "All Students";
        }
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView grdShow;

        #endregion
    }
}