using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_5
{
    [DataContract]
    class Case
    {
        [DataMember] public int Id { get; set; }
        [DataMember] public int AccountId { get; set; }
        [DataMember] public string Subject { get; set; }
        [DataMember] public string Comment { get; set; }
        [DataMember] public Status Status { get; set; }
    }


    [DataContract]
    public enum Status
    {
        [EnumMember] IsBeingDelivered,
        [EnumMember] Delivered,
        [EnumMember] Eaten
    }
}
