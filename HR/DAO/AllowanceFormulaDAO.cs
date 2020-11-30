using HR.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAO
{
    public class AllowanceFormulaDAO
    {
        private static AllowanceFormulaDAO instance;

        public static AllowanceFormulaDAO Instance
        {
            get { if (instance == null) instance = new AllowanceFormulaDAO(); return instance; }
            private set { instance = value; }
        }

        private AllowanceFormulaDAO() { }


        public List<AllowanceFormula> GetListAllFormula()
        {
            List<AllowanceFormula> list = new List<AllowanceFormula>();

            string query = "select * from AllowanceFormula";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                AllowanceFormula allowanceFormula = new AllowanceFormula(item);
                list.Add(allowanceFormula);
            }

            return list;
        }

        public DataTable GetFormula(int id)
        {         

            string query = "select * from AllowanceFormula where FormulaId = " +id;

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);            

            return data;
        }

        public bool InsertFor(int FormulaId, string FormulaName, string Formula)
        {
            string query = string.Format("INSERT dbo.AllowanceFormula (FormulaId, FormulaName, Formula) VALUES  ( N'{0}', '{1}' , '{2}')", FormulaId, FormulaName, Formula);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateFor(int FormulaId, string FormulaName, string Formula)
        {
            string query = string.Format("UPDATE dbo.AllowanceFormula SET FormulaId = N'{0}', FormulaName = '{1}', Formula  = '{2}' WHERE FormulaId = {0}", FormulaId, FormulaName, Formula);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteFor(int id)
        {
            string query = string.Format("Delete dbo.AllowanceFormula WHERE FormulaId = {0}", id);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
