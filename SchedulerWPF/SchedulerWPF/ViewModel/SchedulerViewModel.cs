using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace WpfScheduler
{
    public class SchedulerViewModel : NotificationObject
    {
        private List<string> eventCollection;
        private List<DateTime> startTimeCollection;
        private List<string> colorCollection;
        public SchedulerViewModel()
        {
            this.InitializingDataForEvents();
            this.AddAppointments();
        }
        public ObservableCollection<Events> Appointments { get; set; }
        private void AddAppointments()
        {
            var random = new Random();
            this.Appointments = new ObservableCollection<Events>();

            for (int i = 0; i < 60; i++)
            {
                var year = DateTime.Now.Date.Year;
                var month = DateTime.Now.Date.AddMonths(random.Next(-1, 2)).Month;
                var day = random.Next(1, 30);
                var hour = random.Next(9, 14);
                var newEvent = new Events();
                newEvent.EventName = this.eventCollection[random.Next(0, 4)];
                newEvent.From = new DateTime(year, month, day, hour, 0, 0);
                newEvent.To = newEvent.From.AddHours(1);
                newEvent.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(this.colorCollection[random.Next(0, 15)]));
                this.Appointments.Add(newEvent);
            }

        }
        private void InitializingDataForEvents()
        {
            this.eventCollection = new List<string>();
            this.eventCollection.Add("Conference");
            this.eventCollection.Add("System Troubleshoot");
            this.eventCollection.Add("Birthday");
            this.eventCollection.Add("Checkup");
            this.eventCollection.Add("Conference");

            this.startTimeCollection = new List<DateTime>();
            this.startTimeCollection.Add(DateTime.Now.Date.AddHours(10));
            this.startTimeCollection.Add(DateTime.Now.Date.AddDays(1).AddHours(9));
            this.startTimeCollection.Add(DateTime.Now.Date.AddDays(2).AddHours(10));
            this.startTimeCollection.Add(DateTime.Now.Date.AddDays(3).AddHours(9));
            this.startTimeCollection.Add(DateTime.Now.Date.AddDays(11).AddHours(10));
            this.startTimeCollection.Add(DateTime.Now.Date.AddDays(15).AddHours(9));
            this.startTimeCollection.Add(DateTime.Now.Date.AddDays(18).AddHours(10));
            this.startTimeCollection.Add(DateTime.Now.Date.AddDays(20).AddHours(9));
            this.startTimeCollection.Add(DateTime.Now.Date.AddDays(24).AddHours(9));
            this.startTimeCollection.Add(DateTime.Now.Date.AddDays(27).AddHours(10));
            this.startTimeCollection.Add(DateTime.Now.Date.AddMonths(1).AddHours(10));
            this.startTimeCollection.Add(DateTime.Now.Date.AddMonths(1).AddDays(4).AddHours(9));
            this.startTimeCollection.Add(DateTime.Now.Date.AddMonths(1).AddDays(11).AddHours(9));
            this.startTimeCollection.Add(DateTime.Now.Date.AddMonths(-1).AddHours(10));
            this.startTimeCollection.Add(DateTime.Now.Date.AddMonths(-1).AddDays(3).AddHours(9));
            this.startTimeCollection.Add(DateTime.Now.Date.AddMonths(1).AddDays(7).AddHours(10));
            this.startTimeCollection.Add(DateTime.Now.Date.AddMonths(-1).AddDays(6).AddHours(10));
            this.startTimeCollection.Add(DateTime.Now.Date.AddMonths(-1).AddDays(9).AddHours(9));

            this.colorCollection = new List<string>();
            this.colorCollection.Add("#FFA2C139");
            this.colorCollection.Add("#FFD80073");
            this.colorCollection.Add("#FF1BA1E2");
            this.colorCollection.Add("#FFE671B8");
            this.colorCollection.Add("#FFF09609");
            this.colorCollection.Add("#FF339933");
            this.colorCollection.Add("#FF00ABA9");
            this.colorCollection.Add("#FFE671B8");
            this.colorCollection.Add("#FF1BA1E2");
            this.colorCollection.Add("#FFD80073");
            this.colorCollection.Add("#FFA2C139");
            this.colorCollection.Add("#FFA2C139");
            this.colorCollection.Add("#FFD80073");
            this.colorCollection.Add("#FF339933");
            this.colorCollection.Add("#FFE671B8");
            this.colorCollection.Add("#FF00ABA9");
        }
    }
}

