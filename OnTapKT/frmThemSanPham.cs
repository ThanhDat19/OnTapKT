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
    public partial class frmThemSanPham : Form
    {
        public frmThemSanPham()
        {
            InitializeComponent();
        }
        ConnectionData connection = new ConnectionData();
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
                    string query = string.Format("INSERT INTO SANPHAM(TEN,SOLUONG,DONGIA,MOTA,XOA,GHICHU) VALUES(N'{0}', 0, {1}, N'{2}', 0, N'{3}')", strTenSanPham, DonGia, strMoTa, strGhiChu);
                    connection.excuteNonQuery(query);                  
                    MessageBox.Show("Thêm thành công rồi bé ơi!");
                }
                else
                {
                    MessageBox.Show("Không được bỏ trống!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại rồi bé ơi!");
            }
        }
        Rule_Regex rule = new Rule_Regex();

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(rule.Number_Regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Khong duoc nhap ki tu nay!");
                e.Handled = true;
            }
        }

        private void txtMoTa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rule.Describe_Regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Khong duoc nhap ki tu nay!");
                e.Handled = true;
            }
        }
    }
}
