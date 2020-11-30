using HR.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAO
{
    public class ShiftScheduleDAO
    {
        private static ShiftScheduleDAO instance;

        public static ShiftScheduleDAO Instance
        {
            get { if (instance == null) instance = new ShiftScheduleDAO(); return instance; }
            private set { instance = value; }
        }

        private ShiftScheduleDAO() { }

        public DataTable GetTableSchedule(int id)
        {
            string query = "select * from ShiftSchedule where ShiftId = " + id;

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable GetTableScheduleByDateName(string sday, string sname )
        {
            string query = string.Format("select * from ShiftSchedule where Days = N'{0}' and ShiftName = '{1}'", sday, sname);

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            return data;
        }

        public ShiftSchedule CheckWorkShift(int id)
        {
            ShiftSchedule Shift = null;

            string query = "select * from ShiftSchedule where ShiftId = " + id;

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Shift = new ShiftSchedule(item);
                return Shift;
            }

            return Shift;
        }

        public bool InsertSchedule(string Days, string OTBeforeFrom, string OTBeforeTo, string ClockIn, string ClockOut, string StartBreak, string EndBreak, string OTAfterFrom, string OTAfterTo, int ShiftId, string ShiftName)
        { 
            string query = string.Format("INSERT dbo.ShiftSchedule ( Days, OTBeforeFrom, OTBeforeTo, ClockIn, ClockOut, StartBreak, EndBreak, OTAfterFrom, OTAfterTo, ShiftId, ShiftName ) VALUES  ( N'{0}', '{1}' , '{2}' , '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', {9}, '{10}' )", Days, OTBeforeFrom, OTBeforeTo, ClockIn, ClockOut, StartBreak, EndBreak, OTAfterFrom, OTAfterTo, ShiftId, ShiftName);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateSchedule(string Days, string OTBeforeFrom, string OTBeforeTo, string ClockIn, string ClockOut, string StartBreak, string EndBreak, string OTAfterFrom, string OTAfterTo, int ShiftId, string ShiftName)
        {
            string query = string.Format("UPDATE dbo.ShiftSchedule SET Days = N'{0}', OTBeforeFrom = '{1}', OTBeforeTo = '{2}', ClockIn = '{3}', ClockOut = '{4}', StartBreak = '{5}', EndBreak = '{6}', OTAfterFrom = '{7}', OTAfterTo = '{8}' WHERE ShiftId = {9}", Days, OTBeforeFrom, OTBeforeTo, ClockIn, ClockOut, StartBreak, EndBreak, OTAfterFrom, OTAfterTo, ShiftId, ShiftName);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteSchedule(int Id)
        {
            string query = string.Format("Delete dbo.ShiftSchedule WHERE ShiftId = {0}", Id);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
