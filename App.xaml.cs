using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AutoMapper;
using KPZ_5.Map;
using KPZ_5.ViewModels;

namespace KPZ_5
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private DataModel model;
        private DataViewModel dataViewModel;

        public App()
        {
            new Mapping().Create();

            model = DataModel.Load();
            dataViewModel = Mapper.Map<DataModel, DataViewModel>(model);

            var window = new MainWindow(){DataContext = dataViewModel };
            window.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            try
            {
                model = Mapper.Map<DataViewModel, DataModel>(dataViewModel);
                model.Save();
            }
            catch (Exception)
            {
                base.OnExit(null);
                throw;
            }
        }
    }
}
