using HR.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAO
{
    public class SalaryDAO
    {
        private static SalaryDAO instance;

        public static SalaryDAO Instance
        {
            get { if (instance == null) instance = new SalaryDAO(); return SalaryDAO.instance; }
            private set { SalaryDAO.instance = value; }
        }

        private SalaryDAO() { }


        public DataTable GetPivot()
        {
            DataTable data = Dataprovider.Instance.ExecuteQuery("exec USP_PivotSalary");

            return data;
        }

        public bool LoadSalary()
        {
            int result = Dataprovider.Instance.ExecuteNonQuery("exec USP_LoadSalary");

            return result > 0;
        }

        public DataTable GetBaseSalary(string id)
        {
            string query = "select FirstName, LastName, SalBase, SalFomula, AllType, Allamount from Salary where EmpId = " + "'"+ id + "'";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            return data;
        }

        public Salary CheckSalaryTable()
        {
            Salary salary = null;

            string query = "select * from Salary";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                salary = new Salary(item);
                return salary;
            }

            return salary;
        }

        public List<Salary> GetListSalary()
        {
            List<Salary> list = new List<Salary>();

            string query = "select * from Salary";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Salary salary = new Salary(item);
                list.Add(salary);
            }

            return list;
        }

        public bool LoadSalaryWhenAddAllowance(string alltype, int allowanceid)
        {
            string query = string.Format("INSERT INTO Salary (EmpId, AllType, FirstName, LastName, DepaName, PosiName, AllowanceId) SELECT  EmpId, N'{0}', FirstName, LastName, DepaName, PosiName, {1} FROM  Employee ", alltype, allowanceid);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool LoadSalaryWhenAddEmployee(string empId, string firstName, string lastName, string depaName, string posiName)
        {
            string query = string.Format("INSERT INTO Salary (EmpId, AllType, FirstName, LastName, DepaName, PosiName, AllowanceId) SELECT  N'{0}', AllName, '{1}', '{2}', '{3}', '{4}', Allid FROM  Allowance", empId, firstName, lastName, depaName, posiName);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteSalaryByAllId(int allid)
        {
            string query = string.Format("DELETE FROM Salary WHERE AllowanceId = '{0}'", allid);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteSalaryByEmpId(string empId)
        {
            string query = string.Format("DELETE FROM Salary WHERE EmpId = '{0}'", empId);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateSalary(string empId, string alltype, int amount, string formula, int BaseSal)
        {
            string query = string.Format("UPDATE Salary SET Allamount = {2}, SalFomula = '{3}', SalBase = '{4}' WHERE EmpId = N'{0}';", empId, alltype, amount, formula, BaseSal);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateSalaryWhenAddNewAll(int salbase, string fomula, string empid)
        {
            string query = string.Format("UPDATE Salary SET SalBase = N'{0}', SalFomula='{1}' Where EmpId = '{2}';", salbase, fomula, empid);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable SeacrhSalaryByEmpName(string id)
        {
            string query = "exec USP_SeacrhSalaryByEmpName @id";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query, new object[] { id });

            return data;
        }

        public DataTable SeacrhSalaryByDepaName(string depart)
        {
            string query = "exec USP_SeacrhSalaryByDepaName @depart";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query, new object[] { depart });

            return data;
        }

        public DataTable SeacrhSalaryByPosiName(string posi)
        {
            string query = "exec USP_SeacrhSalaryByPosiName @posi";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query, new object[] { posi });

            return data;
        }
    }    
}
