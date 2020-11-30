using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR.DTO;

namespace HR.DAO
{
    public class AllowanceSummaryDAO
    {
        private static AllowanceSummaryDAO instance;

        public static AllowanceSummaryDAO Instance
        {
            get { if (instance == null) instance = new AllowanceSummaryDAO(); return instance; }
            private set { instance = value; }
        }

        private AllowanceSummaryDAO() { }

        public bool InsertAllSummary(string EmpId, string FirstName, string LastName, string AllowanceType, int AllowanceAmount, string AllFormula, int Month, int Year)
        {
            string query = string.Format("INSERT dbo.AllowanceSummary ( EmpId, FirstName, LastName, AllowanceType, AllowanceAmount, AllFormula, Month, Year ) VALUES  ( N'{0}', '{1}' , '{2}' , '{3}', {4}, '{5}', {6}, {7})", EmpId, FirstName, LastName, AllowanceType, AllowanceAmount, AllFormula, Month, Year);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public List<AllowanceSummary> GetListAllSummary(string empid, int month, int year)
        {
            List<AllowanceSummary> list = new List<AllowanceSummary>();

            string query = string.Format("exec USP_LoadAllSummary '{0}', '{1}', '{2}'", empid, month, year);

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                AllowanceSummary ot = new AllowanceSummary(item);
                list.Add(ot);
            }

            return list;
        }

        public bool DeleteAllSummary(string empId, int Month, int Year)
        {
            string query = string.Format("DELETE FROM dbo.AllowanceSummary WHERE EmpId = '{0}' and Month = {1} and Year = {2}", empId, Month, Year);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
