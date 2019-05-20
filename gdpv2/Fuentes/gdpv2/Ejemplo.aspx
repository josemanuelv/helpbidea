<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejemplo.aspx.cs" Inherits="gdpv2.Ejemplo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GDPv2</title>
    <meta charset="utf-8"/>
<!--    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" media="screen"/>
    <link rel="stylesheet" href="http://sitna.navarra.es/api/TC/css/bootstrap-adapter.css" media="screen"/>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="./scripts/servicio.js"></script>
    <script type="text/javascript" src="http://cdn.rawgit.com/bassjobsen/Bootstrap-3-Typeahead/master/bootstrap3-typeahead.min.js"></script>
    <link rel="Stylesheet" href="https://twitter.github.io/typeahead.js/css/examples.css"/>
-->


    <link rel="Stylesheet" href="layout/examplesTA.css"/>
    <link rel="Stylesheet" href="layout/estilo.css"/>
    <script src="//sitna.tracasa.es/api/dev/" type="text/javascript"></script>
    <script src="./scripts/pintamapa.js"></script>
    <link rel="stylesheet" href="layout/bootstrap.min.css" media="screen"/>
    <script src="./scripts/jquery.min.js"></script>
    <script src="./scripts/bootstrap.min.js"></script>
    <script src="./scripts/servicio.js"></script>
    <script type="text/javascript" src="./scripts/bootstrap3-typeahead.min.js"></script>
    <script src="//sitna.tracasa.es/api/" type="text/javascript"></script>
    <link rel="stylesheet" href="layout/bootstrap-adapter.css" media="screen"/>



     <style>
        body { padding-top: 70px; padding-bottom: 20px;}
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
        <div class="row">
            <div class="col-md-1"> Municipio: </div>
            <div class="col-md-1"><asp:TextBox ID="txtSearchMunicipio" runat="server" CssClass="form-control" Width="300"/>
            <asp:HiddenField ID="hfMunicipio" runat="server" Value="0" />  </div>  
        </div>
        <div class="row">
            <div class="col-md-1"> Ent.Singular: </div>
            <div class="col-md-1"><asp:TextBox ID="txtSearchEntidadSingular" runat="server" CssClass="form-control" Width="300"/>
            <asp:HiddenField ID="hfEntidadSingular" runat="server" Value="0" />  </div>  
        </div>
        <div class="row">
            <div class="col-md-1"> Vía: </div>
            <div class="col-md-1"><asp:TextBox ID="txtSearchVia" runat="server" CssClass="form-control" Width="300"/>
            <asp:HiddenField ID="hfVia" runat="server" Value="0" />  </div>  
        </div>
        <div class="row">
            <div class="col-md-1"> Portal: </div>
            <div class="col-md-1"><asp:TextBox ID="txtSearchPortal" runat="server" CssClass="form-control" Width="300"/>
            <asp:HiddenField ID="hfPortal" runat="server" Value="0" />  </div>  
        </div>
        <div class="row">
            <div class="col-md-1"> Nombre casa: </div>
            <div class="col-md-1"><asp:TextBox ID="txtSearchCasa" runat="server" CssClass="form-control" Width="300"/></div>
        </div>  
        <div class="row">
            <div class="col-md-4"><asp:TextBox ID="TextBoxResultado" runat="server" CssClass="form-control" Width="800"/>
            </div>  
        </div>
    </div>
    <div>
        <div>
            <div id="mapa">
    <script>
        var map = new SITNA.Map("mapa");
    </script>
            </div>
        </div>
    </div>
<!--    <div class="container" id="mapa" CssClass="embed-responsive" Width="800">
    </div> -->

    </form>
</body>
</html>
