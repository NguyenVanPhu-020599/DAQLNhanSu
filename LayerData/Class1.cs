using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayerData;
namespace LayerData
{
    public class Class1
    {
        QLNSDataContext qlns = new QLNSDataContext();
        public IQueryable loas_DSNV()
        {
            var ds = (from dn in qlns.NHANVIENs 
                      join db in qlns.PHONGBANs  on dn.ID_PHONGBAN equals db.ID_PHONGBAN
                      select  new {dn.ID_NHANVIEN,dn.NHAN_VIEN,dn.NGAY_SINH,dn.GIOI_TINH,db.PHONG_BAN});
            return ds;
        }
        public IQueryable loas_PhongBan()
        {
            var ds = from dn in qlns.PHONGBANs
                      select dn;
            return ds;
        }
        public IQueryable loas_PhongBan_DSNhanVien( string mapb)
        {
           var ds = (from dn in qlns.NHANVIENs 
                      join db in qlns.PHONGBANs  on dn.ID_PHONGBAN equals db.ID_PHONGBAN
                      where dn.ID_PHONGBAN == mapb
                      select  new {dn.ID_NHANVIEN,dn.NHAN_VIEN,dn.NGAY_SINH,dn.GIOI_TINH});
            return ds; 
        }
        public void insert_PhongBan( string id , string phongban)
        {
            PHONGBAN pb = new PHONGBAN();
            pb.ID_PHONGBAN = id;
            pb.PHONG_BAN = phongban;
            qlns.PHONGBANs.InsertOnSubmit(pb);
            qlns.SubmitChanges();
        }
        public void delete_PhongBan(string id)
        {
            var xoa = (from d in qlns.PHONGBANs where d.ID_PHONGBAN == id select d).FirstOrDefault();
            qlns.PHONGBANs.DeleteOnSubmit(xoa);
            qlns.SubmitChanges();
        }
        
    }
}
