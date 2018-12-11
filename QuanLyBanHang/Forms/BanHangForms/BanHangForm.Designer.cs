namespace QuanLyBanHang.Forms
{
    partial class BanHangForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTienTra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTienGui = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSoDienThoai = new System.Windows.Forms.TextBox();
            this.tbKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaSanPham = new System.Windows.Forms.TextBox();
            this.cbExport = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.ptbAdd = new System.Windows.Forms.PictureBox();
            this.ptbRemove = new System.Windows.Forms.PictureBox();
            this.dgvListProduct = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(680, 58);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(200, 26);
            this.tbTotal.TabIndex = 6;
            this.tbTotal.Text = "0đ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(520, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số tiền trả lại";
            // 
            // tbTienTra
            // 
            this.tbTienTra.Enabled = false;
            this.tbTienTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTienTra.Location = new System.Drawing.Point(680, 97);
            this.tbTienTra.Name = "tbTienTra";
            this.tbTienTra.ReadOnly = true;
            this.tbTienTra.Size = new System.Drawing.Size(200, 26);
            this.tbTienTra.TabIndex = 7;
            this.tbTienTra.Text = "0đ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(520, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tổng tiền";
            // 
            // tbTienGui
            // 
            this.tbTienGui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTienGui.Location = new System.Drawing.Point(680, 21);
            this.tbTienGui.Name = "tbTienGui";
            this.tbTienGui.Size = new System.Drawing.Size(200, 26);
            this.tbTienGui.TabIndex = 3;
            this.tbTienGui.LostFocus += new System.EventHandler(this.tbTienGui_LostFocus);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(520, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiền KH trả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số điện thoại KH";
            // 
            // tbSoDienThoai
            // 
            this.tbSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoDienThoai.Location = new System.Drawing.Point(156, 61);
            this.tbSoDienThoai.Name = "tbSoDienThoai";
            this.tbSoDienThoai.Size = new System.Drawing.Size(258, 26);
            this.tbSoDienThoai.TabIndex = 9;
            // 
            // tbKhachHang
            // 
            this.tbKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKhachHang.Location = new System.Drawing.Point(156, 24);
            this.tbKhachHang.Name = "tbKhachHang";
            this.tbKhachHang.Size = new System.Drawing.Size(258, 26);
            this.tbKhachHang.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng";
            // 
            // tbMaSanPham
            // 
            this.tbMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaSanPham.Location = new System.Drawing.Point(91, 20);
            this.tbMaSanPham.MaxLength = 20;
            this.tbMaSanPham.Name = "tbMaSanPham";
            this.tbMaSanPham.Size = new System.Drawing.Size(183, 26);
            this.tbMaSanPham.TabIndex = 9;
            this.tbMaSanPham.Text = "Nhập mã sản phẩm...";
            this.tbMaSanPham.GotFocus += new System.EventHandler(this.tbMaSanPham_GotFocus);
            this.tbMaSanPham.LostFocus += new System.EventHandler(this.tbMaSanPham_LostFocus);
            // 
            // cbExport
            // 
            this.cbExport.AutoSize = true;
            this.cbExport.Checked = true;
            this.cbExport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExport.ForeColor = System.Drawing.Color.Black;
            this.cbExport.Location = new System.Drawing.Point(586, 20);
            this.cbExport.Name = "cbExport";
            this.cbExport.Size = new System.Drawing.Size(195, 24);
            this.cbExport.TabIndex = 13;
            this.cbExport.Text = "Xuất hóa đơn bán hàng";
            this.cbExport.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nudQuantity);
            this.panel3.Controls.Add(this.cbExport);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.tbMaSanPham);
            this.panel3.Controls.Add(this.ptbAdd);
            this.panel3.Controls.Add(this.ptbRemove);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 477);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(972, 60);
            this.panel3.TabIndex = 15;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(290, 20);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(42, 26);
            this.nudQuantity.TabIndex = 15;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::QuanLyBanHang.Properties.Resources.save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(793, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 31);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu Lại";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseCompatibleTextRendering = true;
            this.btnSave.UseMnemonic = false;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ptbAdd
            // 
            this.ptbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAdd.Image = global::QuanLyBanHang.Properties.Resources.plus;
            this.ptbAdd.Location = new System.Drawing.Point(338, 17);
            this.ptbAdd.Name = "ptbAdd";
            this.ptbAdd.Size = new System.Drawing.Size(31, 30);
            this.ptbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAdd.TabIndex = 10;
            this.ptbAdd.TabStop = false;
            this.ptbAdd.Click += new System.EventHandler(this.ptbAdd_Click);
            this.ptbAdd.MouseHover += new System.EventHandler(this.ptbAdd_MouseHover);
            // 
            // ptbRemove
            // 
            this.ptbRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbRemove.Image = global::QuanLyBanHang.Properties.Resources.remove;
            this.ptbRemove.Location = new System.Drawing.Point(372, 18);
            this.ptbRemove.Name = "ptbRemove";
            this.ptbRemove.Size = new System.Drawing.Size(27, 27);
            this.ptbRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbRemove.TabIndex = 11;
            this.ptbRemove.TabStop = false;
            this.ptbRemove.Click += new System.EventHandler(this.ptbRemove_Click);
            this.ptbRemove.MouseHover += new System.EventHandler(this.ptbRemove_MouseHover);
            // 
            // dgvListProduct
            // 
            this.dgvListProduct.AllowUserToAddRows = false;
            this.dgvListProduct.AllowUserToDeleteRows = false;
            this.dgvListProduct.AllowUserToResizeColumns = false;
            this.dgvListProduct.AllowUserToResizeRows = false;
            this.dgvListProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListProduct.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListProduct.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvListProduct.Location = new System.Drawing.Point(0, 41);
            this.dgvListProduct.Margin = new System.Windows.Forms.Padding(10);
            this.dgvListProduct.Name = "dgvListProduct";
            this.dgvListProduct.ReadOnly = true;
            this.dgvListProduct.RowHeadersVisible = false;
            this.dgvListProduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListProduct.Size = new System.Drawing.Size(972, 290);
            this.dgvListProduct.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.tbKhachHang);
            this.panel4.Controls.Add(this.tbSoDienThoai);
            this.panel4.Controls.Add(this.tbTotal);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.tbTienGui);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.tbTienTra);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(972, 136);
            this.panel4.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.dgvListProduct);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(10, 146);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(972, 331);
            this.panel5.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label3.Size = new System.Drawing.Size(217, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sản phẩm trong đơn hàng";
            // 
            // BanHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 547);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.Name = "BanHangForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.BanHangForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTienGui;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTienTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKhachHang;
        private System.Windows.Forms.TextBox tbSoDienThoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox ptbRemove;
        private System.Windows.Forms.PictureBox ptbAdd;
        private System.Windows.Forms.TextBox tbMaSanPham;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbExport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvListProduct;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudQuantity;

    }
}