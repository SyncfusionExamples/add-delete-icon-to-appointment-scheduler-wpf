using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.Scheduler;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace WpfScheduler
{
    public class ScheduleBehavior : TargetedTriggerAction<Button>
    {

        Button button;
        protected override void Invoke(object parameter)
        {
            button = this.AssociatedObject as Button;
            button.PreviewMouseDown += Button_PreviewMouseDown;
        }

        private void Button_PreviewMouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var schedule = (this.TargetObject as SfScheduler).DataContext as SchedulerViewModel;
            var d = (e.OriginalSource as FrameworkElement).DataContext as Events;
            var itemSource = schedule.Appointments;
            if (itemSource != null && itemSource.Contains(d))
            {
                itemSource.Remove(d);
            }
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            button.PreviewMouseDown -= Button_PreviewMouseDown;
            button = null;
        }
    }
}
