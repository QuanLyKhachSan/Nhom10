namespace HotelBooking.LuuTru
{
    partial class frmInforCus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInforCus));
            this.gcDSKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gvDSKhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLoaiKhach = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDSKhachHang
            // 
            this.gcDSKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDSKhachHang.Location = new System.Drawing.Point(0, 0);
            this.gcDSKhachHang.MainView = this.gvDSKhachHang;
            this.gcDSKhachHang.Name = "gcDSKhachHang";
            this.gcDSKhachHang.Size = new System.Drawing.Size(696, 148);
            this.gcDSKhachHang.TabIndex = 0;
            this.gcDSKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSKhachHang});
            // 
            // gvDSKhachHang
            // 
            this.gvDSKhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKhachHang,
            this.colTenKhachHang,
            this.colCMND,
            this.colDiaChi,
            this.colMaLoaiKhach});
            this.gvDSKhachHang.GridControl = this.gcDSKhachHang;
            this.gvDSKhachHang.Name = "gvDSKhachHang";
            this.gvDSKhachHang.OptionsBehavior.Editable = false;
            this.gvDSKhachHang.OptionsView.ShowGroupPanel = false;
            // 
            // colMaKhachHang
            // 
            this.colMaKhachHang.Caption = "Mã khách hàng";
            this.colMaKhachHang.FieldName = "MaKH";
            this.colMaKhachHang.Name = "colMaKhachHang";
            this.colMaKhachHang.Visible = true;
            this.colMaKhachHang.VisibleIndex = 0;
            // 
            // colTenKhachHang
            // 
            this.colTenKhachHang.Caption = "Tên khách hàng";
            this.colTenKhachHang.FieldName = "TenKhachHang";
            this.colTenKhachHang.Name = "colTenKhachHang";
            this.colTenKhachHang.Visible = true;
            this.colTenKhachHang.VisibleIndex = 1;
            // 
            // colCMND
            // 
            this.colCMND.Caption = "CMND";
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 2;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 3;
            // 
            // colMaLoaiKhach
            // 
            this.colMaLoaiKhach.Caption = "Mã loại khách";
            this.colMaLoaiKhach.FieldName = "MaLoaiKhach";
            this.colMaLoaiKhach.Name = "colMaLoaiKhach";
            this.colMaLoaiKhach.Visible = true;
            this.colMaLoaiKhach.VisibleIndex = 4;
            // 
            // frmInforCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 148);
            this.Controls.Add(this.gcDSKhachHang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(712, 187);
            this.MinimumSize = new System.Drawing.Size(712, 187);
            this.Name = "frmInforCus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN KHÁCH THUÊ PHÒNG";
            this.Load += new System.EventHandler(this.frmInforCus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDSKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDSKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiKhach;

    }
}