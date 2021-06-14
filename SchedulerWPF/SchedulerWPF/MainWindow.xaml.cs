using Syncfusion.UI.Xaml.Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

using System.Windows.Input;

using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfScheduler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var d = (e.OriginalSource as FrameworkElement).DataContext as Events;
            var dataSource = (this.Schedule.DataContext as SchedulerViewModel).Appointments;
            if (dataSource != null && dataSource.Contains(d))
            {
                dataSource.Remove(d);
            }
        }

        private void ButtonAdv_Click(object sender, RoutedEventArgs e)
        {
            var d = (e.OriginalSource as FrameworkElement).DataContext as Events;
            var dataSource = (this.Schedule.DataContext as SchedulerViewModel).Appointments;
            if (dataSource != null && dataSource.Contains(d))
            {
                dataSource.Remove(d);
            }
        }

        private void ButtonAdv_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            var d = (e.OriginalSource as FrameworkElement).DataContext as Events;
            var dataSource = (this.Schedule.DataContext as SchedulerViewModel).Appointments;
            if (dataSource != null && dataSource.Contains(d))
            {
                dataSource.Remove(d);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var d = (e.OriginalSource as FrameworkElement).DataContext as Events;
            var dataSource = (this.Schedule.DataContext as SchedulerViewModel).Appointments;
            if (dataSource != null && dataSource.Contains(d))
            {
                dataSource.Remove(d);
            }
        }
    }
}
