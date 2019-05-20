using gdpv2.AlfaWS;
using gdpv2.Entidades;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Web;

namespace gdpv2.Implementacion
{
    public class OperacionesAlfaWS
    {
        private ParametrosGDP _parametros;

        public OperacionesAlfaWS(ParametrosGDP parametros)
        {
            _parametros = parametros;
        }
        
        public static bool ValidateServerCertificate(Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        public GDPClass ObtenerEntidadesSingulares(string filtroEntidad,string idiomaCombo)
        {
            AlfaWS.AlfaWS Alfaws = new AlfaWS.AlfaWS();
            Idioma idioma = new Idioma();
            if (idiomaCombo == "Castellano")
            {
                idioma = AlfaWS.Idioma.Castellano;
            }
            else
            {
                idioma = AlfaWS.Idioma.Euskera;
            }
            NetworkCredential Credenciales = new NetworkCredential();

            //Definimos las credenciales:
            Credenciales = new NetworkCredential();
            Credenciales.UserName = _parametros.usuario;
            Credenciales.Password = _parametros.password;

            //Alfaws.Url = _parametros.urlwsAlfaws;
            Alfaws.Credentials = Credenciales;	//Asignamos credenciales.
            Alfaws.Proxy = new WebProxy(); //Se crea un nuevo proxi para acceder al servicio web directamente (más rápido).
            Alfaws.PreAuthenticate = true;	//Confirma que la autentificación va a realizarse correctamente para evitar una comprobación redundante (más eficiencia)

            //no validar el certificado ssl
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
            CredentialCache cache = new CredentialCache();

            var resultado = Alfaws.EntidadesSingulares(filtroEntidad, idioma);
            return resultado;

        }

        public GDPClass ObtenerMunicipios(string filtroMunicipio, string idiomaCombo)
        {
            AlfaWS.AlfaWS Alfaws = new AlfaWS.AlfaWS();
            Idioma idioma = new Idioma();
            if (idiomaCombo == "Castellano")
            {
                idioma = AlfaWS.Idioma.Castellano;
            }
            else
            {
                idioma = AlfaWS.Idioma.Euskera;
            }
            NetworkCredential Credenciales = new NetworkCredential();

            //Definimos las credenciales:
            Credenciales = new NetworkCredential();
            Credenciales.UserName = _parametros.usuario;
            Credenciales.Password = _parametros.password;

            //Alfaws.Url = _parametros.urlwsAlfaws;
            Alfaws.Credentials = Credenciales;	//Asignamos credenciales.
            Alfaws.Proxy = new WebProxy(); //Se crea un nuevo proxi para acceder al servicio web directamente (más rápido).
            Alfaws.PreAuthenticate = true;	//Confirma que la autentificación va a realizarse correctamente para evitar una comprobación redundante (más eficiencia)

            //no validar el certificado ssl
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
            CredentialCache cache = new CredentialCache();

            var resultado = Alfaws.Municipios(filtroMunicipio, idioma);
            return resultado;
        }

        public GDPClass ObtenerEntidadesSingularesMuni(short filtroMuni, string filtroEntidad, string idiomaCombo)
        {
            AlfaWS.AlfaWS Alfaws = new AlfaWS.AlfaWS();
            Idioma idioma = new Idioma();
            if (idiomaCombo == "Castellano")
            {
                idioma = AlfaWS.Idioma.Castellano;
            }
            else
            {
                idioma = AlfaWS.Idioma.Euskera;
            }
            NetworkCredential Credenciales = new NetworkCredential();

            //Definimos las credenciales:
            Credenciales = new NetworkCredential();
            Credenciales.UserName = _parametros.usuario;
            Credenciales.Password = _parametros.password;

            //Alfaws.Url = _parametros.urlwsAlfaws;
            Alfaws.Credentials = Credenciales;	//Asignamos credenciales.
            Alfaws.Proxy = new WebProxy(); //Se crea un nuevo proxi para acceder al servicio web directamente (más rápido).
            Alfaws.PreAuthenticate = true;	//Confirma que la autentificación va a realizarse correctamente para evitar una comprobación redundante (más eficiencia)

            //no validar el certificado ssl
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
            CredentialCache cache = new CredentialCache();

            var resultado = Alfaws.EntidadesSingularesMuni(filtroMuni, filtroEntidad, idioma);
            return resultado;

        }

        public GDPClass ObtenerViasMunicipios(short filtroMuni, string filtroVia, string idiomaCombo)
        {
            AlfaWS.AlfaWS Alfaws = new AlfaWS.AlfaWS();
            Idioma idioma = new Idioma();
            if (idiomaCombo == "Castellano")
            {
                idioma = AlfaWS.Idioma.Castellano;
            }
            else
            {
                idioma = AlfaWS.Idioma.Euskera;
            }
            NetworkCredential Credenciales = new NetworkCredential();

            //Definimos las credenciales:
            Credenciales = new NetworkCredential();
            Credenciales.UserName = _parametros.usuario;
            Credenciales.Password = _parametros.password;

            //Alfaws.Url = _parametros.urlwsAlfaws;
            Alfaws.Credentials = Credenciales;	//Asignamos credenciales.
            Alfaws.Proxy = new WebProxy(); //Se crea un nuevo proxi para acceder al servicio web directamente (más rápido).
            Alfaws.PreAuthenticate = true;	//Confirma que la autentificación va a realizarse correctamente para evitar una comprobación redundante (más eficiencia)

            //no validar el certificado ssl
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
            CredentialCache cache = new CredentialCache();

            var resultado = Alfaws.ViasMunicipios(filtroMuni, filtroVia, idioma);
            return resultado;

        }

        public GDPClass ObtenerViasEntidadSingular(int filtroEnti, string filtroVia, string idiomaCombo)
        {
            AlfaWS.AlfaWS Alfaws = new AlfaWS.AlfaWS();
            Idioma idioma = new Idioma();
            if (idiomaCombo == "Castellano")
            {
                idioma = AlfaWS.Idioma.Castellano;
            }
            else
            {
                idioma = AlfaWS.Idioma.Euskera;
            }
            NetworkCredential Credenciales = new NetworkCredential();

            //Definimos las credenciales:
            Credenciales = new NetworkCredential();
            Credenciales.UserName = _parametros.usuario;
            Credenciales.Password = _parametros.password;

            //Alfaws.Url = _parametros.urlwsAlfaws;
            Alfaws.Credentials = Credenciales;	//Asignamos credenciales.
            Alfaws.Proxy = new WebProxy(); //Se crea un nuevo proxi para acceder al servicio web directamente (más rápido).
            Alfaws.PreAuthenticate = true;	//Confirma que la autentificación va a realizarse correctamente para evitar una comprobación redundante (más eficiencia)

            //no validar el certificado ssl
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
            CredentialCache cache = new CredentialCache();

            var resultado = Alfaws.ViasEntidadSingular(filtroEnti, filtroVia, idioma);
            return resultado;
        }

        public GDPClass ObtenerVia(int filtroVia, string idiomaCombo)
        {
            AlfaWS.AlfaWS Alfaws = new AlfaWS.AlfaWS();
            Idioma idioma = new Idioma();
            if (idiomaCombo == "Castellano")
            {
                idioma = AlfaWS.Idioma.Castellano;
            }
            else
            {
                idioma = AlfaWS.Idioma.Euskera;
            }
            NetworkCredential Credenciales = new NetworkCredential();

            //Definimos las credenciales:
            Credenciales = new NetworkCredential();
            Credenciales.UserName = _parametros.usuario;
            Credenciales.Password = _parametros.password;

            //Alfaws.Url = _parametros.urlwsAlfaws;
            Alfaws.Credentials = Credenciales;	//Asignamos credenciales.
            Alfaws.Proxy = new WebProxy(); //Se crea un nuevo proxi para acceder al servicio web directamente (más rápido).
            Alfaws.PreAuthenticate = true;	//Confirma que la autentificación va a realizarse correctamente para evitar una comprobación redundante (más eficiencia)

            //no validar el certificado ssl
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
            CredentialCache cache = new CredentialCache();

            var resultado = Alfaws.Via(filtroVia, idioma);
            return resultado;
        }

        public GDPClass ObtenerViasLocalidad(string filtroLocalidad, string filtroVia, string idiomaCombo)
        {
            AlfaWS.AlfaWS Alfaws = new AlfaWS.AlfaWS();
            Idioma idioma = new Idioma();
            if (idiomaCombo == "Castellano")
            {
                idioma = AlfaWS.Idioma.Castellano;
            }
            else
            {
                idioma = AlfaWS.Idioma.Euskera;
            }
            NetworkCredential Credenciales = new NetworkCredential();

            //Definimos las credenciales:
            Credenciales = new NetworkCredential();
            Credenciales.UserName = _parametros.usuario;
            Credenciales.Password = _parametros.password;

            //Alfaws.Url = _parametros.urlwsAlfaws;
            Alfaws.Credentials = Credenciales;	//Asignamos credenciales.
            Alfaws.Proxy = new WebProxy(); //Se crea un nuevo proxi para acceder al servicio web directamente (más rápido).
            Alfaws.PreAuthenticate = true;	//Confirma que la autentificación va a realizarse correctamente para evitar una comprobación redundante (más eficiencia)

            //no validar el certificado ssl
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
            CredentialCache cache = new CredentialCache();

            var resultado = Alfaws.ViasLocalidad(filtroLocalidad, filtroVia, idioma);
            return resultado;
        }

        public GDPClass ObtenerViasNombreViaLocalidad(string filtroEnti, string filtroVia, string idiomaCombo)
        {
            AlfaWS.AlfaWS Alfaws = new AlfaWS.AlfaWS();
            Idioma idioma = new Idioma();
            if (idiomaCombo == "Castellano")
            {
                idioma = AlfaWS.Idioma.Castellano;
            }
            else
            {
                idioma = AlfaWS.Idioma.Euskera;
            }
            NetworkCredential Credenciales = new NetworkCredential();

            //Definimos las credenciales:
            Credenciales = new NetworkCredential();
            Credenciales.UserName = _parametros.usuario;
            Credenciales.Password = _parametros.password;

            //Alfaws.Url = _parametros.urlwsAlfaws;
            Alfaws.Credentials = Credenciales;	//Asignamos credenciales.
            Alfaws.Proxy = new WebProxy(); //Se crea un nuevo proxi para acceder al servicio web directamente (más rápido).
            Alfaws.PreAuthenticate = true;	//Confirma que la autentificación va a realizarse correctamente para evitar una comprobación redundante (más eficiencia)

            //no validar el certificado ssl
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
            CredentialCache cache = new CredentialCache();

            var resultado = Alfaws.ViasNombreViaLocalidad(filtroEnti, filtroVia, idioma);
            return resultado;
        }

        public GDPClass ObtenerViasNombreViaEntSingular(int filtroEnti, string filtroVia, string idiomaCombo)
        {
            AlfaWS.AlfaWS Alfaws = new AlfaWS.AlfaWS();
            Idioma idioma = new Idioma();
            if (idiomaCombo == "Castellano")
            {
                idioma = AlfaWS.Idioma.Castellano;
            }
            else
            {
                idioma = AlfaWS.Idioma.Euskera;
            }
            NetworkCredential Credenciales = new NetworkCredential();

            //Definimos las credenciales:
            Credenciales = new NetworkCredential();
            Credenciales.UserName = _parametros.usuario;
            Credenciales.Password = _parametros.password;

            //Alfaws.Url = _parametros.urlwsAlfaws;
            Alfaws.Credentials = Credenciales;	//Asignamos credenciales.
            Alfaws.Proxy = new WebProxy(); //Se crea un nuevo proxi para acceder al servicio web directamente (más rápido).
            Alfaws.PreAuthenticate = true;	//Confirma que la autentificación va a realizarse correctamente para evitar una comprobación redundante (más eficiencia)

            //no validar el certificado ssl
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
            CredentialCache cache = new CredentialCache();

            var resultado = Alfaws.ViasNombreViaEntSingular(filtroEnti, filtroVia, idioma);
            return resultado;
        }

        public GDPClass ObtenerPostalCodPortal(int filtroPortal, string idiomaCombo)
        {
            AlfaWS.AlfaWS Alfaws = new AlfaWS.AlfaWS();
            Idioma idioma = new Idioma();
            if (idiomaCombo == "Castellano")
            {
                idioma = AlfaWS.Idioma.Castellano;
            }
            else
            {
                idioma = AlfaWS.Idioma.Euskera;
            }
            NetworkCredential Credenciales = new NetworkCredential();

            //Definimos las credenciales:
            Credenciales = new NetworkCredential();
            Credenciales.UserName = _parametros.usuario;
            Credenciales.Password = _parametros.password;

            //Alfaws.Url = _parametros.urlwsAlfaws;
            Alfaws.Credentials = Credenciales;	//Asignamos credenciales.
            Alfaws.Proxy = new WebProxy(); //Se crea un nuevo proxi para acceder al servicio web directamente (más rápido).
            Alfaws.PreAuthenticate = true;	//Confirma que la autentificación va a realizarse correctamente para evitar una comprobación redundante (más eficiencia)

            //no validar el certificado ssl
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
            CredentialCache cache = new CredentialCache();

            var resultado = Alfaws.PostalCodPortal(filtroPortal, idioma);
            return resultado;
        }

        public GDPClass ObtenerPostalesEntidadNombreCasa(int filtroEnti, string filtroCasa, string idiomaCombo)
        {
            AlfaWS.AlfaWS Alfaws = new AlfaWS.AlfaWS();
            Idioma idioma = new Idioma();
            if (idiomaCombo == "Castellano")
            {
                idioma = AlfaWS.Idioma.Castellano;
            }
            else
            {
                idioma = AlfaWS.Idioma.Euskera;
            }
            NetworkCredential Credenciales = new NetworkCredential();

            //Definimos las credenciales:
            Credenciales = new NetworkCredential();
            Credenciales.UserName = _parametros.usuario;
            Credenciales.Password = _parametros.password;

            //Alfaws.Url = _parametros.urlwsAlfaws;
            Alfaws.Credentials = Credenciales;	//Asignamos credenciales.
            Alfaws.Proxy = new WebProxy(); //Se crea un nuevo proxi para acceder al servicio web directamente (más rápido).
            Alfaws.PreAuthenticate = true;	//Confirma que la autentificación va a realizarse correctamente para evitar una comprobación redundante (más eficiencia)

            //no validar el certificado ssl
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
            CredentialCache cache = new CredentialCache();

            var resultado = Alfaws.PostalesEntidadNombreCasa(filtroEnti, filtroCasa, idioma);
            return resultado;
        }

        public GDPClass ObtenerPostalesViaNombreCasa(int filtroVia, string filtroCasa, string idiomaCombo)
        {
            AlfaWS.AlfaWS Alfaws = new AlfaWS.AlfaWS();
            Idioma idioma = new Idioma();
            if (idiomaCombo == "Castellano")
            {
                idioma = AlfaWS.Idioma.Castellano;
            }
            else
            {
                idioma = AlfaWS.Idioma.Euskera;
            }
            NetworkCredential Credenciales = new NetworkCredential();

            //Definimos las credenciales:
            Credenciales = new NetworkCredential();
            Credenciales.UserName = _parametros.usuario;
            Credenciales.Password = _parametros.password;

            //Alfaws.Url = _parametros.urlwsAlfaws;
            Alfaws.Credentials = Credenciales;	//Asignamos credenciales.
            Alfaws.Proxy = new WebProxy(); //Se crea un nuevo proxi para acceder al servicio web directamente (más rápido).
            Alfaws.PreAuthenticate = true;	//Confirma que la autentificación va a realizarse correctamente para evitar una comprobación redundante (más eficiencia)

            //no validar el certificado ssl
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
            CredentialCache cache = new CredentialCache();

            var resultado = Alfaws.PostalesViaNombreCasa(filtroVia, filtroCasa, idioma);
            return resultado;
        }


        public GDPClass ObtenerPostales(int filtroVia, string filtroNum, string idiomaCombo)
        {
            AlfaWS.AlfaWS Alfaws = new AlfaWS.AlfaWS();
            Idioma idioma = new Idioma();
            if (idiomaCombo == "Castellano")
            {
                idioma = AlfaWS.Idioma.Castellano;
            }
            else
            {
                idioma = AlfaWS.Idioma.Euskera;
            }
            NetworkCredential Credenciales = new NetworkCredential();

            //Definimos las credenciales:
            Credenciales = new NetworkCredential();
            Credenciales.UserName = _parametros.usuario;
            Credenciales.Password = _parametros.password;

            //Alfaws.Url = _parametros.urlwsAlfaws;
            Alfaws.Credentials = Credenciales;	//Asignamos credenciales.
            Alfaws.Proxy = new WebProxy(); //Se crea un nuevo proxi para acceder al servicio web directamente (más rápido).
            Alfaws.PreAuthenticate = true;	//Confirma que la autentificación va a realizarse correctamente para evitar una comprobación redundante (más eficiencia)

            //no validar el certificado ssl
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
            CredentialCache cache = new CredentialCache();

            var resultado = Alfaws.Postales(filtroVia, filtroNum, idioma);
            return resultado;
        }

        public GDPClass ObtenerPostal(int filtroVia, string filtroNum, string idiomaCombo)
        {
            AlfaWS.AlfaWS Alfaws = new AlfaWS.AlfaWS();
            Idioma idioma = new Idioma();
            if (idiomaCombo == "Castellano")
            {
                idioma = AlfaWS.Idioma.Castellano;
            }
            else
            {
                idioma = AlfaWS.Idioma.Euskera;
            }
            NetworkCredential Credenciales = new NetworkCredential();

            //Definimos las credenciales:
            Credenciales = new NetworkCredential();
            Credenciales.UserName = _parametros.usuario;
            Credenciales.Password = _parametros.password;

            //Alfaws.Url = _parametros.urlwsAlfaws;
            Alfaws.Credentials = Credenciales;	//Asignamos credenciales.
            Alfaws.Proxy = new WebProxy(); //Se crea un nuevo proxi para acceder al servicio web directamente (más rápido).
            Alfaws.PreAuthenticate = true;	//Confirma que la autentificación va a realizarse correctamente para evitar una comprobación redundante (más eficiencia)

            //no validar el certificado ssl
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
            CredentialCache cache = new CredentialCache();

            var resultado = Alfaws.Postal(filtroVia, filtroNum, idioma);
            return resultado;
        }

        public GDPClass ObtenerPostalesNombreLocalidad(string filtroEnti, string filtroVia, string filtroNum, string idiomaCombo)
        {
            AlfaWS.AlfaWS Alfaws = new AlfaWS.AlfaWS();
            Idioma idioma = new Idioma();
            if (idiomaCombo == "Castellano")
            {
                idioma = AlfaWS.Idioma.Castellano;
            }
            else
            {
                idioma = AlfaWS.Idioma.Euskera;
            }
            NetworkCredential Credenciales = new NetworkCredential();

            //Definimos las credenciales:
            Credenciales = new NetworkCredential();
            Credenciales.UserName = _parametros.usuario;
            Credenciales.Password = _parametros.password;

            //Alfaws.Url = _parametros.urlwsAlfaws;
            Alfaws.Credentials = Credenciales;	//Asignamos credenciales.
            Alfaws.Proxy = new WebProxy(); //Se crea un nuevo proxi para acceder al servicio web directamente (más rápido).
            Alfaws.PreAuthenticate = true;	//Confirma que la autentificación va a realizarse correctamente para evitar una comprobación redundante (más eficiencia)

            //no validar el certificado ssl
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
            CredentialCache cache = new CredentialCache();

            var resultado = Alfaws.PostalesNombreLocalidad(filtroEnti, filtroVia, filtroNum, idioma);
            return resultado;
        }

        public GDPClass ObtenerPostalesNombreEntidadSingular(int filtroEnti, string filtroVia, string filtroNum, string idiomaCombo)
        {
            AlfaWS.AlfaWS Alfaws = new AlfaWS.AlfaWS();
            Idioma idioma = new Idioma();
            if (idiomaCombo == "Castellano")
            {
                idioma = AlfaWS.Idioma.Castellano;
            }
            else
            {
                idioma = AlfaWS.Idioma.Euskera;
            }
            NetworkCredential Credenciales = new NetworkCredential();

            //Definimos las credenciales:
            Credenciales = new NetworkCredential();
            Credenciales.UserName = _parametros.usuario;
            Credenciales.Password = _parametros.password;

            //Alfaws.Url = _parametros.urlwsAlfaws;
            Alfaws.Credentials = Credenciales;	//Asignamos credenciales.
            Alfaws.Proxy = new WebProxy(); //Se crea un nuevo proxi para acceder al servicio web directamente (más rápido).
            Alfaws.PreAuthenticate = true;	//Confirma que la autentificación va a realizarse correctamente para evitar una comprobación redundante (más eficiencia)

            //no validar el certificado ssl
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidateServerCertificate);
            CredentialCache cache = new CredentialCache();

            var resultado = Alfaws.PostalesNombreEntidadSingular(filtroEnti, filtroVia, filtroNum, idioma);
            return resultado;
        }


    }
}