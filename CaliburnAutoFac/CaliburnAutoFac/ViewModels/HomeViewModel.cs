using System.Collections.Generic;
using System.Linq;
using Caliburn.Micro;

namespace CaliburnAutoFac.ViewModels
{
    public class HomeViewModel : Conductor<IChildSampleViewModel>.Collection.OneActive
    {
        public HomeViewModel(IEnumerable<IChildSampleViewModel> childSampleViewModels)
        {
            Items.AddRange(childSampleViewModels);
            ActiveItem = Items.FirstOrDefault();
        }
    }
}