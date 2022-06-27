
namespace OnTapKT
{
    partial class frmMain
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
            this.btnQuanLiSanPham = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuanLiSanPham
            // 
            this.btnQuanLiSanPham.Location = new System.Drawing.Point(337, 196);
            this.btnQuanLiSanPham.Name = "btnQuanLiSanPham";
            this.btnQuanLiSanPham.Size = new System.Drawing.Size(147, 23);
            this.btnQuanLiSanPham.TabIndex = 0;
            this.btnQuanLiSanPham.Text = "Quản Lí Sản Phẩm";
            this.btnQuanLiSanPham.UseVisualStyleBackColor = true;
            this.btnQuanLiSanPham.Click += new System.EventHandler(this.btnQuanLiSanPham_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.btnQuanLiSanPham);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuanLiSanPham;
    }
}

