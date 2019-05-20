using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace gdpv2.Entidades
{
    [DataContract(Name = "Portal", Namespace = "http://GDPv2/")]
    [Serializable]
    public class Portal
    {
        [DataMember]
        public short codMun { get; set; }
        [DataMember]
        public string denomMun { get; set; }
        [DataMember]
        public int codEntSing { get; set; }
        [DataMember]
        public int codEntINE { get; set; }
        [DataMember]
        public string denomEntSing { get; set; }
        [DataMember]
        public int codVia { get; set; }
        [DataMember]
        public string denomVia { get; set; }
        [DataMember]
        public int codPortal { get; set; }
        [DataMember]
        public string Numero { get; set; }
        [DataMember]
        public string NomCasa { get; set; }
        [DataMember]
        public int codPostal { get; set; }
        [DataMember]
        public decimal X_25830 { get; set; }
        [DataMember]
        public decimal Y_25830 { get; set; }
    }
}