using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using KPZ_5.Commands;

namespace KPZ_5.ViewModels
{
    class DataViewModel : ViewModelBase
    {
        #region Properties

        private string _visibleControl = "DataCasesList";

        public ICommand SetControlVisibility { get; set; }

        private ObservableCollection<CasesViewModel> _dataCasesList;
        private ObservableCollection<AccountViewModel> _dataAccountsList;

        public string VisibleControl
        {
            get { return _visibleControl; }
            set
            {
                _visibleControl = value;
                OnPropertyChanged("VisibleControl");
            }
        }

        public ObservableCollection<CasesViewModel> DataCasesList
        {
            get { return _dataCasesList;}
            set
            {
                _dataCasesList = value;
                OnPropertyChanged("DataCasesList");
            }
        }

        public ObservableCollection<AccountViewModel> DataAccountsList
        {
            get { return _dataAccountsList; }
            set
            {
                _dataAccountsList = value;
                OnPropertyChanged("DataAccountsList");
            }
        }
        #endregion

        #region Constructor

        public DataViewModel()
        {
            SetControlVisibility = new Command(ControlVisibility);
        }

        #endregion

        public void ControlVisibility(object parameters)
        {
            VisibleControl = parameters.ToString();
        }
    }
}
