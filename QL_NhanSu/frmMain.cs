using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhanSu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void buttonItemMenuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có muốn thoát khỏi hệ thống không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.No)
                e.Cancel = true;
        }



        private void colorPickerDropDown1_SelectedColorChanged(object sender, EventArgs e)
        {

        }
        private Form kiemtratontai(Type type)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == type)
                {
                    return f;
                }
            }
            return null;
        }
        private void buttonItemTopHoSoNhanVien_Click(object sender, EventArgs e)
        {
            Form frm = kiemtratontai(typeof(Form2));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                Form2 frmn = new Form2();
                frmn.MdiParent = this;
                frmn.Show();
            }
        }

        private void buttonItemTopDanhSachPhongBan_Click(object sender, EventArgs e)
        {

            Form frm = kiemtratontai(typeof(frmPhongBan));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmPhongBan frmn = new frmPhongBan();
                frmn.MdiParent = this;
                frmn.Show();
            }
        }





    }
}
