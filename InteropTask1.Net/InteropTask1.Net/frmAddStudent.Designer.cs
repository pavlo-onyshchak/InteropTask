using System.Windows.Forms;
using System.Drawing;
namespace InteropTask1.Net
{
    partial class frmAddStudent
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
            lblName = new Label();
            lblAverageMark = new Label();
            lblSurname = new Label();
            txbName = new TextBox();
            txbSurname = new TextBox();
            txbAverageMark = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            //
            // lblName
            //
            this.lblName.Location = new System.Drawing.Point(15, 30);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            //
            // lblAverageMark
            //
            this.lblAverageMark.Location = new System.Drawing.Point(15, 100);
            this.lblAverageMark.Name = "lblAverageMark";
            this.lblAverageMark.Size = new System.Drawing.Size(100, 23);
            this.lblAverageMark.TabIndex = 3;
            this.lblAverageMark.Text = "Average Mark:";
            //
            // lblSurname
            //
            this.lblSurname.Location = new System.Drawing.Point(15, 70);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(100, 23);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Surname:";
            //
            // txbName
            //
            this.txbName.Location = new System.Drawing.Point(120, 30);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 20);
            //
            // txbSurname
            //
            this.txbSurname.Location = new System.Drawing.Point(120, 70);
            this.txbSurname.Name = "txbSurname";
            this.txbSurname.Size = new System.Drawing.Size(100, 20);
            //
            // txbAverageMark
            //
            this.txbAverageMark.Location = new System.Drawing.Point(120, 100);
            this.txbAverageMark.Name = "txbAverageMark";
            this.txbAverageMark.Size = new System.Drawing.Size(100, 20);
            //
            // btnOK
            //
            this.btnOK.Location = new System.Drawing.Point(100, 200);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            //
            // btnCancel
            //
            this.btnCancel.Location = new System.Drawing.Point(200, 200);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            //
            // frmAddEmployee
            //
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAverageMark);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.txbAverageMark);
            this.Controls.Add(this.txbSurname);

            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Add Student";
        }

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblAverageMark;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbSurname;
        private System.Windows.Forms.TextBox txbAverageMark;

        #endregion
    }
}