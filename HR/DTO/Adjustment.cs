using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class Adjustment
    {
        public Adjustment(int AdjustmentId, string AdjustmentType, string AdjustmentDes, int AdjustmentAmount)
        {
            this.AdjustmentId = AdjustmentId;
            this.AdjustmentName = AdjustmentDes;
            this.AdjustmentType = AdjustmentType;            
            this.AdjustmentAmount = AdjustmentAmount;
        }

        public Adjustment(DataRow row)
        {
            this.AdjustmentId = (int)row["AdjustmentId"];
            this.AdjustmentName = row["AdjustmentDes"].ToString();
            this.AdjustmentType = row["AdjustmentType"].ToString();            
            this.AdjustmentAmount = (int)row["AdjustmentAmount"];
        }

        private int adjustmentId;

        public int AdjustmentId
        {
            get { return adjustmentId; }
            set { adjustmentId = value; }
        }

        private string adjustmentType;

        public string AdjustmentType
        {
            get { return adjustmentType; }
            set { adjustmentType = value; }
        }

        private string adjustmentDes;

        public string AdjustmentName
        {
            get { return adjustmentDes; }
            set { adjustmentDes = value; }
        }

        private int adjustmentAmount;

        public int AdjustmentAmount
        {
            get { return adjustmentAmount; }
            set { adjustmentAmount = value; }
        }
    }
}
