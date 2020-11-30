using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class ShiftEmployee
    {
        public ShiftEmployee(int SEid, string EmpId, string FirstName, string LastName, string ShiftName, DateTime DateStart, DateTime DateEnd, int ShiftId)
        {
            this.SEid = SEid;
            this.EmpId = EmpId;
            this.FirstName = this.FirstName;
            this.LastName = this.LastName;
            this.ShiftName = this.ShiftName;
            this.DateStart = this.DateStart;
            this.DateEnd = this.DateEnd;
            this.ShiftId = this.ShiftId;            
        }

        public ShiftEmployee(DataRow row)
        {
            this.SEid = (int)row["SEid"];
            this.EmpId = row["EmpId"].ToString();
            this.FirstName = row["FirstName"].ToString();
            this.LastName = row["LastName"].ToString();
            this.ShiftName = row["ShiftName"].ToString();
            this.DateStart = (DateTime)row["DateStart"];            
            this.DateEnd = (DateTime)row["DateEnd"];            
            this.ShiftId = (int)row["ShiftId"];
        }

        private int sEid;

        public int SEid
        {
            get { return sEid; }
            set { sEid = value; }
        }

        private string empId;

        public string EmpId
        {
            get { return empId; }
            set { empId = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string shiftName;

        public string ShiftName
        {
            get { return shiftName; }
            set { shiftName = value; }
        }

        private DateTime dateStart;

        public DateTime DateStart
        {
            get { return dateStart; }
            set { dateStart = value; }
        }

        private DateTime dateEnd;

        public DateTime DateEnd
        {
            get { return dateEnd; }
            set { dateEnd = value; }
        }

        private int shiftId;

        public int ShiftId
        {
            get { return shiftId; }
            set { shiftId = value; }
        }
    }
}
