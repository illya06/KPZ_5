using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using KPZ_5.Model;
using KPZ_5.Serialization;

namespace KPZ_5
{
    [DataContract]
    class DataModel
    {
        [DataMember]
        public List<Case> DataCasesList { get; set; }
        [DataMember]
        public List<Account> DataAccountsList { get; set; }

        public DataModel()
        {
            DataCasesList = new List<Case>(){new Case(){Id =1,AccountId = 1,Comment = "still waiting",Status = Status.IsBeingDelivered,Subject = "pizza"},
                new Case(){ Id = 2, AccountId = 1, Comment = "see you soon", Status = Status.Eaten, Subject = "RTX 3060" },
                new Case(){ Id = 3, AccountId = 2, Comment = "thanks", Status = Status.Delivered, Subject = "LEGO StarWars" }
            };
            DataAccountsList = new List<Account>(){new Account(){ Name = "Donald", Email = "donald@gmail.com", PhoneNumber = "0933534213", Surname = "Brew" } };
        }

        public static string Path = "info.dat";

        public static DataModel Load()
        {
            if (File.Exists(Path))
                return DataSerializer.DeserializeData(Path);

            return new DataModel();
        }

        public void Save()
        {
            DataSerializer.SerializeData(Path,this);
        }
    }
}
