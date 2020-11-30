using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class OvertimeSummary
    {
        public OvertimeSummary(int osid, string Empid, string Fullname, string OvertimeType, int OvertimeHours, int BaseSalary, int Month, int Year, int Amount)
        {
            this.osid = osid;
            this.Empid = Empid;
            this.Fullname = Fullname;            
            this.OvertimeValue = this.OvertimeValue;
            this.OvertimeHours = this.OvertimeHours;
            this.BaseSalary = BaseSalary;
            this.Amount = Amount;
            this.Month = Month;
            this.Year = Year;
            
        }

        public OvertimeSummary(DataRow row)
        {
            this.osid = (int)row["osid"];
            this.Empid = row["EmpId"].ToString();
            this.Fullname = row["Fullname"].ToString();            
            this.OvertimeValue = row["OvertimeType"].ToString();
            this.OvertimeHours = (int)row["OvertimeHours"];
            this.BaseSalary = (int)row["BaseSalary"];
            this.Amount = (int)row["Amount"];
            this.Month = (int)row["Month"];
            this.Year = (int)row["Year"];            
        }

        private int Osid;

        public int osid
        {
            get { return Osid; }
            set { Osid = value; }
        }

        private string empid;

        public string Empid
        {
            get { return empid; }
            set { empid = value; }
        }

        private string fullname;

        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }        

        private string pvertimeType;

        public string OvertimeValue
        {
            get { return pvertimeType; }
            set { pvertimeType = value; }
        }

        private int overtimeHours;

        public int OvertimeHours
        {
            get { return overtimeHours; }
            set { overtimeHours = value; }
        }

        private int baseSalary;

        public int BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }

        private int amount;

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private int month;

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        
    }
}
