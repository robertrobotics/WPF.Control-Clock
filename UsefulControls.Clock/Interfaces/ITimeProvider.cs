using System;
using System.Windows.Threading;

namespace UsefulControls.Clock.Interfaces
{
    public interface ITimeProvider
    {
        DateTime Time { get; set; }

        DispatcherTimer Timer { get; set; }

        event EventHandler OnTimeChange;
    }
}
