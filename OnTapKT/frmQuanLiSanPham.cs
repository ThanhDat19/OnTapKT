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
    public partial class frmQuanLiSanPham : Form
    {
        ConnectionData connection = new ConnectionData();
        public frmQuanLiSanPham()
        {
            InitializeComponent();
        }

        private void frmQuanLiSanPham_Load(object sender, EventArgs e)
        {
            loadDataGridViewSanPham();
        }
        public void loadDataGridViewSanPham()
        {
            dgvSanPham.DataSource = connection.CreateDataTable("SELECT MASP, TEN, SOLUONG, DONGIA, MOTA, GHICHU FROM SANPHAM WHERE XOA = 0 ");
        }

        private void dgvSanPham_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];
                if(e.ColumnIndex == 0)
                {
                    ClearField();
                    string Delete = string.Format("UPDATE SANPHAM SET XOA = 1 WHERE MASP ={0} ", row.Cells["MASP"].Value.ToString());
                    connection.excuteNonQuery(Delete);
                    loadDataGridViewSanPham();
                }
                if(e.ColumnIndex != 0 && e.ColumnIndex != 1)
                {
                    txtTenSanPham.Text = row.Cells["TEN"].Value.ToString();
                    txtDonGia.Text = row.Cells["DONGIA"].Value.ToString();
                    txtMoTa.Text = row.Cells["MOTA"].Value.ToString();
                    txtGhiChu.Text = row.Cells["GHICHU"].Value.ToString();
                }
                if(e.ColumnIndex == 1)
                {
                    string strTenSanPham = row.Cells["TEN"].Value.ToString();
                    string strMoTa = row.Cells["MOTA"].Value.ToString();
                    string strGhiChu = row.Cells["GHICHU"].Value.ToString();
                    decimal DonGia = decimal.Parse(row.Cells["DONGIA"].Value.ToString());
                    int MaSanPham = int.Parse(row.Cells["MASP"].Value.ToString());

                    frmCapNhatSanPham frmCapNhatSanPham = new frmCapNhatSanPham(MaSanPham, strTenSanPham, DonGia, strMoTa, strGhiChu);
                    frmCapNhatSanPham.ShowDialog();
                    loadDataGridViewSanPham();

                }
            }
            
        }
        public void ClearField()
        {
            txtTenSanPham.Text = "";
            txtDonGia.Text = "";
            txtMoTa.Text = "";
            txtGhiChu.Text = "";
        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            frmThemSanPham frmThemSanPham = new frmThemSanPham();
            frmThemSanPham.ShowDialog();
            loadDataGridViewSanPham();
        }
    }
}
