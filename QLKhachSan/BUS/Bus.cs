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
        //chỉnh sửa, thêm, xóa, tìm kiếm hóa đơn thanh toán
        public object get_Hdtt()
        {
            var hddt = from a in data.HDThanhToans
                       select new
                       {
                           MaHDTT = a.MaHDTT,
                           MaPhong = a.MaPhong,
                           MaKHTT = a.MaKHTT,
                           NgayThanhToan = a.NgayThanhToan,
                           TongTienThanhToan = a.TongTienThanhToan,
                           MaNV = a.MaNV
                       };
            return hddt;
        }
        public int add_Hdtt(string ma1, string ma2, string ma3, string ngay, string tien, string ma4)
        {
            int so1 = (from p in data.HDThanhToans where p.MaHDTT == ma1 select p).Count();
            int so2 = (from p in data.HDThuePhongs where p.MaPhong == ma2 select p).Count();
            int so3 = (from p in data.HDThuePhongs where p.MaKHThue == ma3 select p).Count();
            int so4 = (from p in data.NhanViens where p.MaNV == ma4 select p).Count();
            if (so1 == 0 && so2 == 1 && so3 == 1 && so4 == 1)
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
            else
            {
                return 0;
            }
        }
        public int edit_Hdtt(string ma1, string ma2, string ma3, string ngay, string tien, string ma4)
        {
            int so1 = (from p in data.HDThanhToans where p.MaHDTT == ma1 select p).Count();
            int so2 = (from p in data.HDThuePhongs where p.MaPhong == ma2 select p).Count();
            int so3 = (from p in data.HDThuePhongs where p.MaKHThue == ma3 select p).Count();
            int so4 = (from p in data.NhanViens where p.MaNV == ma4 select p).Count();
            if (so1 == 1 && so2 == 1 && so3 == 1 && so4 == 1)
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
            else
            {
                return 0;
            }
        }
        public object delete_Hdtt(string ma1)
        {
            var hdtt = data.HDThanhToans.Single(a => a.MaHDTT == ma1);
            data.HDThanhToans.DeleteOnSubmit(hdtt);
            data.SubmitChanges();
            return 1;
        }
        public object search_Hdtt(string giatri)
        {
            var hddt = from a in data.HDThanhToans
                       select new
                       {
                           MaHDTT = a.MaHDTT,
                           MaPhong = a.MaPhong,
                           MaKHTT = a.MaKHTT,
                           NgayThanhToan = a.NgayThanhToan,
                           TongTienThanhToan = a.TongTienThanhToan,
                           MaNV = a.MaNV
                       } into hd where hd.MaHDTT.Contains(giatri) || hd.MaPhong.Contains(giatri) || hd.MaKHTT.Contains(giatri) || hd.NgayThanhToan.ToString().Contains(giatri) ||
                         hd.TongTienThanhToan.ToString().Contains(giatri) || hd.MaNV.Contains(giatri)
                         select hd;
            return hddt;
        }
        //chỉnh sửa, thêm, xóa, tìm kiếm hóa đơn thuê phòng
        public object get_suaHdtp()
        {
            var hdtp = from b in data.HDThuePhongs
                       from a in data.KhachHangs
                       from c in data.ChiTietThuePhongs
                       from d in data.Phongs
                       where b.MaKHThue == a.MaKH
                       where b.MaPhong == c.MaPhong
                       where d.SoPhong == c.SoPhong
                       select new
                       {
                           MaPhong = b.MaPhong,
                           SoPhong = d.SoPhong,
                           TenKHThue = a.TenKH,
                           NgayThue = b.NgayThue,
                           NgayTra = b.NgayTra,
                           ThoiGianThue = b.ThoiGianThue,
                           TienPhong = b.TienPhong,
                           MaNV = b.MaNV
                       };
            return hdtp;

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
        //Chỉnh sửa hddv
        public object getDataHDDV()
        {
            var tk = from u in data.HDDichVus
                     from v in data.KhachHangs
                     from t in data.ChiTietDVs
                     from z in data.DichVus
                     where u.MaKH == v.MaKH && u.MaHD == t.MaHD && t.MaDV == z.MaDV
                     select new
                     {
                         MaHD = u.MaHD,
                         HoTen = v.TenKH,
                         TenDV = z.TenDV,
                         NgayLap = u.NgayLapHD,
                         SoLuongDV = t.SoLuongDV,
                         ThanhTien = t.ThanhTien

                     };
            return tk;
        }
        public object TimKiem_Hddv(string HoTen)
        {
            var tk = from u in data.HDDichVus
                     from v in data.KhachHangs
                     where u.MaKH == v.MaKH
                     select new
                     {
                         MaHD = u.MaHD,
                         MaKH = u.MaKH,
                         HoTen = v.TenKH,
                         NgayLap = u.NgayLapHD,
                         TongTien = u.TongTien

                     } into timkiemHddv
                     where timkiemHddv.HoTen.Contains(HoTen)

                     select timkiemHddv;
            return tk;

        }
        public int EditHddv(string mahd, string madv, string soluong)
        {
            var chitiet = data.ChiTietDVs.Single(a => a.MaHD == mahd && a.MaDV == madv);
            var hoadon = data.HDDichVus.Single(b => b.MaHD == mahd);
            var dichvu = data.DichVus.Single(c => c.MaDV == madv);
            
            chitiet.SoLuongDV = Convert.ToInt32 (soluong);
            int bandau = Convert.ToInt32(chitiet.ThanhTien);
            chitiet.ThanhTien = Convert.ToInt32(soluong) * dichvu.GiaDV;
            hoadon.TongTien = hoadon.TongTien + (chitiet.ThanhTien - bandau);

            data.SubmitChanges();
            return 1;
        }
        public int delHddv(string mahd, string madv)
        {
            var chitiet = data.ChiTietDVs.Single(a => a.MaHD == mahd && a.MaDV == madv);
            var hoadon = data.HDDichVus.Single(b => b.MaHD == mahd);

            int chenhlech = Convert.ToInt32(chitiet.ThanhTien);
            data.ChiTietDVs.DeleteOnSubmit(chitiet);
            hoadon.TongTien = hoadon.TongTien - chenhlech;
            data.SubmitChanges();
            return 1;
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

        public int EditHdtp(string ma,string sp,string ngayden,string ngaytra,string thoigianthue)
        {
            var hdtp = data.HDThuePhongs.Single(p => p.MaPhong == ma);
            var cttp = data.ChiTietThuePhongs.Single(p => p.MaPhong == ma);
            var phong = data.Phongs.Single(p => p.SoPhong == sp);
            cttp.SoPhong = phong.SoPhong;
            hdtp.NgayThue = Convert.ToDateTime(ngayden);
            hdtp.NgayTra = Convert.ToDateTime(ngaytra);
            hdtp.ThoiGianThue = Convert.ToInt32(thoigianthue);
            hdtp.TienPhong = phong.GiaPhong * Convert.ToInt32(thoigianthue);
            data.SubmitChanges();
            return 1;
        }

        public int delHdtp(string ma)
        {
            var hdtp = data.HDThuePhongs.Single(p => p.MaPhong == ma);
            var tp = data.ThuePhongs.OrderBy(p => p.MaPhong == ma);
            var cttp = data.ChiTietThuePhongs.Single(p => p.MaPhong == ma);
            var hdtt = data.HDThanhToans.Single(p => p.MaPhong == ma);
            data.HDThanhToans.DeleteOnSubmit(hdtt);
            data.HDThuePhongs.DeleteOnSubmit(hdtp);
            data.ChiTietThuePhongs.DeleteOnSubmit(cttp);
            data.ThuePhongs.DeleteAllOnSubmit(tp);
            data.SubmitChanges();
            return 1;
        }

    }
}


