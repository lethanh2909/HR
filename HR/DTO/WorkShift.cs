using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class WorkShift
    {
        public WorkShift(int ShiftId, string ShiftName, string ColorTag)
        {
            this.ShiftId = ShiftId;
            this.ShiftName = ShiftName;
            this.ColorTag = ColorTag;
        }

        public WorkShift(DataRow row)
        {
            this.ShiftId = (int)row["ShiftId"];
            this.ShiftName = (string)row["ShiftName"];
            this.ColorTag = row["colorId"].ToString();

        }

        private int shiftId;

        public int ShiftId
        {
            get { return shiftId; }
            set { shiftId = value; }
        }

        private string shiftName;

        public string ShiftName
        {
            get { return shiftName; }
            set { shiftName = value; }
        }

        private string colorid;

        public string ColorTag
        {
            get { return colorid; }
            set { colorid = value; }
        }
    }
}
