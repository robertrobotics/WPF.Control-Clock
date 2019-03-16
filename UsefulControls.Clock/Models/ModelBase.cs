using System.ComponentModel;

namespace UsefulControls.Clock.Models
{
    public class ModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        protected void SetProperty<T>(ref T obj, T value, string name)
        {
            obj = value;
            OnPropertyChanged(name);
        }
    }
}
