using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class EarlyAndLate
    {
        public EarlyAndLate(string EmpId, string FirstName, string LastName, string ShiftName, DateTime WorkDay, string ClockIn, string ClockOut, int LateIn, int ConfirmedLateIn, int EarlyOut, int ConfirmedEarlyOut)
        {
            this.EmpId = EmpId;
            this.FirstName = FirstName;
            this.LastName = this.LastName;
            this.ShiftName = this.ShiftName;            
            this.WorkDay = this.WorkDay;
            this.ClockIn = this.ClockIn;
            this.ClockOut = this.ClockOut;
            this.LateIn = this.LateIn;
            this.ConfirmedLateIn = this.ConfirmedLateIn;
            this.EarlyOut = this.EarlyOut;
            this.ConfirmedEarlyOut = this.ConfirmedEarlyOut;
        }

        public EarlyAndLate(DataRow row)
        {
            this.EmpId = row["EmpId"].ToString(); ;
            this.FirstName = row["FirstName"].ToString();
            this.LastName = row["LastName"].ToString();
            this.ShiftName = row["ShiftName"].ToString();            
            this.WorkDay = (DateTime)row["WorkDay"];
            this.ClockIn = row["ClockIn"].ToString(); 
            this.ClockOut = row["ClockOut"].ToString(); 
            this.LateIn = (int)row["LateIn"];
            this.ConfirmedLateIn = (int)row["ConfirmedLateIn"];
            this.EarlyOut = (int)row["EarlyOut"];
            this.ConfirmedEarlyOut = (int)row["ConfirmedEarlyOut"];
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

        private DateTime workDay;

        public DateTime WorkDay
        {
            get { return workDay; }
            set { workDay = value; }
        }

        private string clockIn;

        public string ClockIn
        {
            get { return clockIn; }
            set { clockIn = value; }
        }

        private string clockOut;

        public string ClockOut
        {
            get { return clockOut; }
            set { clockOut = value; }
        }

        private int lateIn;

        public int LateIn
        {
            get { return lateIn; }
            set { lateIn = value; }
        }        

        private int confirmedLateIn;

        public int ConfirmedLateIn
        {
            get { return confirmedLateIn; }
            set { confirmedLateIn = value; }
        }

        private int earlyOut;

        public int EarlyOut
        {
            get { return earlyOut; }
            set { earlyOut = value; }
        }
        private int confirmedEarlyOut;

        public int ConfirmedEarlyOut
        {
            get { return confirmedEarlyOut; }
            set { confirmedEarlyOut = value; }
        }
    }
}
