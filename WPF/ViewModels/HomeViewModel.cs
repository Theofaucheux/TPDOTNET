using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.ViewModels.Common;
using WPF.Views;

namespace WPF.ViewModels
{
    class HomeViewModel : BaseViewModel
    {
        private ListEleveViewModel _listEleveVM = null;

        public HomeViewModel()
        {
            _listEleveVM = new ListEleveViewModel();
        }

        public ListEleveViewModel ListEleveViewModel { get { return _listEleveVM; } set { _listEleveVM = value; } }
    }
}
