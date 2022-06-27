using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapKT
{
    public partial class frmCapNhatSanPham : Form
    {
        ConnectionData connection = new ConnectionData();
        public frmCapNhatSanPham()
        {
            InitializeComponent();
        }
        string tenSP, moTA, ghiCHU;
        int maSP;
        decimal donGIA;
        public frmCapNhatSanPham(int MaSanPham, string strTenSP, decimal DonGia, string strMoTa, string strGhiChu)
        {
            InitializeComponent();
            tenSP = strTenSP;
            moTA = strMoTa;
            ghiCHU = strGhiChu;
            maSP = MaSanPham;
            donGIA = DonGia;

        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            txtTenSanPham.Text = "";
            txtDonGia.Text = "";
            txtMoTa.Text = "";
            txtGhiChu.Text = "";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenSanPham.Text != "" || txtMoTa.Text != "" || txtGhiChu.Text != "" || txtDonGia.Text != "")
                {
                    string strTenSanPham = txtTenSanPham.Text;
                    decimal DonGia = decimal.Parse(txtDonGia.Text);
                    string strMoTa = txtMoTa.Text;
                    string strGhiChu = txtGhiChu.Text;
                    object[] parameter = new object[] { maSP, strTenSanPham, strMoTa, strGhiChu, DonGia };
                    //@id int, @name nvarchar(255), @mota nvarchar(500), @ghichu nvarchar(500), @dongia money
                    connection.excuteNonQueryStoreProcedure("EXEC updateSanPham @id , @name , @mota , @ghichu , @dongia ", parameter);
                    MessageBox.Show("Cập nhật thành công rồi bé ơi!");
                }
                else
                {
                    MessageBox.Show("Không được bỏ trống!");
                }
            }catch(Exception)
            {
                MessageBox.Show("Cập nhật thất bại rồi bé ơi!");
            }
            
        }

       

        private void frmCapNhatSanPham_Load(object sender, EventArgs e)
        {
            txtTenSanPham.Text = tenSP;
            txtDonGia.Text = donGIA.ToString();
            txtMoTa.Text = moTA;
            txtGhiChu.Text = ghiCHU;
        }
    }
}
