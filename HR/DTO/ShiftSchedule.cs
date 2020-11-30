using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.DTO
{
    public class ShiftSchedule
    {
        public ShiftSchedule(int ScheduleId, string Days, String OTBeforeFrom, String OTBeforeTo, String ClockIn, String ClockOut, String StartBreak, String EndBreak, String OTAfterFrom, String OTAfterTo, int ShiftId)
        {
            this.ScheduleId = ScheduleId;
            this.Days = this.Days;
            this.OTBeforeFrom = this.OTBeforeFrom;
            this.OTBeforeTo = this.OTBeforeTo;
            this.ClockOut = this.ClockOut;
            this.ClockIn = this.ClockIn;
            this.StartBreak = this.StartBreak;
            this.EndBreak = this.EndBreak;
            this.OTAfterFrom = this.OTAfterFrom;
            this.OTAfterTo = this.OTAfterTo;
            this.ShiftId = this.ShiftId;
        }

        public ShiftSchedule(DataRow row)
        {
            this.ScheduleId = (int)row["ScheduleId"];
            this.Days = row["Days"].ToString();
            this.OTBeforeFrom = row["OTBeforeFrom"].ToString();
            this.OTBeforeTo = row["OTBeforeTo"].ToString();
            this.ClockIn = row["ClockIn"].ToString();
            this.ClockOut = row["ClockOut"].ToString();
            this.StartBreak = row["StartBreak"].ToString();
            this.EndBreak = row["EndBreak"].ToString();
            this.OTAfterFrom = row["OTAfterFrom"].ToString();
            this.OTAfterTo = row["OTAfterTo"].ToString();
            this.ShiftId = (int)row["ShiftId"];
        }

        private int scheduleId;

        public int ScheduleId
        {
            get { return scheduleId; }
            set { scheduleId = value; }
        }

        private string days;

        public string Days
        {
            get { return days; }
            set { days = value; }
        }

        private String oTBeforeFrom;

        public String OTBeforeFrom
        {
            get { return oTBeforeFrom; }
            set { oTBeforeFrom = value; }
        }

        private String oTBeforeTo;

        public String OTBeforeTo
        {
            get { return oTBeforeTo; }
            set { oTBeforeTo = value; }
        }

        private String clockIn;

        public String ClockIn
        {
            get { return clockIn; }
            set { clockIn = value; }
        }

        private String clockOut;

        public String ClockOut
        {
            get { return clockOut; }
            set { clockOut = value; }
        }

        private String startBreak;

        public String StartBreak
        {
            get { return startBreak; }
            set { startBreak = value; }
        }

        private String endBreak;

        public String EndBreak
        {
            get { return endBreak; }
            set { endBreak = value; }
        }

        private String oTAfterFrom;

        public String OTAfterFrom
        {
            get { return oTAfterFrom; }
            set { oTAfterFrom = value; }
        }

        private String oTAfterTo;

        public String OTAfterTo
        {
            get { return oTAfterTo; }
            set { oTAfterTo = value; }
        }

        private int shiftId;

        public int ShiftId
        {
            get { return shiftId; }
            set { shiftId = value; }
        }
    }
}
