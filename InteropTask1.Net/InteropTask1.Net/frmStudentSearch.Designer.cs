using System.Windows.Forms;
using System.Drawing;

namespace InteropTask1.Net
{
    partial class frmStudentSearch
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
            btnOK = new Button();
            btnCancel = new Button();
            lblName = new Label();
            lblSurname = new Label();
            txbName = new TextBox();
            txbSurname = new TextBox();
            grdSearch = new DataGridView();
            //
            //btnOK
            //
            btnOK.Location = new Point(120, 220);
            btnOK.Size = new Size(75, 23);
            btnOK.Name = "btnOK";
            btnOK.Text = "OK";
            btnOK.Click += new System.EventHandler(this.btnOK_Click);
            //
            //btnCancel
            //
            btnCancel.Location = new Point(200, 220);
            btnCancel.Size = new Size(75, 23);
            btnCancel.Name = "btnCancel";
            btnCancel.Text = "Cancel";
            btnCancel.Click += new System.EventHandler(btnCancel_Click);
            //
            // lblName
            //
            this.lblName.Location = new Point(15, 30);
            this.lblName.Size = new Size(100, 23);
            this.lblName.Name = "lblName";
            this.lblName.Text = "Name:";
            //
            // lblSurname
            //
            this.lblSurname.Location = new Point(15, 70);
            this.lblSurname.Size = new Size(100, 23);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Text = "Surname:";
            //
            // txbName
            //
            this.txbName.Location = new Point(120, 30);
            this.txbName.Size = new Size(100, 20);
            this.txbName.Name = "txbName";
            //
            // txbSurname
            //
            this.txbSurname.Location = new Point(120, 70);
            this.txbSurname.Size = new Size(100, 20);
            this.txbSurname.Name = "txbSurname";
            //
            //grdSearch
            //
            grdSearch.Size = new Size(300, 70);
            grdSearch.Location = new Point(5, 115);
            grdSearch.ColumnHeadersDefaultCellStyle.Font = new Font(grdSearch.Font, FontStyle.Bold);
            grdSearch.ReadOnly = true;
            grdSearch.AllowUserToResizeColumns = false;
            grdSearch.RowHeadersVisible = false;
            grdSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grdSearch.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grdSearch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdSearch.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            this.Controls.Add(btnOK);
            this.Controls.Add(btnCancel);
            this.Controls.Add(lblName);
            this.Controls.Add(lblSurname);
            this.Controls.Add(txbName);
            this.Controls.Add(txbSurname);

            //Icon icon = Icon.ExtractAssociatedIcon("..\\..\\resources\\icon.ico");
            // this.Icon = icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new Size(400, 300);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Student Search";
        }

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.DataGridView grdSearch;

        #endregion
    }
}