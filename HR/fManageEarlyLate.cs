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
    public partial class fManageEarlyLate : Office2007Form
    {
        BindingSource EarlyLate = new BindingSource();
        public fManageEarlyLate()
        {
            InitializeComponent();
            dtgvLateEarly.DataSource = EarlyLate;
            txbConfirmLate.Enabled = false;
            txbValueLate.Enabled = false;
            txbConfirmEarly.Enabled = false;
            txbValueEarly.Enabled = false;
            LoadShiftIntoCb();
            loadEarlyandLate();
            AddBinding();
        }

        private void ckbLateIn_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbLateIn.Checked==true)
            {
                txbConfirmLate.Enabled = true;
                txbValueLate.Enabled = true;
            }
            else
            {
                txbConfirmLate.Enabled = false;
                txbValueLate.Enabled = false;
            }
        }

        private void ckbEarlyOut_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbEarlyOut.Checked==true)
            {
                txbConfirmEarly.Enabled = true;
                txbValueEarly.Enabled = true;
            }
            else
            {
                txbConfirmEarly.Enabled = false;
                txbValueEarly.Enabled = false;
            }
        }

        void LoadShiftIntoCb()
        {
            List<WorkShift> listShift = WorkShiftDAO.Instance.GetListShift();
            cbbShiftName.DataSource = listShift;
            cbbShiftName.DisplayMember = "ShiftName";
        }

        void loadEarlyandLate()
        {
            EarlyLate.DataSource = EarlyAndLateDAO.Instance.GetTableEarlyAndLate();
            dtgvLateEarly.Columns[0].Visible = false;
        }

        void FilterDtgv()
        {
            string rowFilter = string.Empty;
            
            if (ckbEarlyOut.Checked == true && ckbLateIn.Checked == true)
            {
                rowFilter += "EarlyOut > '0' OR LateIn > '0'";
            }
            else if (ckbEarlyOut.Checked == true)
            {
                rowFilter += "EarlyOut > '0'";
            }
            else if(ckbLateIn.Checked == true)
            {
                rowFilter += "LateIn > '0'";
            }            

            try
            {
                //Check an see what's in the dgv
                string StartDate = DatePickerFrom.Text;
                DateTime datefrom = DateTime.ParseExact(StartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string DateFrom = datefrom.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

                string EndDate = DatePickerTo.Text;
                DateTime dateto = DateTime.ParseExact(EndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string DateTo = dateto.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

                DataTable dt = EarlyAndLateDAO.Instance.FilteredEarlyAndLate(DateFrom, DateTo);

                DataView dv = new DataView(dt);
                dv.RowFilter = rowFilter;
                EarlyLate.DataSource = dv;

            }
            catch (Exception)
            {
                MessageBox.Show("Can’t find!!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        void AddBinding()
        {
            lbId.DataBindings.Add(new Binding("Text", dtgvLateEarly.DataSource, "EmpId", true, DataSourceUpdateMode.Never));
            lbFisrt.DataBindings.Add(new Binding("Text", dtgvLateEarly.DataSource, "FirstName", true, DataSourceUpdateMode.Never));
            lbLast.DataBindings.Add(new Binding("Text", dtgvLateEarly.DataSource, "LastName", true, DataSourceUpdateMode.Never));
            txbValueLate.DataBindings.Add(new Binding("Text", dtgvLateEarly.DataSource, "LateIn", true, DataSourceUpdateMode.Never));
            txbConfirmLate.DataBindings.Add(new Binding("Text", dtgvLateEarly.DataSource, "ConfirmedLateIn", true, DataSourceUpdateMode.Never));
            txbValueEarly.DataBindings.Add(new Binding("Text", dtgvLateEarly.DataSource, "EarlyOut", true, DataSourceUpdateMode.Never));
            txbConfirmEarly.DataBindings.Add(new Binding("Text", dtgvLateEarly.DataSource, "ConfirmedEarlyOut", true, DataSourceUpdateMode.Never));
            txbId.DataBindings.Add(new Binding("Text", dtgvLateEarly.DataSource, "ELid", true, DataSourceUpdateMode.Never));
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FilterDtgv();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (EarlyAndLateDAO.Instance.CheckNullEarlyAndLate() == null)
                {
                    string StartDate = "29/09/1999";
                    DateTime datefrom = DateTime.ParseExact(StartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string DateFrom = datefrom.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

                    string EndDate = "29/09/9999";
                    DateTime dateto = DateTime.ParseExact(EndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string DateTo = dateto.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

                    EarlyAndLateDAO.Instance.LoadEarlyAndLate(DateFrom, DateTo);

                    List<EarlyAndLate> list = EarlyAndLateDAO.Instance.GetListEarlyAndLate();
                    foreach (EarlyAndLate item in list)
                    {
                        DateTime dateValue = item.WorkDay;

                        string datereal = Convert.ToString(dateValue);
                        string DateReal = DateTime.ParseExact(datereal, "d/MM/yyyy hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");

                        string shday = dateValue.ToString("dddd");
                        string shname = item.ShiftName;
                        DateTime ClockInReal = DateTime.ParseExact(item.ClockIn, "HH:mm:ss", CultureInfo.InvariantCulture);
                        DateTime ClockOutReal = DateTime.ParseExact(item.ClockOut, "HH:mm:ss", CultureInfo.InvariantCulture);

                        DataTable getshedule = ShiftScheduleDAO.Instance.GetTableScheduleByDateName(shday, shname);

                        string ClockInstr = getshedule.Rows[0]["ClockIn"].ToString();
                        DateTime ClockIn = DateTime.ParseExact(ClockInstr, "HH:mm:ss", CultureInfo.InvariantCulture);

                        string ClockOutstr = getshedule.Rows[0]["ClockOut"].ToString();
                        DateTime ClockOut = DateTime.ParseExact(ClockOutstr, "HH:mm:ss", CultureInfo.InvariantCulture);

                        TimeSpan latetime = ClockInReal - ClockIn;
                        TimeSpan earlytime = ClockOut - ClockOutReal;

                        int late = Convert.ToInt32(latetime.TotalMinutes);
                        int early = Convert.ToInt32(earlytime.TotalMinutes);

                        if (late < 0)
                        {
                            late = 0;
                        }
                        if (early < 0)
                        {
                            early = 0;
                        }
                        EarlyAndLateDAO.Instance.UpdateEarlyLate(late, early, DateReal);
                    }
                    loadEarlyandLate();
                }
                else
                {
                    DataTable table = EarlyAndLateDAO.Instance.GetTableEarlyAndLate();
                    string lastRow = table.Rows[table.Rows.Count - 1]["Workday"].ToString();
                    DateTime datefrom = DateTime.ParseExact(lastRow, "d/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                    DateTime tomorrowfrom = datefrom.AddDays(1);
                    string DateFrom = tomorrowfrom.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

                    string EndDate = "29/09/9999";
                    DateTime dateto = DateTime.ParseExact(EndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string DateTo = dateto.ToString("yyyy-MM-dd", CultureInfo.CurrentCulture);

                    EarlyAndLateDAO.Instance.LoadEarlyAndLate(DateFrom, DateTo);

                    List<EarlyAndLate> list = EarlyAndLateDAO.Instance.GetListEarlyAndLate();
                    foreach (EarlyAndLate item in list)
                    {
                        DateTime dateValue = item.WorkDay;

                        string datereal = Convert.ToString(dateValue);
                        string DateReal = DateTime.ParseExact(datereal, "d/MM/yyyy hh:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");

                        string shday = dateValue.ToString("dddd");
                        string shname = item.ShiftName;
                        DateTime ClockInReal = DateTime.ParseExact(item.ClockIn, "HH:mm:ss", CultureInfo.InvariantCulture);
                        DateTime ClockOutReal = DateTime.ParseExact(item.ClockOut, "HH:mm:ss", CultureInfo.InvariantCulture);

                        DataTable getshedule = ShiftScheduleDAO.Instance.GetTableScheduleByDateName(shday, shname);

                        string ClockInstr = getshedule.Rows[0]["ClockIn"].ToString();
                        DateTime ClockIn = DateTime.ParseExact(ClockInstr, "HH:mm:ss", CultureInfo.InvariantCulture);

                        string ClockOutstr = getshedule.Rows[0]["ClockOut"].ToString();
                        DateTime ClockOut = DateTime.ParseExact(ClockOutstr, "HH:mm:ss", CultureInfo.InvariantCulture);

                        TimeSpan latetime = ClockInReal - ClockIn;
                        TimeSpan earlytime = ClockOut - ClockOutReal;

                        int late = Convert.ToInt32(latetime.TotalMinutes);
                        int early = Convert.ToInt32(earlytime.TotalMinutes);

                        if (late < 0)
                        {
                            late = 0;
                        }
                        if (early < 0)
                        {
                            early = 0;
                        }
                        EarlyAndLateDAO.Instance.UpdateEarlyLate(late, early, DateReal);
                    }
                    loadEarlyandLate();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can’t load!! Make sure that the timekeeping has no empty rows", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to save the changes?", "Message", MessageBoxButtons.YesNo))
            {
                int ConfirmLateIn = Convert.ToInt32(txbConfirmLate.Text);
                int ConfirmEarlyOut = Convert.ToInt32(txbConfirmEarly.Text);
                int id = Convert.ToInt32(txbId.Text);

                EarlyAndLateDAO.Instance.ConfirmEarlyLate(ConfirmLateIn, ConfirmEarlyOut, id);
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

                EarlyAndLateDAO.Instance.DeleteEarlyLate(DateFrom, DateTo);
                FilterDtgv();
            }
        }
    }
}
