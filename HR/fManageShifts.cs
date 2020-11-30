using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using HR.DAO;

namespace HR
{
    public partial class fManageShifts : Office2007Form
    {
        BindingSource Shifts = new BindingSource();

        public fManageShifts()
        {
            InitializeComponent();
            function(true);
            dtgvShift.DataSource = Shifts;
            cbbColorid.SelectedIndex = 0;
            
            LoadShiftsToDtgv();
            AddBinding();
        }        


        void LoadShiftsToDtgv()
        {
            Shifts.DataSource = WorkShiftDAO.Instance.GetListShift();
            dtgvShift.Columns[0].Width = 50;
            dtgvShift.Columns[1].Width = 98;
            dtgvShift.Columns[2].Width = 75;
        }

        void AddBinding()
        {
            txbId.DataBindings.Add(new Binding("Text", dtgvShift.DataSource, "ShiftId", true, DataSourceUpdateMode.Never));
            txbShiftName.DataBindings.Add(new Binding("Text", dtgvShift.DataSource, "ShiftName", true, DataSourceUpdateMode.Never));
            cbbColorid.DataBindings.Add(new Binding("Text", dtgvShift.DataSource, "ColorTag", true, DataSourceUpdateMode.Never));                        
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string OTBeforeFrom = TimePicker1.Text;
            TimePicker9.Text = OTBeforeFrom;
            TimePicker17.Text = OTBeforeFrom;
            TimePicker25.Text = OTBeforeFrom;
            TimePicker33.Text = OTBeforeFrom;
            TimePicker41.Text = OTBeforeFrom;
            TimePicker49.Text = OTBeforeFrom;

            string OTBeforeTo = TimePicker2.Text;
            TimePicker10.Text = OTBeforeTo;
            TimePicker18.Text = OTBeforeTo;
            TimePicker26.Text = OTBeforeTo;
            TimePicker34.Text = OTBeforeTo;
            TimePicker42.Text = OTBeforeTo;
            TimePicker50.Text = OTBeforeTo;

            string ClockIn = TimePicker3.Text;
            TimePicker11.Text = ClockIn;
            TimePicker19.Text = ClockIn;
            TimePicker27.Text = ClockIn;
            TimePicker35.Text = ClockIn;
            TimePicker43.Text = ClockIn;
            TimePicker51.Text = ClockIn;

            string ClockOut = TimePicker4.Text;
            TimePicker12.Text = ClockOut;
            TimePicker20.Text = ClockOut;
            TimePicker28.Text = ClockOut;
            TimePicker36.Text = ClockOut;
            TimePicker44.Text = ClockOut;
            TimePicker52.Text = ClockOut;

            string StartBreak = TimePicker5.Text;
            TimePicker13.Text = StartBreak;
            TimePicker21.Text = StartBreak;
            TimePicker29.Text = StartBreak;
            TimePicker37.Text = StartBreak;
            TimePicker45.Text = StartBreak;
            TimePicker53.Text = StartBreak;

            string EndBreak = TimePicker6.Text;
            TimePicker14.Text = EndBreak;
            TimePicker22.Text = EndBreak;
            TimePicker30.Text = EndBreak;
            TimePicker38.Text = EndBreak;
            TimePicker46.Text = EndBreak;
            TimePicker54.Text = EndBreak;

            string OTAfterFrom = TimePicker7.Text;
            TimePicker15.Text = OTAfterFrom;
            TimePicker23.Text = OTAfterFrom;
            TimePicker31.Text = OTAfterFrom;
            TimePicker39.Text = OTAfterFrom;
            TimePicker47.Text = OTAfterFrom;
            TimePicker55.Text = OTAfterFrom;

            string OTAfterTo = TimePicker8.Text;
            TimePicker16.Text = OTAfterTo;
            TimePicker24.Text = OTAfterTo;
            TimePicker32.Text = OTAfterTo;
            TimePicker40.Text = OTAfterTo;
            TimePicker48.Text = OTAfterTo;
            TimePicker56.Text = OTAfterTo;
        }
        

