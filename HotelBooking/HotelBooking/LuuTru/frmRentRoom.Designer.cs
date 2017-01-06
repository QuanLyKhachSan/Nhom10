namespace HotelBooking.LuuTru
{
    partial class frmRentRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRentRoom));
            this.pnlRentRoom = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlRentRoom
            // 
            this.pnlRentRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRentRoom.Location = new System.Drawing.Point(0, 0);
            this.pnlRentRoom.Name = "pnlRentRoom";
            this.pnlRentRoom.Size = new System.Drawing.Size(990, 461);
            this.pnlRentRoom.TabIndex = 0;
            // 
            // frmRentRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 461);
            this.Controls.Add(this.pnlRentRoom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRentRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐẶT PHÒNG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRentRoom_FormClosing);
            this.Load += new System.EventHandler(this.frmRentRoom_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRentRoom;
    }
}