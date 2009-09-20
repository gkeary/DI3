using System.Windows.Forms;
using System.Drawing;
namespace WinClient
{
    partial class frmDeleteDrivers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.CheckedListBox dvrList;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Button btnDeleteDrivers;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dvrList = new System.Windows.Forms.CheckedListBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteDrivers = new System.Windows.Forms.Button();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvrList
            // 
            this.dvrList.CheckOnClick = true;
            this.dvrList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dvrList.HorizontalScrollbar = true;
            this.dvrList.Location = new System.Drawing.Point(0, 0);
            this.dvrList.MultiColumn = true;
            this.dvrList.Name = "dvrList";
            this.dvrList.Size = new System.Drawing.Size(548, 199);
            this.dvrList.Sorted = true;
            this.dvrList.TabIndex = 0;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.btnDeleteDrivers);
            this.Panel1.Location = new System.Drawing.Point(144, 208);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(288, 64);
            this.Panel1.TabIndex = 1;
            // 
            // btnDeleteDrivers
            // 
            this.btnDeleteDrivers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteDrivers.Location = new System.Drawing.Point(0, 0);
            this.btnDeleteDrivers.Name = "btnDeleteDrivers";
            this.btnDeleteDrivers.Size = new System.Drawing.Size(288, 64);
            this.btnDeleteDrivers.TabIndex = 0;
            this.btnDeleteDrivers.Text = "Delete Drivers";
            this.btnDeleteDrivers.Click += new System.EventHandler(this.btnDeleteDrivers_Click);
            // 
            // frmDeleteDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 357);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.dvrList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDeleteDrivers";
            this.Text = "Delete Drivers";
            this.Load += new System.EventHandler(this.frmDeleteDrivers_Load);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}