        void loadTimeToTimetable(int id)
        {
            if(ShiftScheduleDAO.Instance.CheckWorkShift(id) != null)
            {
                DateTimePicker[] DateTimes = { TimePicker1, TimePicker2, TimePicker3, TimePicker4, TimePicker5, TimePicker6, TimePicker7, TimePicker8, TimePicker9, TimePicker10, TimePicker11, TimePicker12, TimePicker13, TimePicker14, TimePicker15, TimePicker16, TimePicker17, TimePicker18, TimePicker19, TimePicker20, TimePicker21, TimePicker22, TimePicker23, TimePicker24, TimePicker25, TimePicker26, TimePicker27, TimePicker28, TimePicker29, TimePicker30, TimePicker31, TimePicker32, TimePicker33, TimePicker34, TimePicker35, TimePicker36, TimePicker37, TimePicker38, TimePicker39, TimePicker40, TimePicker41, TimePicker42, TimePicker43, TimePicker44, TimePicker45, TimePicker46, TimePicker47, TimePicker48, TimePicker49, TimePicker50, TimePicker51, TimePicker52, TimePicker53, TimePicker54, TimePicker55, TimePicker56 };
                List<string> timeList = new List<string>();
                DataTable data = ShiftScheduleDAO.Instance.GetTableSchedule(id);
                for (int i = 0; i <= 6; i++)
                {
                    for (int k = 2; k <= 9; k++)
                    {
                        //data.Rows[0][2].ToString();
                        string timeitem = data.Rows[i][k].ToString();
                        timeList.Add(timeitem);
                    }
                }
                for (int j = 0; j <= 55; j++)
                {
                    string time = timeList[j];
                    DateTime date = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture);
                    DateTimes[j].Text = date.ToString("hh:mm:ss tt", CultureInfo.CurrentCulture);
                }
            }
            else
            {
                MessageBox.Show("Shift Schedule is empty! Please add a new one");
            }            
        }


