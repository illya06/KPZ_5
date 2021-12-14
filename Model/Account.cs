using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_5.Model
{
    [DataContract]
    class Account
    {
        [DataMember] public string Name { get; set; }

        [DataMember] public string Surname { get; set; }

        [DataMember] public string Email { get; set; }

        [DataMember] public string PhoneNumber { get; set; }
    }
}
