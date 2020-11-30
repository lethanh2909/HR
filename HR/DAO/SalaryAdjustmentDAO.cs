
using HR.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAO
{
    public class SalaryAdjustmentDAO
    {
        private static SalaryAdjustmentDAO instance;

        public static SalaryAdjustmentDAO Instance
        {
            get { if (instance == null) instance = new SalaryAdjustmentDAO(); return instance; }
            private set { instance = value; }
        }

        private SalaryAdjustmentDAO() { }


        public DataTable GetListSalaryAdjustment()
        {
            string query = "exec USP_LoadSalaryAdjustment";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);           

            return data;
        }

        public SalaryAdjustment CheckListSalaryAdjustment()
        {
            SalaryAdjustment check = null;

            string query = "select * from SalaryAdjustment";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                check = new SalaryAdjustment(item);
                return check;
            }

            return check;
        }

        public bool InsertSalaryAdjustment(string id, string name, string type, int amount, int percent, int month, int year, string description)
        {
            string query = string.Format("INSERT dbo.SalaryAdjustment ( EmpId, EmpName, AdjustmentType, AdjustmentAmount, SalaryPercent, ApplytoMonth, AdjustmentYear, Description ) VALUES  ( N'{0}', '{1}', '{2}', {3}, {4}, {5}, {6}, '{7}')", id, name, type, amount, percent, month, year, description);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateSalaryAdjustment(string id, string name, string type, int amount, int percent, int month, int year, string description)
        {
            string query = string.Format("UPDATE dbo.SalaryAdjustment SET EmpId = N'{0}', EmpName = '{1}', AdjustmentType = '{2}', AdjustmentAmount = {3}, SalaryPercent = {4}, ApplytoMonth = {5}, AdjustmentYear = {6}, Description  = '{7}' WHERE EmpId = N'{0}'", id, name, type, amount, percent, month, year, description);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteSalaryAdjustment(string id)
        {
            string query = string.Format("Delete dbo.SalaryAdjustment WHERE EmpId = N'{0}'", id);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
