using HR.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAO
{
    public class SalaryFormulaDAO
    {
        private static SalaryFormulaDAO instance;

        public static SalaryFormulaDAO Instance
        {
            get { if (instance == null) instance = new SalaryFormulaDAO(); return instance; }
            private set { instance = value; }
        }

        private SalaryFormulaDAO() { }

        public List<SalaryFormula> GetListAllFormula()
        {
            List<SalaryFormula> list = new List<SalaryFormula>();

            string query = "select * from SalaryFormula";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SalaryFormula salaryFormula = new SalaryFormula(item);
                list.Add(salaryFormula);
            }

            return list;
        }

        public DataTable GetTableFormula()
        {
            string query = "select SformulaId as 'ID', SformulaName as 'Formula name', SformulaDes as 'Description', Sformula as 'Salary formula' from SalaryFormula";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable GetFormula(int id)
        {
            string query = "select * from SalaryFormula where SformulaId = " + id;

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            return data;
        }

        public bool InsertSalaryFormula(int id, string name, string des, string formula)
        {
            string query = string.Format("INSERT dbo.SalaryFormula ( SformulaId, SformulaName, SformulaDes, Sformula ) VALUES  ( N'{0}', '{1}', '{2}', '{3}')", id, name, des, formula);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateSalaryFormula(int id, string name, string des, string formula)
        {
            string query = string.Format("UPDATE dbo.SalaryFormula SET SformulaId = N'{0}', SformulaName = '{1}', SformulaDes = '{2}', Sformula = '{3}' WHERE SformulaId = {0}", id, name, des, formula);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteSalaryFormula(int id)
        {
            string query = string.Format("Delete dbo.SalaryFormula WHERE SformulaId = {0}", id);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
