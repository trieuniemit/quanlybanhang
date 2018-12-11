namespace QuanLyBanHang.Forms
{
    partial class BanHangForm_InHoaDon
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
            this.rpvHoaDonBanHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvHoaDonBanHang
            // 
            this.rpvHoaDonBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvHoaDonBanHang.LocalReport.ReportEmbeddedResource = "QuanLyBanHang.ProgramData.HoaDonBanHangReport.rdlc";
            this.rpvHoaDonBanHang.Location = new System.Drawing.Point(0, 0);
            this.rpvHoaDonBanHang.Name = "rpvHoaDonBanHang";
            this.rpvHoaDonBanHang.Size = new System.Drawing.Size(585, 582);
            this.rpvHoaDonBanHang.TabIndex = 0;
            this.rpvHoaDonBanHang.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // BanHangForm_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 582);
            this.Controls.Add(this.rpvHoaDonBanHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BanHangForm_HoaDon";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hóa đơn bán hàng";
            this.Load += new System.EventHandler(this.BanHangForm_HoaDon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvHoaDonBanHang;
    }
}