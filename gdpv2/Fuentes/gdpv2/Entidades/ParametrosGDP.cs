using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace gdpv2.Entidades
{
    [DataContract(Name = "ParametrosGDP", Namespace = "http://GDPv2/")]
    [Serializable]
    public class ParametrosGDP
    {
        [DataMember]
        public string usuario { get; set; }
        [DataMember]
        public string password { get; set; }
        [DataMember]
        public string urlwsAlfaws { get; set; }
        [DataMember]
        public string idiomaSel { get; set; }

    }
}
