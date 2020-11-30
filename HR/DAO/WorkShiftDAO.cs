using HR.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DAO
{
    public class WorkShiftDAO
    {
        private static WorkShiftDAO instance;

        public static WorkShiftDAO Instance
        {
            get { if (instance == null) instance = new WorkShiftDAO(); return instance; }
            private set { instance = value; }
        }

        private WorkShiftDAO() { }

        public List<WorkShift> GetListShift()
        {
            List<WorkShift> list = new List<WorkShift>();

            string query = "select * from WorkShift";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                WorkShift Shift = new WorkShift(item);
                list.Add(Shift);
            }

            return list;
        }        

        public void InsertWorkShift(int ShiftId, string ShiftName, string colorId)
        {
            string query = string.Format("INSERT dbo.WorkShift ( ShiftId, ShiftName, colorId ) VALUES  ( N'{0}', '{1}', '{2}')", ShiftId, ShiftName, colorId);
            Dataprovider.Instance.ExecuteNonQuery(query);
        }

        public bool UpdateWorkShift(int ShiftId, string ShiftName, string colorId)
        {
            string query = string.Format("UPDATE dbo.WorkShift SET ShiftId = N'{0}', ShiftName = '{1}', colorId = '{2}' WHERE ShiftId = N'{0}'", ShiftId, ShiftName, colorId);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteWorkShift(int ShiftId)
        {
            string query = string.Format("Delete dbo.WorkShift WHERE ShiftId = {0}", ShiftId);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
