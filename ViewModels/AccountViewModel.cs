using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_5.ViewModels
{
    class AccountViewModel : ViewModelBase
    {
        private string name;
        private string surname;
        private string email;
        private string phonenumber;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Surname
        {
            get => surname;
            set
            {
                surname = value;
                OnPropertyChanged("Color");
            }
        }

        public string PhoneNumber
        {
            get => phonenumber;
            set
            {
                phonenumber = value;
                OnPropertyChanged("Case");
            }
        }

        public string Email
        {
            get => email;
            set
            {
                email = value;
                OnPropertyChanged("Price");
            }
        }
    }
}
