using CommonServiceLocator;
using Unity;
using Unity.ServiceLocation;
using UsefulControls.Clock.Interfaces;
using UsefulControls.Clock.Models;
using UsefulControls.Clock.ViewModels;

namespace UsefulControls.Clock.Views
{
    public class ViewModelLocator
    {
        public ViewModelLocator() => UseUnity();

        public ClockTestViewModel ClockTestViewModel => ServiceLocator.Current.GetInstance<ClockTestViewModel>();

        private void UseUnity()
        {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<ITimeProvider, TimeProvider>();
            container.RegisterType<ClockTestViewModel>();

            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(container));
        }
    }
}
