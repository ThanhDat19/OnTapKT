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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnQuanLiSanPham_Click(object sender, EventArgs e)
        {
            frmQuanLiSanPham frmQuanLiSanPham = new frmQuanLiSanPham();
            frmQuanLiSanPham.ShowDialog();
        }
    }
}
