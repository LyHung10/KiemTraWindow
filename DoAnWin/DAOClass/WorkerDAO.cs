using DoAnWin.ChildFormWorker;
using DoAnWin.NormalClass;
using DoAnWin.PropertyClass;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DoAnWin.DAOClass
{
    public class WorkerDAO
    {
        DBConnection connect = new DBConnection();
        FormDAO fd = new FormDAO();
        public DataTable load()
        {
            string sqlStr = string.Format("SELECT *FROM DangViec");
            return connect.Load(sqlStr);
        }
        public bool UpdateInfo(Worker newDangviec)
        {
            //newDangviec = new Worker(newDangviec.Id, newDangviec.Job, newDangviec.WorkingDay, newDangviec.WorkingTime, newDangviec.HireCost, newDangviec.Experience, newDangviec.Describe);

            if (Worker.CheckNullUploadInfo(newDangviec) == true)
            {
                string sqlStr = string.Format("UPDATE Worker SET DangThongTin = N'{0}' WHERE ID = N'{1}'",
                    "1", StaticPropertyAndField.IncomeID);
                connect.ThucThi(sqlStr);
                return true;
                //connect.ThucThi(sqlStr, "Thêm công việc thành công", newDangviec);
            }
            else
            {
                return false;
            }
        }
        public void DeleteWork(Worker newDangviec)
        {
            string sqlStr = string.Format("DELETE FROM DangViec WHERE ID = '{0}' AND NgheNghiep = '{1}'", newDangviec.Id, newDangviec.Job);
            connect.ThucThi(sqlStr);
        }
        public void updateInfo(Worker newInfo)
        {
            string sqlStr = string.Format("UPDATE Worker SET Ten = N'{0}', DiaChi = N'{1}', SDT = N'{2}', Email = N'{3}', " +
                "GioiTinh = N'{4}', NgaySinh = N'{5}', CCCD = N'{6}', TenTaiKhoan = N'{7}', MatKhau = N'{8}', TrangThai = N'{9}' WHERE ID = N'{10}'",
            newInfo.Name, newInfo.Address, newInfo.Phone, newInfo.Email, newInfo.Sex, newInfo.Date, newInfo.Cccd, newInfo.Account, newInfo.Pass, newInfo.Status, StaticPropertyAndField.IncomeID);
            connect.ThucThi(sqlStr);
        }
        public void UpLoadInfoAndJob(Worker newInfo)
        {
            string sqlStr = string.Format("UPDATE Worker SET NgheNghiep = N'{0}', NamKinhNghiem = N'{1}', GiaThue = N'{2}', MoTa = N'{3}' " +
                "WHERE ID = N'{4}'",
                newInfo.Job, newInfo.WorkingTime, newInfo.HireCost, newInfo.Describe, StaticPropertyAndField.IncomeID);
            connect.ThucThi(sqlStr);
        }
        public void UpdateStatus(string ID)
        {
            string sqlStr = string.Format("UPDATE DangViec SET TrangThai = N'{0}' WHERE ID = N'{1}'", "Xác nhận", ID);
            connect.ThucThi(sqlStr);
        }
        public List<Worker> LoadListWorker(Label lblTitle)
        {
            string query = "";
            if (lblTitle.Text != "Thợ khác")
            {
                query = string.Format("select Worker.ID, Worker.Ten, Worker.GioiTinh, Worker.NgaySinh, Worker.DiaChi, Worker.SDT,Worker.Email, Worker.LuotThue, Worker.DanhGiaTrungBinh, Worker.TrangThai, Worker.NamKinhNghiem, Worker.GiaThue, Worker.NgheNghiep, Worker.MoTa, Worker.DangThongTin, Worker.Avatar\r\n" +
                        "from Worker " +
                        "where Worker.TrangThai = N'{0}' and Worker.DangThongTin = N'{1}' and Worker.NgheNghiep = N'{2}'", "Hoạt động", "1", lblTitle.Text);
            }
            else
            {
                query = string.Format("select Worker.ID, Worker.Ten, Worker.GioiTinh, Worker.NgaySinh, Worker.DiaChi, Worker.SDT,Worker.Email, Worker.LuotThue, Worker.DanhGiaTrungBinh, Worker.TrangThai, Worker.NamKinhNghiem, Worker.GiaThue, Worker.NgheNghiep, Worker.MoTa, Worker.DangThongTin, Worker.Avatar\r\n" +
                        "from Worker " +
                        "where Worker.TrangThai = N'{0}' and Worker.DangThongTin = N'{1}' and Worker.NgheNghiep != N'Thợ máy'and Worker.NgheNghiep != N'Thợ sơn'and Worker.NgheNghiep != N'Thợ rửa xe'and Worker.NgheNghiep != N'Thợ điện'and Worker.NgheNghiep != N'Thợ điêu khắc' and Worker.NgheNghiep != N'' ", "Hoạt động", "1");
            }
            return connect.LoadWorkerToUser(query);
        }
        public List<Worker> LoadListWorkerTOP(Label lblTitle)
        {
            string query = ($"SELECT TOP 5 * FROM Worker WHERE NgheNghiep = N'{lblTitle.Text}' ORDER BY TRY_CAST(DanhGiaTrungBinh AS FLOAT) DESC");
            return connect.LoadWorkerToUser(query);
            
        }
        public List<Worker> LoadListWorkerTOPRevenue(Label lblTitle)
        {
            string query = $@"
                        SELECT TOP 3 w.*, j.TongLuong
                        FROM Worker w
                        JOIN (
                            SELECT IDNguoiLam, SUM(Luong) AS TongLuong
                            FROM job
                            GROUP BY IDNguoiLam
                        ) j ON w.ID = j.IDNguoiLam
                        WHERE w.NgheNghiep = N'{lblTitle.Text}'
                        ORDER BY j.TongLuong DESC";

            return connect.LoadWorkerToUser(query);
            
        }
        public List<Worker> LoadListWorkerMinRevenue(Label lblTitle)
        {
            string query = $@"
                        SELECT TOP 3 w.*, j.TongLuong
                        FROM Worker w
                        JOIN (
                            SELECT IDNguoiLam, SUM(Luong) AS TongLuong
                            FROM job
                            GROUP BY IDNguoiLam
                        ) j ON w.ID = j.IDNguoiLam
                        WHERE w.NgheNghiep = N'{lblTitle.Text}'
                        ORDER BY j.TongLuong ASC";

            return connect.LoadWorkerToUser(query);
        }
        public List<Worker> LoadListWorkerTOPBook(Label lblTitle)
        {
            string query = ($"SELECT TOP 5 * FROM Worker WHERE NgheNghiep = N'{lblTitle.Text}' ORDER BY TRY_CAST(LuotThue AS INT) DESC");
            return connect.LoadWorkerToUser(query);

        }
        public Worker IncomeWorker()
        {
            string query = string.Format("select Worker.ID, Worker.Ten, Worker.DiaChi, Worker.SDT, Worker.Email, Worker.GioiTinh,Worker.NgaySinh, Worker.CCCD, Worker.TenTaiKhoan, Worker.MatKhau, Worker.TrangThai, Worker.Avatar\r\n" +
                        "from Worker " +
                        "where Worker.ID = N'{0}'", StaticPropertyAndField.IncomeID);
            return connect.LoadInComeWorker(query);
        }

         public int TakeSalary(string idWorker)
        {
            string query = string.Format("select GiaThue\r\n" +
                        "from Worker " +
                        "where id= N'{0}'", idWorker);
            return connect.TakeSalary(query);
        }
    }
}
