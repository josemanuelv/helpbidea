<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="gdpv2.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GDPv2</title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link rel="stylesheet" href="layout/bootstrap.min.css" media="screen" />
    <script src="./scripts/jquery.min.js"></script>
    <script src="./scripts/bootstrap.min.js"></script>
    <style>
        body { padding-top: 70px; }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-default navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="inicio.html">GDPv2</a>
            </div>
            <div class="collapse navbar-collapse" id="myNavbar">
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="index.aspx">Todos los métodos, uno a uno</a></li>
                    <li><a href="ejemplo.aspx">Ejemplo de uso</a></li>
                    <li><a href="#">Idioma:</a><asp:DropDownList ID="comboIdioma" runat="server" ToolTip="Selecciona el idioma" >
                                <asp:ListItem Selected="True">Castellano</asp:ListItem>
                                <asp:ListItem>Euskera</asp:ListItem>
                                </asp:DropDownList>
                    </li>
                </ul>
            </div>
        </div>
    </nav> 

    <div class="container-fluid text-left">
        <h2>Municipios</h2>
        Permite obtener la lista de municipios de Navarra según el nomenclátor oficial. Se obtienen los municipios cuyo nombre cumpla un patrón de búsqueda determinado. Si se introduce como patrón la cadena vacía se obtendrá la lista completa.
        <br /><br />
        Patrón (utilizar %):<asp:TextBox ID="TextBoxMunicipios" runat="server" style="margin-left: 16px"></asp:TextBox>
        <asp:Button ID="BtnMunicipios" runat="server" OnClick="BtnMunicipios_Click" Text="Buscar" />
        <asp:GridView ID="GridViewMunicipios" runat="server">
        </asp:GridView>
        
        <h2>EntidadesSingulares</h2>
        Permite obtener la lista de entidades singulares de Navarra según el nomenclátor oficial, indicando un patrón de búsqueda aplicable al nombre de la entidad singular. Si se introduce como patrón la cadena vacía se obtendrá la lista completa de entidades.
        <br /><br />
        Patrón (utilizar %):<asp:TextBox ID="TextBoxEntidades" runat="server"></asp:TextBox>
        <asp:Button ID="BtnEntidades" runat="server" OnClick="BtnEntidades_Click" Text="Buscar" />
        <asp:GridView ID="GridViewEntidadesM" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewEntidades" runat="server">
        </asp:GridView>
        

        <h2>EntidadesSingularesMuni</h2>
        Permite obtener la lista de entidades singulares de Navarra según el nomenclátor oficial, indicando además del municipio un patrón de búsqueda aplicable al nombre de la entidad singular. Si se introduce como patrón la cadena vacía se obtendrá la lista completa.
        <br /><br />
        Cod Municipio:<asp:TextBox ID="TextBoxEntidadesMuniMuni" runat="server"></asp:TextBox> Patrón (utilizar %):<asp:TextBox ID="TextBoxEntidadesMuni" runat="server"></asp:TextBox>
        <asp:Button ID="BtnEntidadesMuni" runat="server" OnClick="BtnEntidadesMuni_Click" Text="Buscar" /><asp:Label ID="lblAvisoESM" runat="server" Visible="False" ForeColor="#336600">Obligatorio el código de municipio</asp:Label>
        <asp:GridView ID="GridViewEntidadesMuniM" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewEntidadesMuni" runat="server">
        </asp:GridView>

        <h2>ViasMunicipios</h2>
        Permite obtener una lista de vías de un municipio que cumplan un determinado patrón aplicable al nombre de la vía. Si se introduce como patrón la cadena vacía se obtendrá la lista completa.
        <br /><br />
        Cod Municipio:<asp:TextBox ID="TextBoxViasMunicipiosMuni" runat="server"></asp:TextBox> Patrón (utilizar %):<asp:TextBox ID="TextBoxViasMunicipios" runat="server"></asp:TextBox>
        <asp:Button ID="BtnViasMunicipios" runat="server" OnClick="BtnViasMunicipios_Click" Text="Buscar" /><asp:Label ID="lblAvisoVM" runat="server" Visible="False" ForeColor="#336600">Obligatorio el código de municipio</asp:Label>
        <asp:GridView ID="GridViewViasMunicipiosM" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewViasMunicipiosES" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewViasMunicipios" runat="server">
        </asp:GridView>
        
        <h2>Via</h2>
        Permite obtener una vía dado su código.
        <br /><br />
        Código Via:<asp:TextBox ID="TextBoxVia" runat="server"></asp:TextBox>
        <asp:Button ID="BtnVia" runat="server" OnClick="BtnVia_Click" Text="Buscar" /><asp:Label ID="lblAvisoV" runat="server" Visible="False" ForeColor="#336600">Obligatorio el código de vía</asp:Label>
        <asp:GridView ID="GridViewViaM" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewViaES" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewVia" runat="server">
        </asp:GridView>

        <h2>ViasEntidadSingular</h2>
        Permite obtener una lista de vías de una entidad singular que cumplan un determinado patrón aplicable al nombre de la vía. Si se introduce como patrón la cadena vacía se obtendrá la lista completa.
        <br /><br />
        Cod Entidad Singular:<asp:TextBox ID="TextBoxViasEntidadSingularEnti" runat="server"></asp:TextBox> Patrón (utilizar %):<asp:TextBox ID="TextBoxViasEntidadSingular" runat="server"></asp:TextBox>
        <asp:Button ID="BtnViasEntidadSingular" runat="server" OnClick="BtnViasEntidadSingular_Click" Text="Buscar" /><asp:Label ID="lblAvisoVES" runat="server" Visible="False" ForeColor="#336600">Obligatorio el código de entidad singular</asp:Label>
        <asp:GridView ID="GridViewViasEntidadSingularM" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewViasEntidadSingularES" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewViasEntidadSingular" runat="server">
        </asp:GridView>

        <h2>ViasLocalidad</h2>
        Permite obtener una lista de vías de una entidad singular especificada mediante su denominación que cumplan un determinado patrón aplicable al nombre de la vía. Si se introduce como patrón la cadena vacía se obtendrá la lista completa.
        <br /><br />
        Nombre entidad singular (exacto):<asp:TextBox ID="TextBoxViasLocalidadLocal" runat="server"></asp:TextBox> Patrón vía (utilizar %):<asp:TextBox ID="TextBoxViasLocalidadVia" runat="server"></asp:TextBox>
        <asp:Button ID="BtnViasLocalidad" runat="server" OnClick="BtnViasLocalidad_Click" Text="Buscar" /><asp:Label ID="lblAvisoVL" runat="server" Visible="False" ForeColor="#336600">Obligatorio el nombre de entidad singular</asp:Label>
        <asp:GridView ID="GridViewViasLocalidadM" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewViasLocalidadES" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewViasLocalidad" runat="server">
        </asp:GridView>

        <h2>ViasNombreViaLocalidad</h2>
        Permite obtener una lista de vías (normalmente una) de una entidad singular mediante una comparación de igualdad tanto con el nombre de la entidad como con el de la vía. Además se tienen en cuenta otras posibles acepciones (no oficiales) en la denominación de la entidad singular (también por comparación de igualdad).
        <br /><br />
        Nombre entidad singular (exacto):<asp:TextBox ID="TextBoxViasNombreViaLocalidadEnti" runat="server"></asp:TextBox> nombre vía (exacto):<asp:TextBox ID="TextBoxViasNombreViaLocalidadVia" runat="server"></asp:TextBox>
        <asp:Button ID="BtnViasNombreViaLocalidad" runat="server" OnClick="BtnViasNombreViaLocalidad_Click" Text="Buscar" /><asp:Label ID="lblAvisoVNVL" runat="server" Visible="False" ForeColor="#336600">Obligatorios los dos parámetros</asp:Label>
        <asp:GridView ID="GridViewViasNombreViaLocalidadM" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewViasNombreViaLocalidadES" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewViasNombreViaLocalidad" runat="server">
        </asp:GridView>

        <h2>ViasNombreViaEntSingular</h2>
        Permite obtener una lista de vías (normalmente una) de una entidad singular mediante una comparación de igualdad con el nombre de la vía. En este caso la entidad singular queda determinada mediante códigos.
        <br /><br />
        Código entidad singular:<asp:TextBox ID="TextBoxViasNombreViaEntSingularEnti" runat="server"></asp:TextBox> nombre vía (exacto):<asp:TextBox ID="TextBoxViasNombreViaEntSingularVia" runat="server"></asp:TextBox>
        <asp:Button ID="BtnViasNombreViaEntSingular" runat="server" OnClick="BtnViasNombreViaEntSingular_Click" Text="Buscar" /><asp:Label ID="lblAvisoVNVES" runat="server" Visible="False" ForeColor="#336600">Obligatorios los dos parámetros</asp:Label>
        <asp:GridView ID="GridViewViasNombreViaEntSingularM" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewViasNombreViaEntSingularES" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewViasNombreViaEntSingular" runat="server">
        </asp:GridView>

        <h2>PostalCodPortal</h2>
        Permite obtener el número postal a partir de su código de portal.
        <br /><br />
        Código portal:<asp:TextBox ID="TextBoxPostalCodPortal" runat="server"></asp:TextBox>
        <asp:Button ID="BtnPostalCodPortal" runat="server" OnClick="BtnPostalCodPortal_Click" Text="Buscar" /><asp:Label ID="lblAvisoPCP" runat="server" Visible="False" ForeColor="#336600">Obligatorio el código de portal</asp:Label>
        <asp:GridView ID="GridViewPostalCodPortalM" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewPostalCodPortalES" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewPostalCodPortalV" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewPostalCodPortalP" runat="server">
        </asp:GridView>

        <h2>Postal</h2>
        Permite obtener la información correspondiente a un número postal del DDP a partir del identificador de vía y el número postal (pe: Si se solicita el número 12 y aunque en la vía existen los números 12 y 12-BIS, sólo se devolverá 12, es decir, el que cumple exactamente el criterio de búsqueda).
        <br /><br />
        Código vía:<asp:TextBox ID="TextBoxPostalVia" runat="server"></asp:TextBox> Número postal:<asp:TextBox ID="TextBoxPostalNum" runat="server"></asp:TextBox>
        <asp:Button ID="BtnPostal" runat="server" OnClick="BtnPostal_Click" Text="Buscar" /><asp:Label ID="lblAvisoPs" runat="server" Visible="False" ForeColor="#336600">Obligatorio el código de vía</asp:Label>
        <asp:GridView ID="GridViewPostalM" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewPostalESs" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewPostalV" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewPostal" runat="server">
        </asp:GridView>

        <h2>Postales</h2>
        Permite obtener una lista de números postales (direcciones postales horizontales) de una vía que sean iguales o contengan en alguna de sus partes el número solicitado (pe: Si se solicita el número 12 y en la vía existen los números 12 y 12-BIS, se devolverán los dos). Si se introduce como número postal la cadena vacía se obtendrá la lista completa.
        <br /><br />
        Código vía:<asp:TextBox ID="TextBoxPostalesVia" runat="server"></asp:TextBox> Número postal:<asp:TextBox ID="TextBoxPostalesNum" runat="server"></asp:TextBox>
        <asp:Button ID="BtnPostales" runat="server" OnClick="BtnPostales_Click" Text="Buscar" /><asp:Label ID="lblAvisoP" runat="server" Visible="False" ForeColor="#336600">Obligatorio el código de vía</asp:Label>
        <asp:GridView ID="GridViewPostalesM" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewPostalesES" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewPostalesV" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewPostales" runat="server">
        </asp:GridView>

        <h2>PostalesEntidadNombreCasa</h2>
        Permite obtener una lista de los números postales de la entidad singular cuyo nombre de casa cumpla el patrón proporcionado.
        <br /><br />
        Código entidad:<asp:TextBox ID="TextBoxPostalesEntidadNombreCasaEnti" runat="server"></asp:TextBox> Patrón casa (utilizar %):<asp:TextBox ID="TextBoxPostalesEntidadNombreCasaCasa" runat="server"></asp:TextBox>
        <asp:Button ID="BtnPostalesEntidadNombreCasa" runat="server" OnClick="BtnPostalesEntidadNombreCasa_Click" Text="Buscar" /><asp:Label ID="lblAvisoPENC" runat="server" Visible="False" ForeColor="#336600">Obligatorio el código de entidad y patrón casa</asp:Label>
        <asp:GridView ID="GridViewPostalesEntidadNombreCasaM" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewPostalesEntidadNombreCasaES" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewPostalesEntidadNombreCasaV" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewPostalesEntidadNombreCasaP" runat="server">
        </asp:GridView>

        <h2>PostalesViaNombreCasa</h2>
        Permite obtener una lista de los números postales de la vía cuyo nombre de casa cumpla el patrón proporcionado.
        <br /><br />
        Código vía:<asp:TextBox ID="TextBoxPostalesViaNombreCasaVia" runat="server"></asp:TextBox> Patrón casa (utilizar %):<asp:TextBox ID="TextBoxPostalesViaNombreCasaCasa" runat="server"></asp:TextBox>
        <asp:Button ID="BtnPostalesViaNombreCasa" runat="server" OnClick="BtnPostalesViaNombreCasa_Click" Text="Buscar" /><asp:Label ID="lblAvisoPVNC" runat="server" Visible="False" ForeColor="#336600">Obligatorio el código de vía y patrón casa</asp:Label>
        <asp:GridView ID="GridViewPostalesViaNombreCasaM" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewPostalesViaNombreCasaES" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewPostalesViaNombreCasaV" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewPostalesViaNombreCasaP" runat="server">
        </asp:GridView>

        <h2>PostalesNombreLocalidad</h2>
        Permite obtener una lista de los números postales que sean iguales o contengan en alguna de sus partes el número solicitado (pe: Si se solicita el número 12 y en la vía existen los números 12 y 12-BIS, se devolverán los dos) de aquellas vías de una entidad singular obtenidas mediante una comparación de igualdad tanto con el nombre de la entidad como con el de la vía. Además se tienen en cuenta otras posibles acepciones (no oficiales) en la denominación de la entidad singular (también por comparación de igualdad). Si se introduce como número postal la cadena vacía se obtendrá la lista completa.
        <br /><br />
        Nombre entidad singular (exacto):<asp:TextBox ID="TextBoxPostalesNombreLocalidadEnti" runat="server"></asp:TextBox> Nombre vía (exacto):<asp:TextBox ID="TextBoxPostalesNombreLocalidadVia" runat="server"></asp:TextBox> Número postal:<asp:TextBox ID="TextBoxPostalesNombreLocalidadNum" runat="server"></asp:TextBox>
        <asp:Button ID="BtnPostalesNombreLocalidad" runat="server" OnClick="BtnPostalesNombreLocalidad_Click" Text="Buscar" /><asp:Label ID="lblAvisoPNL" runat="server" Visible="False" ForeColor="#336600">Obligatorios entidad singular y vía</asp:Label>
        <asp:GridView ID="GridViewPostalesNombreLocalidadM" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewPostalesNombreLocalidadES" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewPostalesNombreLocalidadV" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewPostalesNombreLocalidad" runat="server">
        </asp:GridView>

        <h2>PostalesNombreEntidadSingular</h2>
        Permite obtener una lista de los números postales que sean iguales o contengan en alguna de sus partes el número solicitado (pe: Si se solicita el número 12 y en la vía existen los números 12 y 12-BIS, se devolverán los dos) de aquellas vías de una entidad singular obtenidas mediante una comparación de igualdad con el nombre de la vía, quedando la entidad singular determinada mediante códigos. Si se introduce como número postal la cadena vacía se obtendrá la lista completa.
        <br /><br />
        Código entidad singular:<asp:TextBox ID="TextBoxPostalesNombreEntidadSingularEnti" runat="server"></asp:TextBox> Nombre vía (exacto):<asp:TextBox ID="TextBoxPostalesNombreEntidadSingularVia" runat="server"></asp:TextBox> Número postal:<asp:TextBox ID="TextBoxPostalesNombreEntidadSingularNum" runat="server"></asp:TextBox>
        <asp:Button ID="BtnPostalesNombreEntidadSingular" runat="server" OnClick="BtnPostalesNombreEntidadSingular_Click" Text="Buscar" /><asp:Label ID="lblAvisoPNES" runat="server" Visible="False" ForeColor="#336600">Obligatorios entidad singular y vía</asp:Label>
        <asp:GridView ID="GridViewPostalesNombreEntidadSingularM" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewPostalesNombreEntidadSingularES" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewPostalesNombreEntidadSingularV" runat="server">
        </asp:GridView>
        <asp:GridView ID="GridViewPostalesNombreEntidadSingular" runat="server">
        </asp:GridView>
      </div>
    </form>
</body>
</html>
