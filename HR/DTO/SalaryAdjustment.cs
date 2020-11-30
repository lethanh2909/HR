using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class SalaryAdjustment
    {
        public SalaryAdjustment(string EmpId, string EmpName, string AdjustmentType, int AdjustmentAmount, int SalaryPercent, int ApplytoMonth, int Year, string Description)
        {
            this.EmpId = this.EmpId;
            this.EmpName = EmpName;
            this.AdjustmentType = AdjustmentType;
            this.AdjustmentAmount = AdjustmentAmount;
            this.SalaryPercent = SalaryPercent;
            this.ApplytoMonth = ApplytoMonth;
            this.Year = Year;
            this.Description = Description;
            
        }

        public SalaryAdjustment(DataRow row)
        {
            this.EmpId = row["EmpId"].ToString(); ;
            this.EmpName = row["EmpName"].ToString();
            this.AdjustmentType = row["AdjustmentType"].ToString();
            this.AdjustmentAmount = (int)row["AdjustmentAmount"];
            this.SalaryPercent = (int)row["SalaryPercent"];
            this.ApplytoMonth = (int)row["ApplytoMonth"];
            this.Year = (int)row["AdjustmentYear"];
            this.Description = row["Description"].ToString();
            
        }

        private string empId;

        public string EmpId
        {
            get { return empId; }
            set { empId = value; }
        }

        private string empName;

        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }

        private string adjustmentType;

        public string AdjustmentType
        {
            get { return adjustmentType; }
            set { adjustmentType = value; }
        }

        private int adjustmentAmount;

        public int AdjustmentAmount
        {
            get { return adjustmentAmount; }
            set { adjustmentAmount = value; }
        }

        private int salaryPercent;

        public int SalaryPercent
        {
            get { return salaryPercent; }
            set { salaryPercent = value; }
        }

        private int applytoMonth;

        public int ApplytoMonth
        {
            get { return applytoMonth; }
            set { applytoMonth = value; }
        }

        private int adjustmentYear;

        public int Year
        {
            get { return adjustmentYear; }
            set { adjustmentYear = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }        

    }
}
