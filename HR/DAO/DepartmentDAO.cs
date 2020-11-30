using HR.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAO
{    
    public class DepartmentDAO
    {
        private static DepartmentDAO instance;

        public static DepartmentDAO Instance
        {
            get { if (instance == null) instance = new DepartmentDAO(); return DepartmentDAO.instance; }
            private set { DepartmentDAO.instance = value; }
        }

        private DepartmentDAO() { }
        

        public List<Department> GetListDepartment()
        {
            List<Department> list = new List<Department>();

            string query = "select * from Department";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Department department = new Department(item);
                list.Add(department);
            }

            return list;
        }

        public DataTable GetTableDepartment()      {
            
            string query = "select * from Department";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);            

            return data;
        }


        public bool InsertDepartment(string name)
        {
            string query = string.Format("INSERT dbo.Department ( DepName ) VALUES  ( N'{0}')", name);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateDepartment(string name, int id)
        {
            string query = string.Format("UPDATE dbo.Department SET DepName = N'{0}' WHERE DepId = {1}", name, id);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteDepartment(int id)
        {       
            string query = string.Format("Delete dbo.Department WHERE DepId = {0}", id);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
