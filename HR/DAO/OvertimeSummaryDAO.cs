using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR.DTO;

namespace HR.DAO
{
    public class OvertimeSummaryDAO
    {
        private static OvertimeSummaryDAO instance;

        public static OvertimeSummaryDAO Instance
        {
            get { if (instance == null) instance = new OvertimeSummaryDAO(); return instance; }
            private set { instance = value; }
        }

        private OvertimeSummaryDAO() { }

        public object CountOT(string type)
        {
            string query = string.Format("exec USP_CountOT '{0}' ", type);

            object result = Dataprovider.Instance.ExecuteScalar(query);

            return result;
        }

        public List<OvertimeSummary> GetListOTSummary(string empid, int month, int year)
        {
            List<OvertimeSummary> list = new List<OvertimeSummary>();

            string query = string.Format("exec USP_LoadOTSummary '{0}', '{1}', '{2}'", empid, month, year);

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                OvertimeSummary ot = new OvertimeSummary(item);
                list.Add(ot);
            }

            return list;
        }

        public void InsertOTSummary(string Empid, string FirstName, string LastName, string OvertimeType, int OvertimeHours, int BaseSalary, int amount, int Month, int Year)
        {
            string query = string.Format("INSERT dbo.OvertimeSummary (EmpId, FirstName, LastName, OvertimeType, OvertimeHours, BaseSalary, amount, Month, Year) VALUES  ( N'{0}', '{1}', '{2}', '{3}', {4}, {5}, {6}, {7}, {8})", Empid, FirstName, LastName, OvertimeType, OvertimeHours, BaseSalary, amount, Month, Year);
            Dataprovider.Instance.ExecuteNonQuery(query);
        }

        public bool DeleteOTSummary(string empId, int Month, int Year)
        {
            string query = string.Format("DELETE FROM dbo.OvertimeSummary WHERE EmpId = '{0}' and Month = {1} and Year = {2}", empId, Month, Year);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
