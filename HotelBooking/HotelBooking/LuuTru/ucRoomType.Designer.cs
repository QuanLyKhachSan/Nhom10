namespace HotelBooking.LuuTru
{
    partial class ucRoomType
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gcLoaiPhong = new DevExpress.XtraGrid.GridControl();
            this.gvLoaiPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grcSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcMaLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcTenLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grcDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtDonGia);
            this.panel1.Controls.Add(this.txtLoaiPhong);
            this.panel1.Controls.Add(this.txtMaPhong);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 131);
            this.panel1.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Image = global::HotelBooking.Properties.Resources.Save;
            this.btnLuu.Location = new System.Drawing.Point(865, 93);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(95, 25);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Image = global::HotelBooking.Properties.Resources.Delete;
            this.btnXoa.Location = new System.Drawing.Point(764, 93);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 25);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhat.Image = global::HotelBooking.Properties.Resources.Equipment;
            this.btnCapNhat.Location = new System.Drawing.Point(663, 93);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(95, 25);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Image = global::HotelBooking.Properties.Resources.Create;
            this.btnThem.Location = new System.Drawing.Point(562, 93);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 25);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDonGia.Location = new System.Drawing.Point(805, 58);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(155, 23);
            this.txtDonGia.TabIndex = 3;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Enabled = false;
            this.txtLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLoaiPhong.Location = new System.Drawing.Point(556, 58);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(155, 23);
            this.txtLoaiPhong.TabIndex = 2;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Enabled = false;
            this.txtMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMaPhong.Location = new System.Drawing.Point(286, 58);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(155, 23);
            this.txtMaPhong.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(467, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Loại phòng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(738, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Đơn giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(447, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "DANH MỤC LOẠI PHÒNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(179, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã loại phòng:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gcLoaiPhong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1006, 369);
            this.panel2.TabIndex = 1;
            // 
            // gcLoaiPhong
            // 
            this.gcLoaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLoaiPhong.Location = new System.Drawing.Point(0, 0);
            this.gcLoaiPhong.MainView = this.gvLoaiPhong;
            this.gcLoaiPhong.Name = "gcLoaiPhong";
            this.gcLoaiPhong.Size = new System.Drawing.Size(1006, 369);
            this.gcLoaiPhong.TabIndex = 2;
            this.gcLoaiPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLoaiPhong});
            // 
            // gvLoaiPhong
            // 
            this.gvLoaiPhong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grcSTT,
            this.grcMaLoaiPhong,
            this.grcTenLoaiPhong,
            this.grcDonGia});
            this.gvLoaiPhong.GridControl = this.gcLoaiPhong;
            this.gvLoaiPhong.Name = "gvLoaiPhong";
            this.gvLoaiPhong.OptionsBehavior.Editable = false;
            this.gvLoaiPhong.OptionsView.ShowGroupPanel = false;
            this.gvLoaiPhong.Click += new System.EventHandler(this.gvLoaiPhong_Click);
            // 
            // grcSTT
            // 
            this.grcSTT.Caption = "STT";
            this.grcSTT.Name = "grcSTT";
            this.grcSTT.Visible = true;
            this.grcSTT.VisibleIndex = 0;
            // 
            // grcMaLoaiPhong
            // 
            this.grcMaLoaiPhong.Caption = "Mã loại phòng";
            this.grcMaLoaiPhong.FieldName = "MaLoaiPhong";
            this.grcMaLoaiPhong.Name = "grcMaLoaiPhong";
            this.grcMaLoaiPhong.Visible = true;
            this.grcMaLoaiPhong.VisibleIndex = 1;
            // 
            // grcTenLoaiPhong
            // 
            this.grcTenLoaiPhong.Caption = "Tên loại phòng";
            this.grcTenLoaiPhong.FieldName = "TenLoaiPhong";
            this.grcTenLoaiPhong.Name = "grcTenLoaiPhong";
            this.grcTenLoaiPhong.Visible = true;
            this.grcTenLoaiPhong.VisibleIndex = 2;
            // 
            // grcDonGia
            // 
            this.grcDonGia.Caption = "Đơn giá";
            this.grcDonGia.FieldName = "DonGia";
            this.grcDonGia.Name = "grcDonGia";
            this.grcDonGia.Visible = true;
            this.grcDonGia.VisibleIndex = 3;
            // 
            // ucRoomType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucRoomType";
            this.Size = new System.Drawing.Size(1006, 500);
            this.Load += new System.EventHandler(this.ucRoomType_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl gcLoaiPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLoaiPhong;
        private DevExpress.XtraGrid.Columns.GridColumn grcSTT;
        private DevExpress.XtraGrid.Columns.GridColumn grcMaLoaiPhong;
        private DevExpress.XtraGrid.Columns.GridColumn grcTenLoaiPhong;
        private DevExpress.XtraGrid.Columns.GridColumn grcDonGia;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnThem;

    }
}
