using HR.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAO
{
    public class ShiftEmployeeDAO
    {
        private static ShiftEmployeeDAO instance;

        public static ShiftEmployeeDAO Instance
        {
            get { if (instance == null) instance = new ShiftEmployeeDAO(); return ShiftEmployeeDAO.instance; }
            private set { ShiftEmployeeDAO.instance = value; }
        }

        private ShiftEmployeeDAO() { }

        public List<ShiftEmployee> GetListShiftEmployeeByShiftID(int id)
        {
            List<ShiftEmployee> list = new List<ShiftEmployee>();

            string query = "select * from ShiftEmployee where ShiftId = " + id;

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ShiftEmployee shiftemployee = new ShiftEmployee(item);
                list.Add(shiftemployee);
            }

            return list;
        }

        public ShiftEmployee CheckShiftEmployee(string id)
        {
            ShiftEmployee exist = null;

            string query = string.Format("select * from ShiftEmployee where EmpId = N'{0}'", id);

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                exist = new ShiftEmployee(item);
                return exist;
            }

            return exist;
        }

        public void InsertShiftEmployee(string EmpId, string FirstName, string LastName, string ShiftName, string DateStart, string DateEnd, int ShiftId)
        {
            string query = string.Format("INSERT dbo.ShiftEmployee ( EmpId, FirstName, LastName, ShiftName, DateStart, DateEnd, ShiftId ) VALUES  ( N'{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6})", EmpId, FirstName, LastName, ShiftName, DateStart, DateEnd, ShiftId);
            Dataprovider.Instance.ExecuteNonQuery(query);
        }

        public bool DeleteShiftEmployee(int id)
        {
            string query = string.Format("Delete dbo.ShiftEmployee WHERE SEid = {0}", id);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
