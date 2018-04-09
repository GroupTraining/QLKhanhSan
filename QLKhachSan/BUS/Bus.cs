using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class Bus
    {
        DataDiagramDataContext data = new DataDiagramDataContext();

        public object get_Hdtt()
        {
            var hddt = from a in data.HDThanhToans select a;
            return hddt;
        }

        public  object get_Hdtp()
        {
            var hdtp = from b in data.HDThuePhongs 
                       select new
                       {
                           MaPhong=b.MaPhong,
                           MaKHThue=b.MaKHThue,
                           NgayThue=b.NgayThue,
                           NgayTra=b.NgayTra,
                           ThoiGianThue=b.ThoiGianThue,
                           TienPhong=b.TienPhong,
                           MaNV=b.MaNV
                       };
            return hdtp;
                   
        }
        public object TimKiem_Hdtp(string GiaTri)
        {
            var tk = from u in data.HDThuePhongs
                     select new
                     {
                         MaPhong = u.MaPhong,
                         MaKHThue =u.MaKHThue,
                        NgayThue=u.NgayThue,
                        NgayTra=u.NgayTra,
                       ThoiGianThue=u.ThoiGianThue,
                       TienPhong=u.TienPhong,
                       MaNV=u.MaNV

                     } into timkiemHdtp
                     where timkiemHdtp.MaPhong.Contains(GiaTri)
                         || timkiemHdtp.MaKHThue.Contains(GiaTri)                        
                           || timkiemHdtp.MaNV.Contains(GiaTri)

                     select timkiemHdtp;
            return tk;

        }

        //chỉnh sửa, thêm, sửa, xóa phòng
        public object get_phong()
        {
            var p = from pa in data.Phongs
                    select new
                    {
                        pa.SoPhong,
                        pa.LoaiPhong,
                        pa.GiaPhong,
                        pa.TinhTrangPhong
                    };
            return p;
        }
        public object them_phong(string sp, string lp, string g, string ttp)
        {
            Phong p = new Phong();
            p.SoPhong = sp;
            p.LoaiPhong = lp;
            p.GiaPhong = Convert.ToInt32(g);
            p.TinhTrangPhong = ttp;
            data.Phongs.InsertOnSubmit(p);
            data.SubmitChanges();
            return 1;
        }
        public object sua_phong(string sp, string lp, string g, string ttp)
        {
            var p = data.Phongs.Single(a => a.SoPhong == sp);
            p.SoPhong = sp;
            p.LoaiPhong = lp;
            p.GiaPhong = Convert.ToInt32(g);
            p.TinhTrangPhong = ttp;
            data.SubmitChanges();
            return 1;
        }
        public object xoa_phong(string sp)
        {
            var p = data.Phongs.Single(a => a.SoPhong == sp);         
            data.Phongs.DeleteOnSubmit(p);          
            data.SubmitChanges();
            return 1;

        }
    }
}
