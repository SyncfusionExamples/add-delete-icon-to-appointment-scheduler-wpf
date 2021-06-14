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
    public class ScheduleBehavior : TargetedTriggerAction<Image>
    {

        Image image;
        protected override void Invoke(object parameter)
        {
            image = this.AssociatedObject as Image;
            image.PreviewMouseDown += Button_PreviewMouseDown;
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
            image.PreviewMouseDown -= Button_PreviewMouseDown;
            image = null;
        }
    }
}
