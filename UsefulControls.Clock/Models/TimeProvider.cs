using System;
using System.Windows.Threading;
using UsefulControls.Clock.Interfaces;

namespace UsefulControls.Clock.Models
{
    public class TimeProvider : ModelBase, ITimeProvider
    {
        private DateTime time;
        private DispatcherTimer timer;

        public event EventHandler OnTimeChange;

        public TimeProvider()
        {
            Time = DateTime.Now;
            Timer = new DispatcherTimer();
            Timer.Start();
            Timer.Tick += this.OnTimerTick;
        }

        private void OnTimerTick(object sender, EventArgs eventArgs) => OnTimeChange?.Invoke(sender, eventArgs);

        public DateTime Time
        {
            get => time;
            set => SetProperty(ref time, value, nameof(Time));
        }

        public DispatcherTimer Timer
        {
            get => timer;
            set => SetProperty(ref timer, value, nameof(Timer));
        }
    }
}
