using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LayerData;
namespace QL_NhanSu
{
    public partial class frmDanhSachNhanVien : Form
    {
        public frmDanhSachNhanVien()
        {
            InitializeComponent();
        }
        Class1 qlns = new Class1();
        private void frmDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = qlns.loas_DSNV();
        }

        private void Thoat_toolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDanhSachNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn thoát khỏi hệ thống không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }
    }
}
