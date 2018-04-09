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
        //chỉnh sửa, thêm, xóa, tìm kiếm hóa đơn thuê phòng
        public object get_Hdtt()
        {
            var hddt = from a in data.HDThanhToans select a;
            return hddt;
        }
        public int add_Hdtt(string ma1, string ma2, string ma3, string ngay, string tien, string ma4)
        {
            HDThanhToan tt = new HDThanhToan();
            tt.MaHDTT = ma1;
            tt.MaPhong = ma2;
            tt.MaKHTT = ma3;
            tt.NgayThanhToan = Convert.ToDateTime(ngay);
            tt.TongTienThanhToan = Convert.ToInt32(tien);
            tt.MaNV = ma4;
            data.HDThanhToans.InsertOnSubmit(tt);
            data.SubmitChanges();
            return 1;
        }
        public object edit_Hdtt(string ma1, string ma2, string ma3, string ngay, string tien, string ma4)
        {
            var hdtt = data.HDThanhToans.Single(a => a.MaHDTT == ma1);
            hdtt.MaPhong = ma2;
            hdtt.MaKHTT = ma3;
            hdtt.NgayThanhToan = Convert.ToDateTime(ngay);
            hdtt.TongTienThanhToan = Convert.ToInt32(tien);
            hdtt.MaNV = ma4;
            data.SubmitChanges();
            return 1;
        }
        public object delete_Hdtt(string ma1)
        {
            var hdtt = data.HDThanhToans.Single(a => a.MaHDTT == ma1);
            data.HDThanhToans.DeleteOnSubmit(hdtt);
            data.SubmitChanges();
            return 1;
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
        //Chỉnh sửa thêm,sửa,xóa dịch vụ
        public object getalldv()
        {
            return data.DichVus;
        }
        public bool add_dv(string id,string name,int amount)
        {
            if(data.DichVus.Single(p=> p.MaDV == id) == null)
            {
                DichVu dv = new DichVu();
                dv.MaDV = id;
                dv.TenDV = name;
                dv.GiaDV = amount;
                dv.MaNQL = null;
                data.DichVus.InsertOnSubmit(dv);
                data.SubmitChanges();
                return true;
            }else
            {
                return false;
            }
            
        }
        public bool edit_dv(string ma,string name, int amount)
        {
            DichVu dv = data.DichVus.Single(p => p.MaDV == ma);
            dv.TenDV = name;
            dv.GiaDV = amount;
            data.SubmitChanges();
            return true;
        }
        public bool del_dv(string id)
        {
            DichVu dv = data.DichVus.Single(p => p.MaDV == id);
            data.DichVus.DeleteOnSubmit(dv);
            data.SubmitChanges();
            return true;
        }

    }
}
