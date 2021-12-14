using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_5.Serialization
{
    class DataSerializer
    {
        public static void SerializeData(string path , DataModel data)
        {
            var formatter = new DataContractSerializer(typeof(DataModel));
            var fileStream = new FileStream(path, FileMode.Create);
            formatter.WriteObject(fileStream , data);
            fileStream.Close();
        }

        public static DataModel DeserializeData(string path)
        {
            var formatter = new DataContractSerializer(typeof(DataModel));
            var fileStream = new FileStream(path, FileMode.Open);

            return (DataModel) formatter.ReadObject(fileStream);
        }
    }
}
