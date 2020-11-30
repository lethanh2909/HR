using HR.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAO
{
    public class SummaryDAO
    {
        private static SummaryDAO instance;

        public static SummaryDAO Instance
        {
            get { if (instance == null) instance = new SummaryDAO(); return instance; }
            private set { instance = value; }
        }

        private SummaryDAO() { }

        public List<Summary> GetListSummary(string empid, int month, int year)
        {
            List<Summary> list = new List<Summary>();

            string query = string.Format("exec USP_LoadSummary '{0}', '{1}', '{2}'", empid, month, year);

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Summary summary = new Summary(item);
                list.Add(summary);
            }

            return list;
        }

        public bool DeletePersonalSummary(string empid, int month, int year)
        {
            string query = string.Format("Delete dbo.PersonalSummary WHERE EmpId = '{0}' and Month = {1} and Year = {2}", empid, month, year);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteCurrentSummary(int id)
        {
            string query = "Delete dbo.PersonalSummary WHERE ptid = " + id;
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public object CountAttendance(string Datefrom, string Dateto, string empid)
        {
            string query = string.Format("exec USP_CountAttAbs '{0}' , '{1}' , '{2}'", Datefrom, Dateto, empid);

            object result = Dataprovider.Instance.ExecuteScalar(query);

            return result;
        }

        public object CountAbsence(string Datefrom, string Dateto, string empid)
        {
            string query = string.Format("exec USP_CountAbsence '{0}' , '{1}' , '{2}'", Datefrom, Dateto, empid);

            object result = Dataprovider.Instance.ExecuteScalar(query);

            return result;
        }

        public void InsertSummary(string EmpId, string FirstName, string LastName, int BaseSalary, int Attendance, int Absence, string SalaryFormula, int Month, int Year)
        {
            string query = string.Format("INSERT dbo.PersonalSummary (EmpId, FirstName, LastName, BaseSalary, Attendance, Absence, SalaryFormula, Month, Year) VALUES  ( N'{0}', '{1}', '{2}', {3}, {4}, {5}, '{6}', {7}, {8})", EmpId, FirstName, LastName, BaseSalary, Attendance, Absence, SalaryFormula, Month, Year);
            Dataprovider.Instance.ExecuteNonQuery(query);
        }
        
    }
}
