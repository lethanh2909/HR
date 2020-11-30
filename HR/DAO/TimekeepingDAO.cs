using HR.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAO
{
    public class TimekeepingDAO
    {
        private static TimekeepingDAO instance;

        public static TimekeepingDAO Instance
        {
            get { if (instance == null) instance = new TimekeepingDAO(); return instance; }
            private set { instance = value; }
        }

        private TimekeepingDAO() { }

        public DataTable GetTableTimekeeping()
        {
            string query = "exec USP_LoadTimekeeping";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            return data;
        }

        public List<Timekeeping> GetListTimekeeping()
        {
            List<Timekeeping> list = new List<Timekeeping>();

            string query = "exec USP_LoadTimekeeping";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Timekeeping timekeeping = new Timekeeping(item);
                list.Add(timekeeping);
            }

            return list;
        }

        public List<Timekeeping> GetListTimekeepingByDate(string Datefrom, string Dateto)
        {
            List<Timekeeping> list = new List<Timekeeping>();

            string query = string.Format("exec USP_FilteredTimekeepingByDate '{0}' , '{1}'", Datefrom, Dateto);

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Timekeeping timekeeping = new Timekeeping(item);
                list.Add(timekeeping);
            }

            return list;
        }

        public DataTable FilteredTimekeepingByDate(string Datefrom, string Dateto)
        {           
            string query = string.Format("exec USP_FilteredTimekeepingByDate '{0}' , '{1}'", Datefrom, Dateto);
            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            return data;
        }

        public bool UpdateTimekeeping(int TKid, string clockIn, string ClockOut, string Absence)
        {
            string query = string.Format("UPDATE dbo.Timekeeping SET clockIn = {1}, ClockOut = {2}, AbsenceTypes = {3} WHERE TKid = N'{0}'", TKid, clockIn, ClockOut, Absence);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool SetSunday(string Status, string Workday)
        {
            string query = string.Format("UPDATE dbo.Timekeeping SET Status = '{0}' WHERE Workday = N'{1}'", Status, Workday);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
