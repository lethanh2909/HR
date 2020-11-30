using HR.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;

        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return EmployeeDAO.instance; }
            private set { EmployeeDAO.instance = value; }
        }

        private EmployeeDAO() { }

        public DataTable GetTableEmployee(int id)
        {
            string query = "select * from Employee where PosiId = " + id;

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            return data;
        }

        public DataTable GetTableEmployeeName(string id)
        {
            string query = string.Format("SELECT FirstName + ' ' + LastName AS name FROM Employee where EmpId = N'{0}'", id);

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            return data;
        }        

        public Employee CheckEmployeeByPosID(int id)
        {
            Employee employee = null;

            string query = "select * from Employee where PosiId = " + id;

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                employee = new Employee(item);
                return employee;
            }

            return employee;
        }

        public List<Employee> GetListEmployeeByPosID(int id)
        {
            List<Employee> list = new List<Employee>();

            string query = "select * from Employee where PosiId = " + id;

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Employee employee = new Employee(item);
                list.Add(employee);
            }

            return list;
        }

        public List<Employee> GetListEmployee()
        {
            List<Employee> list = new List<Employee>();

            string query = "select * from Employee";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Employee employee = new Employee(item);
                list.Add(employee);
            }

            return list;
        }

        public DataTable GetDataTableEmployee()
        {
            string query = "select * from Employee ";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            return data;
        }

        public List<Employee> GetListEmployeeByName(string firstname, string lastname)
        {
            List<Employee> list = new List<Employee>();

            string query = "select * from Employee where FirstName = '" + firstname + "' and LastName = '" + lastname + "'";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Employee employee = new Employee(item);
                list.Add(employee);
            }

            return list;
        }

        public bool InsertEmployee(string empId, string image, string firstName, string lastName, string email, string gender, string address, string city, string state, DateTime dob, string nationality, string maritalstatus, string phone, string highschool, string university, string college, string religion, string depaName, string posiName, int posiId)
        {
            string query = string.Format("INSERT dbo.Employee (EmpId, Image, FirstName, LastName, Email, Gender, Address, City, State, Dob, Nationality, Maritalstatus, Phone, Highschool, University, College, Religion, DepaName, PosiName, PosiId) VALUES (N'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}' )", empId, image, firstName, lastName, email, gender, address, city, state, dob, nationality, maritalstatus, phone, highschool, university, college, religion, depaName, posiName, posiId);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);
            //string query = string.Format("INSERT dbo.Employee (EmpId, Image, FirstName, LastName, Email, Gender, Address, City, State, Dob, Nationality, Maritalstatus, Phone, Highschool, University, College, Religion, DepaName, PosiName, PosiId) VALUES (N{0}', {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15}, {16}, {17}, {18}, {19})", empId, image, firstName, lastName, email, gender, address, city, state, dob, nationality, maritalstatus, phone, highschool, university, college, religion, depaName, posiName, posiId);

            return result > 0;
        }

        public bool UpdateEmployee(string empId, string image, string firstName, string lastName, string email, string gender, string address, string city, string state, DateTime dob, string nationality, string maritalstatus, string phone, string highschool, string university, string college, string religion, string depaName, string posiName, int posiId)
        {
            string query = string.Format("UPDATE dbo.Employee SET Image = '{1}', FirstName = '{2}', LastName = '{3}', Email = '{4}', Gender = '{5}', Address = '{6}', City = '{7}', State = '{8}', Dob = '{9}', Nationality = '{10}', Maritalstatus = '{11}', Phone = '{12}', Highschool = '{13}', University = '{14}', College = '{15}', Religion = '{16}', DepaName = '{17}', PosiName = '{18}', PosiId = '{19}'  WHERE empId = N'{0}'", empId, image, firstName, lastName, email, gender, address, city, state, dob, nationality, maritalstatus, phone, highschool, university, college, religion, depaName, posiName, posiId);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);
            
            return result > 0;
        }

        public bool DeleteEmployee(string eid)
        {
            string query = string.Format("Delete dbo.Employee WHERE empId = N'{0}'", eid);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }

}
