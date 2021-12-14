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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KPZ_5.ViewModels;

namespace KPZ_5.Views
{
    /// <summary>
    /// Interaction logic for ClothesUserControl.xaml
    /// </summary>
    public partial class CasesUserControl : UserControl
    {
        public CasesUserControl()
        {
            InitializeComponent();
        }

        private void eatButton_click(object sender, RoutedEventArgs e)
        {
            var clothes = (CasesViewModel)dataGrid.SelectedItem;
            if (clothes != null) clothes.Status = Status.Eaten;
        }
    }
}
