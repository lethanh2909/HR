using HR.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAO
{
    public class AllowanceDAO
    {
        private static AllowanceDAO instance;

        public static AllowanceDAO Instance
        {
            get { if (instance == null) instance = new AllowanceDAO(); return instance; }
            private set { instance = value; }
        }

        private AllowanceDAO() { }

        public DataTable GetTableAllowance()
        {       
            string query = "select * from Allowance";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);            

            return data;
        }

        public List<Allowance> GetListAllowance()
        {
            List<Allowance> list = new List<Allowance>();

            string query = "select * from Allowance";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Allowance allowance = new Allowance(item);
                list.Add(allowance);
            }

            return list;
        }

        public bool InsertAllowance(int allId, string allName, int allTax, int amount, string allFormulaName, string allFormula)
        {
            string query = string.Format("INSERT dbo.Allowance ( AllId, AllName, AllTax, Amount, AllFormulaName, AllFormula ) VALUES  ( N'{0}', '{1}' , {2} , {3}, '{4}', '{5}' )", allId, allName, allTax, amount, allFormulaName, allFormula);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpadateSalaryAllowance()
        {            
            int result = Dataprovider.Instance.ExecuteNonQuery("exec USP_Upadate_SalaryAllowance");

            return result > 0;
        }       

        public bool UpdateAllowance(int allId, string allName, int allTax, int amount, string allFormulaName, string allFormula)
        {
            string query = string.Format("UPDATE dbo.Allowance SET AllId = N'{0}', AllName = '{1}', AllTax = {2}, Amount = {3}, AllFormulaName = '{4}', AllFormula = '{5}' WHERE AllId = {0}", allId, allName, allTax, amount, allFormulaName, allFormula);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAllowance(int allId)
        {
            string query = string.Format("Delete dbo.Allowance WHERE AllId = {0}", allId);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
