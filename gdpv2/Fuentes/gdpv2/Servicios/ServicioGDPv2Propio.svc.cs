using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using gdpv2.Entidades;
using gdpv2.Implementacion;
using System.Web.Configuration;
using System.ServiceModel.Activation;
using System.Web.Script.Serialization;

namespace gdpv2.Servicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServicioGDPv2Propio" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServicioGDPv2Propio.svc or ServicioGDPv2Propio.svc.cs at the Solution Explorer and start debugging.
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServicioGDPv2Propio : IServicioGDPv2Propio
    {
        public string TestServicio(string algoMas)
        {
            return "OK " + algoMas;
        }

        public string[] GetMunicipio(string prefix, string idioma)
        {
            List<string> municipios = new List<string>();
            OperacionesAlfaWS _OperacionesAlfaWS = new OperacionesAlfaWS(new ParametrosGDP()
            {
                usuario = WebConfigurationManager.AppSettings["GDPUsuario"],
                password = WebConfigurationManager.AppSettings["GDPPassword"],
                urlwsAlfaws = WebConfigurationManager.AppSettings["GDPAlfaws"]
            });

            AlfaWS.GDPClass resultadoM = _OperacionesAlfaWS.ObtenerMunicipios("%" + prefix.Trim() + "%", idioma.Trim());
            if (resultadoM.Municipio != null)
            {
                foreach (AlfaWS.Municipio muni in resultadoM.Municipio)
                {
                municipios.Add(string.Format("{0}#{1}", muni.CodMun, muni.DenomMun));
                }
            }
            return municipios.ToArray();
        }

        public string[] GetEntidadSingular(string prefix, string idioma, string codMuni)
        {
            List<string> entidades = new List<string>();
            OperacionesAlfaWS _OperacionesAlfaWS = new OperacionesAlfaWS(new ParametrosGDP()
            {
                usuario = WebConfigurationManager.AppSettings["GDPUsuario"],
                password = WebConfigurationManager.AppSettings["GDPPassword"],
                urlwsAlfaws = WebConfigurationManager.AppSettings["GDPAlfaws"]
            });
            if ((Convert.ToInt16(codMuni) == 0) || (codMuni == null))
            {
                AlfaWS.GDPClass resultadoES = _OperacionesAlfaWS.ObtenerEntidadesSingulares("%" + prefix.Trim() + "%", idioma.Trim());
                if (resultadoES.EntidadSingular != null)
                {
                    foreach (AlfaWS.EntidadSingular enti in resultadoES.EntidadSingular)
                    {
                        entidades.Add(string.Format("{0}#{1}", enti.CodEntSing, enti.DenomEntSing));
                    }
                }
            }
            else
            {
                AlfaWS.GDPClass resultadoES = _OperacionesAlfaWS.ObtenerEntidadesSingularesMuni(Convert.ToInt16(codMuni), "%" + prefix.Trim() + "%", idioma.Trim());
                if (resultadoES.EntidadSingular != null)
                {
                    foreach (AlfaWS.EntidadSingular enti in resultadoES.EntidadSingular)
                    {
                        entidades.Add(string.Format("{0}#{1}", enti.CodEntSing, enti.DenomEntSing));
                    }
                }
            }
            return entidades.ToArray();
        }

        public string[] GetVia(string prefix, string idioma, string codMuni, string codEnti)
        {
            List<string> vias = new List<string>();
            OperacionesAlfaWS _OperacionesAlfaWS = new OperacionesAlfaWS(new ParametrosGDP()
            {
                usuario = WebConfigurationManager.AppSettings["GDPUsuario"],
                password = WebConfigurationManager.AppSettings["GDPPassword"],
                urlwsAlfaws = WebConfigurationManager.AppSettings["GDPAlfaws"]
            });
            if (Convert.ToInt32(codEnti) > 0)
            {
                AlfaWS.GDPClass resultadoV = _OperacionesAlfaWS.ObtenerViasEntidadSingular(Convert.ToInt32(codEnti), "%" + prefix.Trim() + "%", idioma.Trim());
                if (resultadoV.Via != null)
                {
                    foreach (AlfaWS.Via via in resultadoV.Via)
                    {
                        vias.Add(string.Format("{0}#{1}", via.CodVia, via.DenomVia));
                    }
                }
            }
            else
            {
                AlfaWS.GDPClass resultadoV = _OperacionesAlfaWS.ObtenerViasMunicipios(Convert.ToInt16(codMuni), "%" + prefix.Trim() + "%", idioma.Trim());
                if (resultadoV.Via != null)
                {
                    foreach (AlfaWS.Via via in resultadoV.Via)
                    {
                        vias.Add(string.Format("{0}#{1}", via.CodVia, via.DenomVia));
                    }
                }
            }
            return vias.ToArray();
        }

        public string[] GetPortal(string prefix, string idioma, string codVia)
        {
            List<string> portales = new List<string>();
            OperacionesAlfaWS _OperacionesAlfaWS = new OperacionesAlfaWS(new ParametrosGDP()
            {
                usuario = WebConfigurationManager.AppSettings["GDPUsuario"],
                password = WebConfigurationManager.AppSettings["GDPPassword"],
                urlwsAlfaws = WebConfigurationManager.AppSettings["GDPAlfaws"]
            });
                AlfaWS.GDPClass resultadoP = _OperacionesAlfaWS.ObtenerPostales(Convert.ToInt32(codVia), null, idioma.Trim());
                if (resultadoP.NumPostal != null)
                {
                    foreach (AlfaWS.NumPostal portal in resultadoP.NumPostal)
                    {
                        portales.Add(string.Format("{0}#{1}", portal.CodPortal, portal.Numero));
                    }
                }
            return portales.ToArray();
        }

        public string[] GetCasa(string prefix, string idioma, string codEnti, string codVia)
        {
            List<string> portales = new List<string>();
            OperacionesAlfaWS _OperacionesAlfaWS = new OperacionesAlfaWS(new ParametrosGDP()
            {
                usuario = WebConfigurationManager.AppSettings["GDPUsuario"],
                password = WebConfigurationManager.AppSettings["GDPPassword"],
                urlwsAlfaws = WebConfigurationManager.AppSettings["GDPAlfaws"]
            });
            if (Convert.ToInt32(codVia) > 0)
            {
                AlfaWS.GDPClass resultadoP = _OperacionesAlfaWS.ObtenerPostalesViaNombreCasa(Convert.ToInt32(codVia), "%" + prefix.Trim() + "%", idioma.Trim());
                if (resultadoP.NumPostal != null)
                {
                    foreach (AlfaWS.NumPostal portal in resultadoP.NumPostal)
                    {
                        portales.Add(string.Format("{0}#{1}", portal.CodPortal, portal.NomCasa));
                    }
                }
            }
            else
            {
                AlfaWS.GDPClass resultadoP = _OperacionesAlfaWS.ObtenerPostalesEntidadNombreCasa(Convert.ToInt32(codEnti), "%" + prefix.Trim() + "%", idioma.Trim());
                if (resultadoP.NumPostal != null)
                {
                    foreach (AlfaWS.NumPostal portal in resultadoP.NumPostal)
                    {
                        portales.Add(string.Format("{0}#{1}", portal.CodPortal, portal.NomCasa));
                    }
                }
            }
            return portales.ToArray();
        }

        public string DatosPortal(string idioma, string codPortal)
        {
            Portal datosP = new Portal();
            string resp;
            OperacionesAlfaWS _OperacionesAlfaWS = new OperacionesAlfaWS(new ParametrosGDP()
            {
                usuario = WebConfigurationManager.AppSettings["GDPUsuario"],
                password = WebConfigurationManager.AppSettings["GDPPassword"],
                urlwsAlfaws = WebConfigurationManager.AppSettings["GDPAlfaws"]
            });

            AlfaWS.GDPClass resultado = _OperacionesAlfaWS.ObtenerPostalCodPortal(Convert.ToInt32(codPortal), idioma.Trim());
            datosP.codMun = resultado.Municipio[0].CodMun;
            datosP.denomMun = resultado.Municipio[0].DenomMun;
            datosP.codEntSing = resultado.EntidadSingular[0].CodEntSing;
            datosP.codEntINE = resultado.EntidadSingular[0].CodEntINE;
            datosP.denomEntSing = resultado.EntidadSingular[0].DenomEntSing;
            datosP.codVia = resultado.Via[0].CodVia;
            datosP.denomVia = resultado.Via[0].DenomVia;
            datosP.codPortal = resultado.NumPostal[0].CodPortal;
            datosP.Numero = resultado.NumPostal[0].Numero;
            datosP.NomCasa = resultado.NumPostal[0].NomCasa;
            datosP.codPostal = Convert.ToInt32(resultado.NumPostal[0].CodPostal);
            datosP.X_25830 = Convert.ToDecimal(resultado.NumPostal[0].X);
            datosP.Y_25830 = Convert.ToDecimal(resultado.NumPostal[0].Y);
            resp = string.Format("{0}#{1}#{2}#{3}#{4}#{5}#{6}#{7}#{8}#{9}#{10}#{11}#{12}", datosP.codMun, datosP.denomMun, datosP.codEntSing, datosP.codEntINE, datosP.denomEntSing, datosP.codVia, datosP.denomVia, datosP.codPortal, datosP.Numero, datosP.NomCasa, datosP.codPostal, datosP.X_25830, datosP.Y_25830);
            return resp.ToString();
        }

    }
}
