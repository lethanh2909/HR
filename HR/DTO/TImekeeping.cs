using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class Timekeeping
    {
        public Timekeeping(int tkid, string EmployeeId, string Fullname, string ShiftName, DateTime Workday, DateTime DateIn, string ClockIn, DateTime DateOut, string ClockOut, string AbsenceTypes, string Status)
        {
            this.tkid = tkid;
            this.EmployeeId = EmployeeId;
            this.Fullname = this.Fullname;
            this.ShiftName = this.ShiftName;
            this.Workday = this.Workday;
            this.DateIn = this.DateIn;
            this.ClockIn = this.ClockIn;
            this.DateOut = this.DateOut;
            this.ClockOut = this.ClockOut;
            this.AbsenceTypes = this.AbsenceTypes;
            this.Status = this.Status;
        }

        public Timekeeping(DataRow row)
        {
            this.tkid = (int)row["TKid"];
            this.EmployeeId = row["EmployeeId"].ToString();
            this.Fullname = row["Fullname"].ToString();
            this.ShiftName = row["ShiftName"].ToString();
            this.Workday = (DateTime)row["Workday"];
            this.DateIn = (DateTime)row["DateIn"];
            this.ClockIn = row["ClockIn"].ToString();
            this.DateOut = (DateTime)row["DateOut"];
            this.ClockOut = row["ClockOut"].ToString();
            this.AbsenceTypes = row["AbsenceTypes"].ToString();
            this.Status = row["Status"].ToString();
        }

        private int Tkid;

        public int tkid
        {
            get { return Tkid; }
            set { Tkid = value; }
        }

        private string employeeId;

        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        private string fullname;

        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }

        private String shiftName;

        public String ShiftName
        {
            get { return shiftName; }
            set { shiftName = value; }
        }

        private DateTime workday;

        public DateTime Workday
        {
            get { return workday; }
            set { workday = value; }
        }

        private DateTime dateIn;

        public DateTime DateIn
        {
            get { return dateIn; }
            set { dateIn = value; }
        }

        private String clockIn;

        public String ClockIn
        {
            get { return clockIn; }
            set { clockIn = value; }
        }

        private DateTime dateOut;

        public DateTime DateOut
        {
            get { return dateOut; }
            set { dateOut = value; }
        }

        private String clockOut;

        public String ClockOut
        {
            get { return clockOut; }
            set { clockOut = value; }
        }

        private String absenceTypes;

        public String AbsenceTypes
        {
            get { return absenceTypes; }
            set { absenceTypes = value; }
        }

        private String status;

        public String Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
