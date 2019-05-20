using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using gdpv2.Entidades;

namespace gdpv2.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServicioGDPv2Propio" in both code and config file together.
    [ServiceContract(Namespace="gdpv2")]    
    public interface IServicioGDPv2Propio
    {
        [OperationContract]
        //[WebGet(UriTemplate = "TestServicio", ResponseFormat = WebMessageFormat.Json)]
        [WebInvoke(Method = "POST",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,                
                BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        string TestServicio(string algoMas);

        
        [OperationContract]
        [WebInvoke(Method = "POST",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,                     
                BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        string[] GetMunicipio(string prefix, string idioma);

        [OperationContract]
        [WebInvoke(Method = "POST",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        string[] GetEntidadSingular(string prefix, string idioma, string codMuni);

        [OperationContract]
        [WebInvoke(Method = "POST",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        string[] GetVia(string prefix, string idioma, string codMuni, string codEnti);

        [OperationContract]
        [WebInvoke(Method = "POST",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        string[] GetPortal(string prefix, string idioma, string codVia);

        [OperationContract]
        [WebInvoke(Method = "POST",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        string[] GetCasa(string prefix, string idioma, string codEnti, string codVia);

        [OperationContract]
        [WebInvoke(Method = "POST",
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        string DatosPortal(string idioma, string codPortal);

    }
}
