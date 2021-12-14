using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KPZ_5.Views
{
    /// <summary>
    /// Interaction logic for SupplierUserControl.xaml
    /// </summary>
    public partial class AccountsUserControl : UserControl
    {
        public AccountsUserControl()
        {
            InitializeComponent();
        }

        private void MusicButton_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayer _mpBgr = new MediaPlayer();
            _mpBgr.Open(new Uri(@"C:\Users\asus\Downloads\04726.mp3", UriKind.Absolute));
            _mpBgr.Play();
        }
    }
}
