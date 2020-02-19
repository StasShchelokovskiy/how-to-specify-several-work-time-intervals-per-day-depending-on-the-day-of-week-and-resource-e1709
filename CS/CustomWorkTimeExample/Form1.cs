using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;

namespace CustomWorkTimeExample
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = Application.ProductName;

            schedulerControl1.QueryWorkTime += SchedulerControl1_QueryWorkTime;
            
            InitializeScheduler();

        }

        private void InitializeScheduler()
        {
            for (int i = 1; i < 5; i++)
            {
                Resource res = schedulerControl1.DataStorage.Resources.CreateResource(i, i.ToString());
                schedulerControl1.DataStorage.Resources.Add(res);
            }
            schedulerControl1.ActiveViewType = SchedulerViewType.FullWeek;
            schedulerControl1.GroupType = SchedulerGroupType.Resource;
            schedulerControl1.DateNavigationBar.Visible = false;
            schedulerControl1.OptionsView.NavigationButtons.Visibility = NavigationButtonVisibility.Never;
        }
        #region #QueryWorkTime
        private void SchedulerControl1_QueryWorkTime(object sender, QueryWorkTimeEventArgs e)
        {
            if (e.Resource.Id.Equals(1))
            {
                if (e.Interval.Start.Day % 2 == 0)
                {
                    List<TimeOfDayInterval> workTimes = new List<TimeOfDayInterval>();
                    workTimes.Add(new TimeOfDayInterval(TimeSpan.FromHours(0), TimeSpan.FromHours(3)));
                    workTimes.Add(new TimeOfDayInterval(TimeSpan.FromHours(5), TimeSpan.FromHours(8)));
                    workTimes.Add(new TimeOfDayInterval(TimeSpan.FromHours(10), TimeSpan.FromHours(11)));
                    e.WorkTimes.AddRange(workTimes);
                }
                else
                    e.WorkTime = new TimeOfDayInterval(TimeSpan.FromHours(8), TimeSpan.FromHours(20));
            }
            if (e.Resource.Id.Equals(2))
            {
                if (e.Interval.Start.Day % 2 == 0)
                    e.WorkTime = new TimeOfDayInterval(TimeSpan.FromHours(14), TimeSpan.FromHours(18));
                else
                    e.WorkTime = new TimeOfDayInterval(TimeSpan.FromHours(8), TimeSpan.FromHours(12));
            }
            if (e.Resource.Id.Equals(3))
                e.WorkTime = new TimeOfDayInterval(TimeSpan.FromHours(14), TimeSpan.FromHours(21));
            if (e.Resource.Id.Equals(4))
            {
                List<TimeOfDayInterval> workTimes = new List<TimeOfDayInterval>();
                workTimes.Add(new TimeOfDayInterval(TimeSpan.FromHours(8), TimeSpan.FromHours(11)));
                workTimes.Add(new TimeOfDayInterval(TimeSpan.FromHours(13), TimeSpan.FromHours(17)));
                e.WorkTimes.AddRange(workTimes);
            }
        }
        #endregion #QueryWorkTime
    }

}
