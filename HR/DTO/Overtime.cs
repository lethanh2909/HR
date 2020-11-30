using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class Overtime
    {
        public Overtime(string EmpId, string FullName, string ShiftName, DateTime WorkDay, string OvertimeType, int OvertimeValue, string OvertimeFrom, string OvertimeTo, int OvertimeHours, int ConfirmedHours)
        {
            this.EmpId = EmpId;
            this.FullName = FullName;            
            this.ShiftName = this.ShiftName;
            this.WorkDay = this.WorkDay;
            this.OvertimeType = this.OvertimeType;
            this.OvertimeValue = this.OvertimeValue;
            this.OvertimeFrom = this.OvertimeFrom;
            this.OvertimeTo = this.OvertimeTo;
            this.OvertimeHours = this.OvertimeHours;
            this.ConfirmedHours = this.ConfirmedHours;
        }

        public Overtime(DataRow row)
        {
            this.EmpId = row["EmpId"].ToString(); ;
            this.FullName = row["FullName"].ToString();            
            this.ShiftName = row["ShiftName"].ToString();
            this.WorkDay = (DateTime)row["WorkDay"];
            this.OvertimeType = row["OvertimeType"].ToString(); 
            this.OvertimeValue = (int)row["OvertimeValue"];
            this.OvertimeFrom = row["OvertimeFrom"].ToString();
            this.OvertimeTo = row["OvertimeTo"].ToString();
            this.OvertimeHours = (int)row["OvertimeHours"];
            this.ConfirmedHours = (int)row["ConfirmedHours"];
        }


        private string empId;

        public string EmpId
        {
            get { return empId; }
            set { empId = value; }
        }

        private string fullName;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
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

        private string overtimeType;

        public string OvertimeType
        {
            get { return overtimeType; }
            set { overtimeType = value; }
        }

        private int overtimeValue;

        public int OvertimeValue
        {
            get { return overtimeValue; }
            set { overtimeValue = value; }
        }

        private string overtimeFrom;

        public string OvertimeFrom
        {
            get { return overtimeFrom; }
            set { overtimeFrom = value; }
        }

        private string overtimeTo;

        public string OvertimeTo
        {
            get { return overtimeTo; }
            set { overtimeTo = value; }
        }

        private int overtimeHours;

        public int OvertimeHours
        {
            get { return overtimeHours; }
            set { overtimeHours = value; }
        }
        private int confirmedHours;

        public int ConfirmedHours
        {
            get { return confirmedHours; }
            set { confirmedHours = value; }
        }
    }
}
