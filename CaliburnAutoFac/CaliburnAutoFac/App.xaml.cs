using Autofac;
using Caliburn.Micro.Xamarin.Forms;
using CaliburnAutoFac.ViewModels;

namespace CaliburnAutoFac
{
	public partial class App : FormsApplication
    {
        public App()
        {
            Initialize();
            DisplayRootViewFor<HomeViewModel>();
        }
	}
}