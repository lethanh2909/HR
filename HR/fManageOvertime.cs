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
using HR.DTO;

namespace HR
{
    public partial class fManageOvertime : Office2007Form
    {
        BindingSource Overtime = new BindingSource();
        public fManageOvertime()
        {
            InitializeComponent();
            dtgvOvertime.DataSource = Overtime;
            loadOvertime();
            AddBinding();
            LoadTypeIntoCb();
        }

        void loadOvertime()
        {
            Overtime.DataSource = OvertimeDAO.Instance.GetTableOvertime();
            dtgvOvertime.Columns[0].Visible = false;
        }

        void FilterDtgv()
        {
            try
            {
                //Check an see what's in the dgv
                string StartDate = DatePickerFrom.Text;
                DateTime datefrom = DateTime.ParseExact(StartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string DateFrom = datefrom.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

                string EndDate = DatePickerTo.Text;
                DateTime dateto = DateTime.ParseExact(EndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string DateTo = dateto.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

                DataTable dt = OvertimeDAO.Instance.FilteredOvertime(DateFrom, DateTo);
                
                Overtime.DataSource = dt;

            }
            catch (Exception)
            {
                MessageBox.Show("Can’t find!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void LoadTypeIntoCb()
        {
            List<OvertimeType> listDepartment = OvertimeTypeDAO.Instance.GetListOvertimeType();
            cbbType.DataSource = listDepartment;
            cbbType.DisplayMember = "Overtimetype";
        }

        void AddBinding()
        {
            cbbType.DataBindings.Add(new Binding("Text", dtgvOvertime.DataSource, "OvertimeType", true, DataSourceUpdateMode.Never));
            txbValue.DataBindings.Add(new Binding("Text", dtgvOvertime.DataSource, "OvertimeValue", true, DataSourceUpdateMode.Never));
            txbHour.DataBindings.Add(new Binding("Text", dtgvOvertime.DataSource, "OvertimeHours", true, DataSourceUpdateMode.Never));
            txbConfirm.DataBindings.Add(new Binding("Text", dtgvOvertime.DataSource, "ConfirmedHours", true, DataSourceUpdateMode.Never));
            txbId.DataBindings.Add(new Binding("Text", dtgvOvertime.DataSource, "OTid", true, DataSourceUpdateMode.Never));
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (OvertimeDAO.Instance.CheckNullOvertime() == null)
                {
                    string StartDate = "29/09/1999";
                    DateTime datefrom = DateTime.ParseExact(StartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string DateFrom = datefrom.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

                    string EndDate = "29/09/9999";
                    DateTime dateto = DateTime.ParseExact(EndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string DateTo = dateto.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

                    List<Timekeeping> list = TimekeepingDAO.Instance.GetListTimekeepingByDate(DateFrom, DateTo);
                    foreach (Timekeeping item in list)
                    {
                        string empid = item.EmployeeId;
                        string Fullname = item.Fullname;
                        string shiftname = item.ShiftName;
                        DateTime workday = item.Workday;
                        string Workday = workday.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

                        DateTime dateValue = item.Workday;

                        string datereal = Convert.ToString(dateValue);
                        string DateReal = DateTime.ParseExact(datereal, "d/MM/yyyy hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");

                        string shday = dateValue.ToString("dddd");
                        string shname = item.ShiftName;

                        DateTime OvertimeTo = DateTime.ParseExact(item.ClockOut, "HH:mm:ss", CultureInfo.InvariantCulture);
                        DateTime OvertimeFrom = DateTime.ParseExact(item.ClockIn, "HH:mm:ss", CultureInfo.InvariantCulture);

                        DataTable getshedule = ShiftScheduleDAO.Instance.GetTableScheduleByDateName(shday, shname);

                        string ClockInstr = getshedule.Rows[0]["ClockIn"].ToString();
                        DateTime ClockIn = DateTime.ParseExact(ClockInstr, "HH:mm:ss", CultureInfo.InvariantCulture);

                        string ClockOutstr = getshedule.Rows[0]["ClockOut"].ToString();
                        DateTime ClockOut = DateTime.ParseExact(ClockOutstr, "HH:mm:ss", CultureInfo.InvariantCulture);

                        string otaafterfrom = getshedule.Rows[0]["OTAfterFrom"].ToString();
                        DateTime OTAfterFrom = DateTime.ParseExact(otaafterfrom, "HH:mm:ss", CultureInfo.InvariantCulture);

                        DateTime OTAfterTo = DateTime.ParseExact(getshedule.Rows[0]["OTAfterTo"].ToString(), "HH:mm:ss", CultureInfo.InvariantCulture);

                        DateTime OTBeforeFrom = DateTime.ParseExact(getshedule.Rows[0]["OTBeforeFrom"].ToString(), "HH:mm:ss", CultureInfo.InvariantCulture);

                        string otbeforeto = getshedule.Rows[0]["OTBeforeTo"].ToString();
                        DateTime OTBeforeTo = DateTime.ParseExact(otbeforeto, "HH:mm:ss", CultureInfo.InvariantCulture);

                        TimeSpan OTAfterHour = (OTAfterTo - OTAfterFrom) - (OTAfterTo - OvertimeTo);
                        int OTAafterhours = Convert.ToInt32(OTAfterHour.TotalHours);

                        TimeSpan OTBeforeHour = (OTBeforeTo - OTBeforeFrom) - (OvertimeFrom - OTBeforeFrom);
                        int OTBeforehours = Convert.ToInt32(OTBeforeHour.TotalHours);

                        if (OTBeforehours > 0)
                        {
                            string overtimeFrom = item.ClockIn;
                            OvertimeDAO.Instance.InsertOvertime(empid, Fullname, shiftname, Workday, overtimeFrom, otbeforeto, OTBeforehours);
                        }

                        if (OTAafterhours > 0)
                        {
                            string overtimeTo = item.ClockOut;
                            OvertimeDAO.Instance.InsertOvertime(empid, Fullname, shiftname, Workday, otaafterfrom, overtimeTo, OTAafterhours);
                        }
                    }
                }
                else
                {
                    DataTable table = OvertimeDAO.Instance.GetTableOvertime();
                    string lastRow = table.Rows[table.Rows.Count - 1]["Workday"].ToString();
                    DateTime datefrom = DateTime.ParseExact(lastRow, "d/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                    DateTime tomorrowfrom = datefrom.AddDays(1);
                    string DateFrom = tomorrowfrom.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

                    string EndDate = "29/09/9999";
                    DateTime dateto = DateTime.ParseExact(EndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string DateTo = dateto.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

                    List<Timekeeping> list = TimekeepingDAO.Instance.GetListTimekeepingByDate(DateFrom, DateTo);
                    foreach (Timekeeping item in list)
                    {
                        string empid = item.EmployeeId;
                        string Fullname = item.Fullname;
                        string shiftname = item.ShiftName;
                        DateTime workday = item.Workday;
                        string Workday = workday.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

                        DateTime dateValue = item.Workday;

                        string datereal = Convert.ToString(dateValue);
                        string DateReal = DateTime.ParseExact(datereal, "d/MM/yyyy hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");

                        string shday = dateValue.ToString("dddd");
                        string shname = item.ShiftName;

                        DateTime OvertimeTo = DateTime.ParseExact(item.ClockOut, "HH:mm:ss", CultureInfo.InvariantCulture);
                        DateTime OvertimeFrom = DateTime.ParseExact(item.ClockIn, "HH:mm:ss", CultureInfo.InvariantCulture);

                        DataTable getshedule = ShiftScheduleDAO.Instance.GetTableScheduleByDateName(shday, shname);

                        string ClockInstr = getshedule.Rows[0]["ClockIn"].ToString();
                        DateTime ClockIn = DateTime.ParseExact(ClockInstr, "HH:mm:ss", CultureInfo.InvariantCulture);

                        string ClockOutstr = getshedule.Rows[0]["ClockOut"].ToString();
                        DateTime ClockOut = DateTime.ParseExact(ClockOutstr, "HH:mm:ss", CultureInfo.InvariantCulture);

                        string otaafterfrom = getshedule.Rows[0]["OTAfterFrom"].ToString();
                        DateTime OTAfterFrom = DateTime.ParseExact(otaafterfrom, "HH:mm:ss", CultureInfo.InvariantCulture);

                        DateTime OTAfterTo = DateTime.ParseExact(getshedule.Rows[0]["OTAfterTo"].ToString(), "HH:mm:ss", CultureInfo.InvariantCulture);

                        DateTime OTBeforeFrom = DateTime.ParseExact(getshedule.Rows[0]["OTBeforeFrom"].ToString(), "HH:mm:ss", CultureInfo.InvariantCulture);

                        string otbeforeto = getshedule.Rows[0]["OTBeforeTo"].ToString();
                        DateTime OTBeforeTo = DateTime.ParseExact(otbeforeto, "HH:mm:ss", CultureInfo.InvariantCulture);

                        TimeSpan OTAfterHour = (OTAfterTo - OTAfterFrom) - (OTAfterTo - OvertimeTo);
                        int OTAafterhours = Convert.ToInt32(OTAfterHour.TotalHours);

                        TimeSpan OTBeforeHour = (OTBeforeTo - OTBeforeFrom) - (OvertimeFrom - OTBeforeFrom);
                        int OTBeforehours = Convert.ToInt32(OTBeforeHour.TotalHours);

                        if (OTBeforehours > 0)
                        {
                            string overtimeFrom = item.ClockIn;
                            OvertimeDAO.Instance.InsertOvertime(empid, Fullname, shiftname, Workday, overtimeFrom, otbeforeto, OTBeforehours);
                        }

                        if (OTAafterhours > 0)
                        {
                            string overtimeTo = item.ClockOut;
                            OvertimeDAO.Instance.InsertOvertime(empid, Fullname, shiftname, Workday, otaafterfrom, overtimeTo, OTAafterhours);
                        }
                    }

                }
                loadOvertime();
            }
            catch(Exception)
            {
                MessageBox.Show("Can’t load!! Make sure that the timekeeping has no empty rows", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadOvertime();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FilterDtgv();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to save the changes?", "Message", MessageBoxButtons.YesNo))
            {
                string type = cbbType.Text;
                int value = Convert.ToInt32(txbValue.Text);
                int OvertimeHours = Convert.ToInt32(txbHour.Text);
                int confirm = Convert.ToInt32(txbConfirm.Text);
                int id = Convert.ToInt32(txbId.Text);

                OvertimeDAO.Instance.ConfirmOvertime(type, value, OvertimeHours, confirm, id);
                FilterDtgv();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo))
            {
                string StartDate = DatePickerFrom.Text;
                DateTime datefrom = DateTime.ParseExact(StartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string DateFrom = datefrom.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

                string EndDate = DatePickerTo.Text;
                DateTime dateto = DateTime.ParseExact(EndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string DateTo = dateto.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

                OvertimeDAO.Instance.DeleteOvertime(DateFrom, DateTo);
                FilterDtgv();
            }
        }

        private void btnEditType_Click(object sender, EventArgs e)
        {
            fModifyOvertimeType f = new fModifyOvertimeType();
            f.ShowDialog();
        }

        private void cbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            OvertimeType selected = cb.SelectedItem as OvertimeType;
            id = selected.Typeid;

            LoadTypeTotxb(id);
        }

        void LoadTypeTotxb(int id)
        {
            List<OvertimeType> list = OvertimeTypeDAO.Instance.GetTypeOvertimeType(id);
            foreach(OvertimeType item in list)
            {
                txbValue.Text = Convert.ToString(item.OvertimeValue);
            }
        }
    }
}
