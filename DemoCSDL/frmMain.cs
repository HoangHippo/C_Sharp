using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCSDL
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //frmLogin frm = new frmLogin();
            //DialogResult rs = frm.ShowDialog();
            //if (rs != DialogResult.OK)
            //{
            //    Application.Exit();
            //}
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPham frm = new frmSanPham();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sảnphẩmDataSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSanPhamDataSet frm = new frmSanPhamDataSet();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
