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
    }
}
