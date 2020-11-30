using HR.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAO
{
    public class OvertimeDAO
    {
        private static OvertimeDAO instance;

        public static OvertimeDAO Instance
        {
            get { if (instance == null) instance = new OvertimeDAO(); return OvertimeDAO.instance; }
            private set { OvertimeDAO.instance = value; }
        }

        private OvertimeDAO() { }


        public bool LoadOvertime(string Datefrom, string Dateto)
        {
            string query = string.Format("exec USP_LoadOvertime '{0}' , '{1}'", Datefrom, Dateto);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public DataTable FilteredOvertime(string Datefrom, string Dateto)
        {
            string query = string.Format("exec USP_FilteredOvertime '{0}' , '{1}'", Datefrom, Dateto);
            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            return data;
        }

        public List<Overtime> GetListOvertime()
        {
            List<Overtime> list = new List<Overtime>();

            string query = "select * from Overtime";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Overtime ea = new Overtime(item);
                list.Add(ea);
            }

            return list;
        }

        public DataTable GetTableOvertime()
        {
            string query = "select * from Overtime";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            return data;
        }

        public Overtime CheckNullOvertime()
        {
            Overtime el = null;

            string query = "select * from Overtime";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                el = new Overtime(item);
                return el;
            }

            return el;
        }

        public bool DeleteOvertime(string Datefrom, string Dateto)
        {
            string query = string.Format("exec USP_DeleteOvertime '{0}' , '{1}'", Datefrom, Dateto);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public void InsertOvertime(string EmpId, string Fullname, string ShiftName, string Workday, string OvertimeFrom, string OvertimeTo, int OvertimeHours)
        {
            string query = string.Format("INSERT dbo.Overtime ( EmpId, FullName, ShiftName, Workday, OvertimeFrom, OvertimeTo, OvertimeHours ) VALUES  ( N'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6})", EmpId, Fullname, ShiftName, Workday, OvertimeFrom, OvertimeTo, OvertimeHours);
            Dataprovider.Instance.ExecuteNonQuery(query);
        }

        public bool ConfirmOvertime(string type, int value, int OvertimeHours, int confirm, int id)
        {
            string query = string.Format("UPDATE dbo.Overtime SET OvertimeType = '{0}', OvertimeValue = {1}, OvertimeHours = {2}, ConfirmedHours = {3} WHERE OTid = {4}", type, value, OvertimeHours, confirm, id);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
