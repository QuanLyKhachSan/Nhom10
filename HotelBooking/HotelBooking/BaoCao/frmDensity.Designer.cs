namespace HotelBooking.BaoCao
{
    partial class frmDensity
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDensity));
            this.BCMatDoDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtTatCa = new System.Windows.Forms.RadioButton();
            this.rbtTheoThang = new System.Windows.Forms.RadioButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnXem = new DevExpress.XtraEditors.SimpleButton();
            this.dtpMDThang = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewerMatDo = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.BCMatDoDTOBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BCMatDoDTOBindingSource
            // 
            this.BCMatDoDTOBindingSource.DataSource = typeof(DTO.BCMatDoDTO);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtTatCa);
            this.panel1.Controls.Add(this.rbtTheoThang);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.dtpMDThang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 105);
            this.panel1.TabIndex = 1;
            // 
            // rbtTatCa
            // 
            this.rbtTatCa.AutoSize = true;
            this.rbtTatCa.Location = new System.Drawing.Point(377, 42);
            this.rbtTatCa.Name = "rbtTatCa";
            this.rbtTatCa.Size = new System.Drawing.Size(66, 21);
            this.rbtTatCa.TabIndex = 3;
            this.rbtTatCa.TabStop = true;
            this.rbtTatCa.Text = "Tất cả";
            this.rbtTatCa.UseVisualStyleBackColor = true;
            // 
            // rbtTheoThang
            // 
            this.rbtTheoThang.AutoSize = true;
            this.rbtTheoThang.Location = new System.Drawing.Point(272, 42);
            this.rbtTheoThang.Name = "rbtTheoThang";
            this.rbtTheoThang.Size = new System.Drawing.Size(99, 21);
            this.rbtTheoThang.TabIndex = 3;
            this.rbtTheoThang.TabStop = true;
            this.rbtTheoThang.Text = "Theo tháng";
            this.rbtTheoThang.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.Enabled = false;
            this.btnLuu.Image = global::HotelBooking.Properties.Resources.Save;
            this.btnLuu.Location = new System.Drawing.Point(353, 69);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXem
            // 
            this.btnXem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXem.Image = global::HotelBooking.Properties.Resources.Table;
            this.btnXem.Location = new System.Drawing.Point(272, 69);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dtpMDThang
            // 
            this.dtpMDThang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMDThang.Location = new System.Drawing.Point(272, 13);
            this.dtpMDThang.Name = "dtpMDThang";
            this.dtpMDThang.Size = new System.Drawing.Size(171, 23);
            this.dtpMDThang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewerMatDo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 411);
            this.panel2.TabIndex = 2;
            // 
            // reportViewerMatDo
            // 
            this.reportViewerMatDo.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetMD";
            reportDataSource1.Value = this.BCMatDoDTOBindingSource;
            this.reportViewerMatDo.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerMatDo.LocalReport.ReportEmbeddedResource = "HotelBooking.BaoCao.rpDensity.rdlc";
            this.reportViewerMatDo.Location = new System.Drawing.Point(0, 0);
            this.reportViewerMatDo.Name = "reportViewerMatDo";
            this.reportViewerMatDo.Size = new System.Drawing.Size(682, 411);
            this.reportViewerMatDo.TabIndex = 0;
            // 
            // frmDensity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 516);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(698, 555);
            this.MinimumSize = new System.Drawing.Size(698, 555);
            this.Name = "frmDensity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BÁO CÁO MẬT ĐỘ SỬ DỤNG PHÒNG";
            this.Load += new System.EventHandler(this.frmDensity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BCMatDoDTOBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtTatCa;
        private System.Windows.Forms.RadioButton rbtTheoThang;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnXem;
        private System.Windows.Forms.DateTimePicker dtpMDThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerMatDo;
        private System.Windows.Forms.BindingSource BCMatDoDTOBindingSource;
    }
}