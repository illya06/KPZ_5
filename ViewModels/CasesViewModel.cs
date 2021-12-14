using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_5.ViewModels
{
    class CasesViewModel : ViewModelBase
    {

        private Status status;
        private int _id;
        private string _subject;
        private string _comment;
        private int _accountId;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        public int AccountId
        {
            get => _accountId;
            set
            {
                _accountId = value;
                OnPropertyChanged("Id");
            }
        }

        public string Subject
        {
            get => _subject;
            set
            {
                _subject = value;
                OnPropertyChanged("Subject");
            }
        }

        public string Comment
        {
            get => _comment;
            set
            {
                _comment = value;
                OnPropertyChanged("Subject");
            }
        }


        public Status Status
        {
            get { return status; }
            set
            {
                status = value;
                OnPropertyChanged("Status");
            }
        }
    }
}
