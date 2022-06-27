
namespace OnTapKT
{
    partial class frmThemSanPham
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
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.Location = new System.Drawing.Point(343, 414);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(149, 58);
            this.btnXoaTatCa.TabIndex = 28;
            this.btnXoaTatCa.Text = "Xóa Tất Cả";
            this.btnXoaTatCa.UseVisualStyleBackColor = true;
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(186, 414);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(149, 58);
            this.btnXacNhan.TabIndex = 27;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(186, 272);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(306, 64);
            this.txtGhiChu.TabIndex = 26;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(186, 177);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(306, 64);
            this.txtMoTa.TabIndex = 25;
            this.txtMoTa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMoTa_KeyPress);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(186, 96);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(306, 36);
            this.txtDonGia.TabIndex = 24;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(186, 37);
            this.txtTenSanPham.Multiline = true;
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(306, 36);
            this.txtTenSanPham.TabIndex = 23;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(35, 296);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(63, 17);
            this.lblGhiChu.TabIndex = 22;
            this.lblGhiChu.Text = "Ghi Chú:";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(35, 196);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(52, 17);
            this.lblMoTa.TabIndex = 21;
            this.lblMoTa.Text = "Mô Tả:";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(35, 115);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(64, 17);
            this.lblDonGia.TabIndex = 20;
            this.lblDonGia.Text = "Đơn Giá:";
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Location = new System.Drawing.Point(35, 51);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(106, 17);
            this.lblTenSanPham.TabIndex = 19;
            this.lblTenSanPham.Text = "Tên Sản Phẩm:";
            // 
            // frmThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 627);
            this.Controls.Add(this.btnXoaTatCa);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblTenSanPham);
            this.Name = "frmThemSanPham";
            this.Text = "frmThemSanPham";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaTatCa;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblTenSanPham;
    }
}