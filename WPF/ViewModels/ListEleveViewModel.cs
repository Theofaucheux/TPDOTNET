using Bussiness.TP.Queries;
using Modele.Faucheux;
using Modele.Faucheux.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.ViewModels.Common;
using WPF.Views;

namespace WPF.ViewModels
{
    class ListEleveViewModel : BaseViewModel
    {

        private ObservableCollection<DetailEleveViewModel> _eleves = null;
        private DetailEleveViewModel _selectedEleve;

        public ListEleveViewModel()
        {
            Context c = new Context();
            EleveQuery eq = new EleveQuery(c);
            List<Eleve> le = eq.GetAll().ToList();
            _eleves = new ObservableCollection<DetailEleveViewModel>();
            foreach(Eleve e in le)
            {
                _eleves.Add(new DetailEleveViewModel(e));
            }
            if(_eleves != null && _eleves.Count > 0)
            {
                _selectedEleve = _eleves.ElementAt(0);
            }
        }

        public ObservableCollection<DetailEleveViewModel> Eleves
        {
            get { return _eleves; }
            set { _eleves = value; OnPropertyChanged("Eleves"); }
        }

        public DetailEleveViewModel SelectedEleve
        {
            get { return _selectedEleve;  }
            set { _selectedEleve = value; OnPropertyChanged("SelectedEleve"); }
        }


    }
}
