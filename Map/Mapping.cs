using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using KPZ_5.Model;
using KPZ_5.ViewModels;

namespace KPZ_5.Map
{
    public class Mapping
    {
        public void Create()
        {
            Mapper.CreateMap<DataModel, DataViewModel>();
            Mapper.CreateMap<DataViewModel, DataModel>();

            Mapper.CreateMap<Case, CasesViewModel>();
            Mapper.CreateMap<CasesViewModel, Case>();

            Mapper.CreateMap<AccountViewModel, Account>();
            Mapper.CreateMap<Account, AccountViewModel>();
        }
    }
}
