using System;
using UsefulControls.Clock.Interfaces;
using UsefulControls.Clock.Models;

namespace UsefulControls.Clock.ViewModels
{
    public class ClockTestViewModel : ModelBase
    {
        private DateTime time;

        public ClockTestViewModel(ITimeProvider timeProvider) => timeProvider.OnTimeChange += this.RefreshTime;

        public DateTime Time
        {
            get => time;
            set => SetProperty(ref time, value, nameof(Time));
        }

        private void RefreshTime(object sender, EventArgs eventArgs) => Time = DateTime.Now;
    }
}
