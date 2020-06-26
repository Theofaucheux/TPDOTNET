using Modele.Faucheux.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.ViewModels.Common;

namespace WPF.ViewModels
{
    class DetailEleveViewModel : BaseViewModel
    {

        private string _nom;
        private string _prenom;
        private string _classe;
        private double _moyenne;
        private int _nbAbsence;
        private RelayCommand _addOperation;

        public DetailEleveViewModel(Eleve e)
        {
            _nom = e.Nom;
            _prenom = e.Prenom;
            _classe = e.Classe.Niveau;
            _moyenne = (from n in e.lNote select n.ValNote).Average();
            _nbAbsence = (from a in e.lAbsence select a).Count();
        }

        public string Nom { get => _nom; set => _nom = value; }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public string Classe { get => _classe; set => _classe = value; }
        public double Moyenne { get => _moyenne; }
        public int NbAbsence { get => _nbAbsence; }

        public ICommand AddOperation
        {
            get
            {
                if (_addOperation == null)
                {
                    _addOperation = new RelayCommand(() => this.ShowWindowOperation());
                }
                return _addOperation;
            }
        }

        private void ShowWindowOperation()
        {
            Views.Operation operationWindow = new Views.Operation();
            operationWindow.DataContext = this;
            operationWindow.ShowDialog();
        }

    }
}
