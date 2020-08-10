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
    public partial class frmPhongBan : Form
    {
        Class1 qlns = new Class1(); 
        public frmPhongBan()
        {
            InitializeComponent();
        }

        public void LoadDSPhongBan()
        {
            dataPhongBan.DataSource = qlns.loas_PhongBan();
        }
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            txtMaPB.Enabled = false;
            txtTENPH.Enabled = false;
            txtSONHANVIEN.Enabled = false;
            LoadDSPhongBan();
        }
       

        private void dataNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void dataPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaPB.Text = dataPhongBan.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTENPH.Text = dataPhongBan.Rows[e.RowIndex].Cells[1].Value.ToString();

                dataNhanVien.DataSource = qlns.loas_PhongBan_DSNhanVien(dataPhongBan.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch
            {
            }
        }

        private void itemThemMoi_Click(object sender, EventArgs e)
        {
            txtMaPB.Enabled = true;
            txtTENPH.Enabled = true;
            txtSONHANVIEN.Enabled = true;
        }

        private void itemXoa_Click(object sender, EventArgs e)
        {
            string id = txtMaPB.Text;
             qlns.delete_PhongBan(id);
             frmPhongBan_Load(sender, e);
        }

        private void itemLuu_Click(object sender, EventArgs e)
        {
            qlns.insert_PhongBan(txtMaPB.Text, txtTENPH.Text);
            frmPhongBan_Load(sender, e);
        }
    }
}
