using DoAnWin.NormalClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnWin.PropertyClass;
using System.Windows.Forms;

namespace DoAnWin.DAOClass
{
    public class JobDAO
    {
        
        public static string CreateWorkID()
        {
            Modify modify = new Modify();
            string id = (300000 + Person.random.Next(1, 101)).ToString();
            while (modify.Accounts("Select * from Job where MaCV = '" + id + "'").Count != 0)
            {
                long temp = Int32.Parse(id) + 100;
                id = temp.ToString();
            }
            return id;
        }
        public void HireWorker(Job job)
        {
            DBConnection conn = new DBConnection(); 
            string sqlStr = string.Format("INSERT INTO Job(IdNguoiThue , IdNguoiLam, TenNguoiLam, MaCV, MoTaCV, TrangThaiCV, NgayLam, TenNguoiThue, Luong) VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}')", job.IdUser, job.IdWorker, job.NameWorker, job.IdWork, job.DescribeWork, job.StatusWork, job.DayWork, job.NameUser, job.Salary);
            
            conn.ThucThi(sqlStr);
        }
        public List<string> CreateListBusyDay(string id)
        {
            string query = string.Format("Select IDNguoiLam, NgayLam, TrangThaiCV from Job where IDNguoiLam = N'{0}' and TrangThaiCV = N'{1}'", id, "Đang làm");
            Modify modify = new Modify();
            List<Job> BusyDayList = modify.BusyDay(query);
            //string[] BusyDays = new string[BusyDayList.Count];
            List<string> days = new List<string>();
            //int count = 0;
            foreach (Job busyDay in BusyDayList)
            {
                days.Add(busyDay.DayWork);
                //count++;
            }
            return days;
        }

        public List<Job> LoadListJob(string id)
        {
            DBConnection connect = new DBConnection();
            string query = string.Format("Select distinct IDNguoiThue, NguoiDung.Ten, IDNguoiLam, MaCV, MoTaCV, TrangThaiCV " +
                "from Job, NguoiDung " +
                "where Job.IDNguoiThue = NguoiDung.ID and Job.IDNguoiLam = N'{0}' and Job.TrangThaiCV = N'{1}'", id, "Chờ xác nhận");
            
            return connect.LoadListJob(query);
        }
        public List<Job> LoadListWorkingDay(string idWork)
        {
            DBConnection connect = new DBConnection();
            string query = string.Format("Select MaCV, NgayLam from Job where MaCV = N'{0}'", idWork);

            return connect.LoadListWorkingDay(query);
        }

        public void UpdateBusyDay(string idWork)
        {
            DBConnection connect = new DBConnection();
            string query = string.Format("UPDATE Job SET TrangThaiCV = N'{0}' WHERE MaCV = N'{1}'",
            "Đang làm", idWork);
            connect.ThucThi(query);
        }

        public void UpdateRefuse(string idWork)
        {
            DBConnection connect = new DBConnection();
            string query = string.Format("UPDATE Job SET TrangThaiCV = N'{0}' WHERE MaCV = N'{1}'",
            "Bị hủy", idWork);
            connect.ThucThi(query);
        }

        public List<Job> LoadWorkWorking()
        {
            DBConnection connect = new DBConnection();
            string query = string.Format("select distinct idNguoiThue, idNguoiLam, TenNguoiLam, TrangThaiCV, MoTaCV, MaCV " +
            "from Job " +
            "where IDNguoiThue = N'{0}'", StaticPropertyAndField.IncomeID);
            return connect.LoadWorkWorking(query);
        }

        public List<Job> LoadWorkWorkingInWorker()
        {
            DBConnection connect = new DBConnection();
            string query = string.Format("select distinct idNguoiThue, TenNguoiThue, idNguoiLam, TenNguoiLam, TrangThaiCV, MoTaCV, MaCV "+
            "from Job "+
            "where IDNguoiLam = N'{0}' and (TrangThaiCV = N'Đang làm' or TrangThaiCV = N'Hoàn thành' or TrangThaiCV = N'Bị hủy' or TrangThaiCV = N'Chờ hoàn thành' )", StaticPropertyAndField.IncomeID);
            return connect.LoadWorkWorkingInWorker(query);
        }

        public int TotalSalary(string idWork)
        {
            DBConnection connect = new DBConnection();
            string query = string.Format("select sum(Luong) as TongLuong " +
            "from Job " +
            "where MaCV = N'{0}'", idWork);
            return connect.TotalSalary(query);
        }

        public void UpdateWaitingWorkFinish(string idWork)
        {
            DBConnection connect = new DBConnection();
            string query = string.Format("UPDATE Job SET TrangThaiCV = N'{0}' WHERE MaCV = N'{1}'",
            "Chờ hoàn thành", idWork);
            connect.ThucThi(query);
        }

        public void UpdateFinished(string idWork)
        {
            DBConnection connect = new DBConnection();
            string query = string.Format("UPDATE Job SET TrangThaiCV = N'{0}' WHERE MaCV = N'{1}'",
            "Hoàn thành", idWork);
            connect.ThucThi(query);
        }

        public List<Job> LoadFinishWork()
        {
            DBConnection connect = new DBConnection();
            string query = string.Format("select distinct idNguoiThue, TenNguoiThue, idNguoiLam, TenNguoiLam, TrangThaiCV, MoTaCV, MaCV " +
            "from Job " +
            "where IDNguoiThue = N'{0}' and (TrangThaiCV = N'Hoàn thành')", StaticPropertyAndField.IncomeID);
            return connect.LoadWorkWorkingInWorker(query);
        }

        public List<Job> LoadFinishWorkInWorker()
        {
            DBConnection connect = new DBConnection();
            string query = string.Format("select distinct idNguoiThue, TenNguoiThue, idNguoiLam, TenNguoiLam, TrangThaiCV, MoTaCV, MaCV " +
            "from Job " +
            "where IDNguoiLam = N'{0}' and (TrangThaiCV = N'Hoàn thành')", StaticPropertyAndField.IncomeID);
            return connect.LoadWorkWorkingInWorker(query);
        }
    }
}