        private void btnLoadSchedule_Click(object sender, EventArgs e)
        {            
            if (txbId.TextLength != 0)
            {
                int id = Convert.ToInt32(txbId.Text);
                loadTimeToTimetable(id);
                
            }
            else
            {
                MessageBox.Show("Please create a new shift");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadShiftsToDtgv();
            if(cbbColorid.SelectedItem != null)
            {
                string color = cbbColorid.Text;
                txbColor.BackColor = Color.FromName(color);
            }            
        }

        private void txbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void function(bool b)
        {
            btnSave.Enabled = btnCancel.Enabled = txbId.Enabled = txbShiftName.Enabled = cbbColorid.Enabled= tableLayoutPanel1.Enabled = !b;

            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = b;
        }

        private bool Add = false, Edit = false;

        private void btnAdd_Click(object sender, EventArgs e)
        {           
            txbShiftName.Clear();
            txbId.Clear();
            DateTimePicker[] DateTimes = { TimePicker1, TimePicker2, TimePicker3, TimePicker4, TimePicker5, TimePicker6, TimePicker7, TimePicker8, TimePicker9, TimePicker10, TimePicker11, TimePicker12, TimePicker13, TimePicker14, TimePicker15, TimePicker16, TimePicker17, TimePicker18, TimePicker19, TimePicker20, TimePicker21, TimePicker22, TimePicker23, TimePicker24, TimePicker25, TimePicker26, TimePicker27, TimePicker28, TimePicker29, TimePicker30, TimePicker31, TimePicker32, TimePicker33, TimePicker34, TimePicker35, TimePicker36, TimePicker37, TimePicker38, TimePicker39, TimePicker40, TimePicker41, TimePicker42, TimePicker43, TimePicker44, TimePicker45, TimePicker46, TimePicker47, TimePicker48, TimePicker49, TimePicker50, TimePicker51, TimePicker52, TimePicker53, TimePicker54, TimePicker55, TimePicker56 };
            foreach (DateTimePicker TimesPicker in DateTimes)
            {
                string time = "00:00:00";
                DateTime date = DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture);
                TimesPicker.Text = date.ToString("hh:mm:ss tt", CultureInfo.CurrentCulture);
            }

            Add = true;
            Edit = false;
            function(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Add = false;
            Edit = true;
            function(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo))
            {
                if (txbId.TextLength == 0)
                {
                    MessageBox.Show("Select item to delete", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    int ShiftId = Convert.ToInt32(txbId.Text);

                    ShiftScheduleDAO.Instance.DeleteSchedule(ShiftId);
                    WorkShiftDAO.Instance.DeleteWorkShift(ShiftId);                   

                    LoadShiftsToDtgv();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Add == true)
            {
                if (txbShiftName.TextLength == 0)
                {
                    MessageBox.Show("Enter the Shift name", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        DateTimePicker[] DateTimes = {TimePicker0, TimePicker1, TimePicker2, TimePicker3, TimePicker4, TimePicker5,
                            TimePicker6, TimePicker7, TimePicker8, TimePicker9, TimePicker10, TimePicker11, TimePicker12, TimePicker13,
                            TimePicker14, TimePicker15, TimePicker16, TimePicker17, TimePicker18, TimePicker19, TimePicker20, TimePicker21,
                            TimePicker22, TimePicker23, TimePicker24, TimePicker25, TimePicker26, TimePicker27, TimePicker28, TimePicker29,
                            TimePicker30, TimePicker31, TimePicker32, TimePicker33, TimePicker34, TimePicker35, TimePicker36, TimePicker37,
                            TimePicker38, TimePicker39, TimePicker40, TimePicker41, TimePicker42, TimePicker43, TimePicker44, TimePicker45,
                            TimePicker46, TimePicker47, TimePicker48, TimePicker49, TimePicker50, TimePicker51, TimePicker52, TimePicker53, TimePicker54, TimePicker55, TimePicker56 };
                        string[] day = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

                        int ShiftId = Convert.ToInt32(txbId.Text);
                        string ShiftName = txbShiftName.Text;
                        string colorId = cbbColorid.Text;
                        WorkShiftDAO.Instance.InsertWorkShift(ShiftId, ShiftName, colorId);

                        for (int i = 0; i <= 48; i = i + 8)
                        {                            
                            string Days = day[i / 8];
                            string OTBeforeFrom = DateTimes[1 + i].Text;
                            string OTBeforeTo = DateTimes[2 + i].Text;
                            string ClockIn = DateTimes[3 + i].Text;
                            string ClockOut = DateTimes[4 + i].Text;
                            string StartBreak = DateTimes[5 + i].Text;
                            string EndBreak = DateTimes[6 + i].Text;
                            string OTAfterFrom = DateTimes[7 + i].Text;
                            string OTAfterTo = DateTimes[8 + i].Text;                            

                            ShiftScheduleDAO.Instance.InsertSchedule(Days, OTBeforeFrom, OTBeforeTo, ClockIn, ClockOut, StartBreak, EndBreak, OTAfterFrom, OTAfterTo, ShiftId, ShiftName);                            
                        }
                        
                        function(true);
                        int id = Convert.ToInt32(txbId.Text);
                        LoadShiftsToDtgv();
                        loadTimeToTimetable(id);

                        MessageBox.Show("Add successfully");
                    }
                    catch
                    {
                        MessageBox.Show("Add failed");
                    }
                }
            }

            else if (Edit == true)
            {
                if (txbShiftName.TextLength == 0)
                {
                    MessageBox.Show("Enter the Shift name", "Message", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        DateTimePicker[] DateTimes = { TimePicker0, TimePicker1, TimePicker2, TimePicker3, TimePicker4, TimePicker5, TimePicker6, TimePicker7, TimePicker8, TimePicker9, TimePicker10, TimePicker11, TimePicker12, TimePicker13, TimePicker14, TimePicker15, TimePicker16, TimePicker17, TimePicker18, TimePicker19, TimePicker20, TimePicker21, TimePicker22, TimePicker23, TimePicker24, TimePicker25, TimePicker26, TimePicker27, TimePicker28, TimePicker29, TimePicker30, TimePicker31, TimePicker32, TimePicker33, TimePicker34, TimePicker35, TimePicker36, TimePicker37, TimePicker38, TimePicker39, TimePicker40, TimePicker41, TimePicker42, TimePicker43, TimePicker44, TimePicker45, TimePicker46, TimePicker47, TimePicker48, TimePicker49, TimePicker50, TimePicker51, TimePicker52, TimePicker53, TimePicker54, TimePicker55, TimePicker56 };
                        string[] day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

                        int ShiftId = Convert.ToInt32(txbId.Text);
                        string ShiftName = txbShiftName.Text;
                        string colorId = cbbColorid.Text;
                        WorkShiftDAO.Instance.UpdateWorkShift(ShiftId, ShiftName, colorId);
                        for (int i = 0; i <= 48; i = i + 8)
                        {
                            string Days = day[i / 7];
                            string OTBeforeFrom = DateTimes[1 + i].Text;
                            string OTBeforeTo = DateTimes[2 + i].Text;
                            string ClockIn = DateTimes[3 + i].Text;
                            string ClockOut = DateTimes[4 + i].Text;
                            string StartBreak = DateTimes[5 + i].Text;
                            string EndBreak = DateTimes[6 + i].Text;
                            string OTAfterFrom = DateTimes[7 + i].Text;
                            string OTAfterTo = DateTimes[8 + i].Text;                            

                            ShiftScheduleDAO.Instance.UpdateSchedule(Days, OTBeforeFrom, OTBeforeTo, ClockIn, ClockOut, StartBreak, EndBreak, OTAfterFrom, OTAfterTo, ShiftId, ShiftName);                         
                        }                        
                        function(true);
                        int id = Convert.ToInt32(txbId.Text);
                        LoadShiftsToDtgv();
                        loadTimeToTimetable(id);
                        
                        MessageBox.Show("Edit successfully");
                    }
                    catch
                    {
                        MessageBox.Show("Edit failed");
                    }
                }
            }
        }

        
        private void cbbColorid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txbId.TextLength != 0)
                {
                    string color = cbbColorid.Text;
                    txbColor.BackColor = Color.FromName(color);
                }
            }
            catch (Exception) { }
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {            
            if (Add == true)
            {
                Add = false;
                function(true);
            }
            else if (Edit == true)
            {
                Edit = false;
                function(true);
            }
        }
    }
}
