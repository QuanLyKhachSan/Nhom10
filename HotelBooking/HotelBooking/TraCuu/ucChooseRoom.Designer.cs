namespace HotelBooking.TraCuu
{
    partial class ucChooseRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imgListRoom = new System.Windows.Forms.ImageList(this.components);
            this.lsvRoom = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btnDatPhong = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // imgListRoom
            // 
            this.imgListRoom.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListRoom.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListRoom.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lsvRoom
            // 
            this.lsvRoom.Location = new System.Drawing.Point(381, 23);
            this.lsvRoom.Margin = new System.Windows.Forms.Padding(4);
            this.lsvRoom.Name = "lsvRoom";
            this.lsvRoom.Size = new System.Drawing.Size(712, 502);
            this.lsvRoom.TabIndex = 7;
            this.lsvRoom.UseCompatibleStateImageBehavior = false;
            this.lsvRoom.Click += new System.EventHandler(this.lsvRoom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "THÔNG TIN PHÒNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(90, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(90, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(90, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thông tin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(90, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Đơn giá:";
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(179, 93);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.ReadOnly = true;
            this.txtLoaiPhong.Size = new System.Drawing.Size(176, 22);
            this.txtLoaiPhong.TabIndex = 4;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(179, 65);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.ReadOnly = true;
            this.txtMaPhong.Size = new System.Drawing.Size(91, 22);
            this.txtMaPhong.TabIndex = 3;
            this.txtMaPhong.TextChanged += new System.EventHandler(this.txtMaPhong_TextChanged);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(179, 121);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ReadOnly = true;
            this.txtGhiChu.Size = new System.Drawing.Size(176, 83);
            this.txtGhiChu.TabIndex = 5;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(179, 210);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(176, 22);
            this.txtDonGia.TabIndex = 6;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoi.Image = global::HotelBooking.Properties.Resources.Sync;
            this.btnLamMoi.Location = new System.Drawing.Point(260, 238);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(95, 25);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatPhong.Enabled = false;
            this.btnDatPhong.Image = global::HotelBooking.Properties.Resources.Dial;
            this.btnDatPhong.Location = new System.Drawing.Point(159, 238);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(95, 25);
            this.btnDatPhong.TabIndex = 2;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // ucChooseRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.txtLoaiPhong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvRoom);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucChooseRoom";
            this.Size = new System.Drawing.Size(1225, 549);
            this.Load += new System.EventHandler(this.ucChooseRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imgListRoom;
        private System.Windows.Forms.ListView lsvRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtDonGia;
        private DevExpress.XtraEditors.SimpleButton btnDatPhong;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
    }
}
