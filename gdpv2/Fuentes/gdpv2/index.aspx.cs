using gdpv2.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using gdpv2.Implementacion;
using System.Web.Configuration;
using System.Collections;
using System.Data;

namespace gdpv2
{
    public partial class index : System.Web.UI.Page
    {
        private ParametrosGDP _ParametrosGDP;
        private OperacionesAlfaWS _OperacionesAlfaWS;

        protected void Page_Load(object sender, EventArgs e)
        {
            _ParametrosGDP = new ParametrosGDP() { 
                usuario = WebConfigurationManager.AppSettings["GDPUsuario"],
                password = WebConfigurationManager.AppSettings["GDPPassword"],
                urlwsAlfaws = WebConfigurationManager.AppSettings["GDPAlfaws"]
            };
            _OperacionesAlfaWS = new OperacionesAlfaWS(_ParametrosGDP);
        }

        protected void BtnEntidades_Click(object sender, EventArgs e)
        {
            AlfaWS.GDPClass resultadoES = _OperacionesAlfaWS.ObtenerEntidadesSingulares(this.TextBoxEntidades.Text, this.comboIdioma.SelectedItem.Text);
            GridViewEntidadesM.DataSource = resultadoES.Municipio;
            GridViewEntidadesM.DataBind();
            GridViewEntidades.DataSource = resultadoES.EntidadSingular;
            GridViewEntidades.DataBind();
            this.TextBoxEntidades.Focus();
        }

        protected void BtnMunicipios_Click(object sender, EventArgs e)
        {
            AlfaWS.GDPClass resultadoM = _OperacionesAlfaWS.ObtenerMunicipios(this.TextBoxMunicipios.Text, this.comboIdioma.SelectedItem.Text);
            GridViewMunicipios.DataSource = resultadoM.Municipio;
            GridViewMunicipios.DataBind();
            this.TextBoxMunicipios.Focus();
        }

        protected void BtnEntidadesMuni_Click(object sender, EventArgs e)
        {
            if (this.TextBoxEntidadesMuniMuni.Text.Length > 0)
            {
                this.lblAvisoESM.Visible = false;
                AlfaWS.GDPClass resultadoESM = _OperacionesAlfaWS.ObtenerEntidadesSingularesMuni(Convert.ToInt16(this.TextBoxEntidadesMuniMuni.Text), this.TextBoxEntidadesMuni.Text, this.comboIdioma.SelectedItem.Text);
                GridViewEntidadesMuniM.DataSource = resultadoESM.Municipio;
                GridViewEntidadesMuniM.DataBind();
                GridViewEntidadesMuni.DataSource = resultadoESM.EntidadSingular;
                GridViewEntidadesMuni.DataBind();
            }
            else 
            {
                this.lblAvisoESM.Visible = true;
            }
            this.TextBoxEntidadesMuniMuni.Focus();
        }

        protected void BtnViasMunicipios_Click(object sender, EventArgs e)
        {
            if (this.TextBoxViasMunicipiosMuni.Text.Length > 0)
            {
                this.lblAvisoVM.Visible = false;
                AlfaWS.GDPClass resultadoVM = _OperacionesAlfaWS.ObtenerViasMunicipios(Convert.ToInt16(this.TextBoxViasMunicipiosMuni.Text), this.TextBoxViasMunicipios.Text, this.comboIdioma.SelectedItem.Text);
                GridViewViasMunicipiosM.DataSource = resultadoVM.Municipio;
                GridViewViasMunicipiosM.DataBind();
                GridViewViasMunicipiosES.DataSource = resultadoVM.EntidadSingular;
                GridViewViasMunicipiosES.DataBind();
                GridViewViasMunicipios.DataSource = resultadoVM.Via;
                GridViewViasMunicipios.DataBind();
            }
            else
            {
                this.lblAvisoVM.Visible = true;
            }
            this.TextBoxViasMunicipiosMuni.Focus();
        }

        protected void BtnViasEntidadSingular_Click(object sender, EventArgs e)
        {
            if (this.TextBoxViasEntidadSingularEnti.Text.Length > 0)
            {
                this.lblAvisoVES.Visible = false;
                AlfaWS.GDPClass resultadoVES = _OperacionesAlfaWS.ObtenerViasEntidadSingular(Convert.ToInt32(this.TextBoxViasEntidadSingularEnti.Text), this.TextBoxViasEntidadSingular.Text, this.comboIdioma.SelectedItem.Text);
                GridViewViasEntidadSingularM.DataSource = resultadoVES.Municipio;
                GridViewViasEntidadSingularM.DataBind();
                GridViewViasEntidadSingularES.DataSource = resultadoVES.EntidadSingular;
                GridViewViasEntidadSingularES.DataBind();
                GridViewViasEntidadSingular.DataSource = resultadoVES.Via;
                GridViewViasEntidadSingular.DataBind();
            }
            else
            {
                this.lblAvisoVES.Visible = true;
            }
            this.TextBoxViasNombreViaEntSingularEnti.Focus();
        }

        protected void BtnVia_Click(object sender, EventArgs e)
        {
            if (this.TextBoxVia.Text.Length > 0)
            {
                this.lblAvisoV.Visible = false;
                AlfaWS.GDPClass resultadoV = _OperacionesAlfaWS.ObtenerVia(Convert.ToInt32(this.TextBoxVia.Text), this.comboIdioma.SelectedItem.Text);
                GridViewViaM.DataSource = resultadoV.Municipio;
                GridViewViaM.DataBind();
                GridViewViaES.DataSource = resultadoV.EntidadSingular;
                GridViewViaES.DataBind();
                GridViewVia.DataSource = resultadoV.Via;
                GridViewVia.DataBind();
            }
            else
            {
                this.lblAvisoV.Visible = true;
            }
            this.TextBoxVia.Focus();
        }
        
        protected void BtnViasLocalidad_Click(object sender, EventArgs e)
        {
            if (this.TextBoxViasLocalidadLocal.Text.Length > 0)
            {
                this.lblAvisoVL.Visible = false;
                AlfaWS.GDPClass resultadoVL = _OperacionesAlfaWS.ObtenerViasLocalidad(this.TextBoxViasLocalidadLocal.Text, this.TextBoxViasLocalidadVia.Text, this.comboIdioma.SelectedItem.Text);
                GridViewViasLocalidadM.DataSource = resultadoVL.Municipio;
                GridViewViasLocalidadM.DataBind();
                GridViewViasLocalidadES.DataSource = resultadoVL.EntidadSingular;
                GridViewViasLocalidadES.DataBind();
                GridViewViasLocalidad.DataSource = resultadoVL.Via;
                GridViewViasLocalidad.DataBind();
            }
            else
            {
                this.lblAvisoVL.Visible = true;
            }
            this.TextBoxViasLocalidadLocal.Focus();
        }

        protected void BtnViasNombreViaLocalidad_Click(object sender, EventArgs e)
        {
            if ((this.TextBoxViasNombreViaLocalidadEnti.Text.Length > 0) && (this.TextBoxViasNombreViaLocalidadVia.Text.Length > 0))
            {
                this.lblAvisoVNVL.Visible = false;
                AlfaWS.GDPClass resultadoVNVL = _OperacionesAlfaWS.ObtenerViasNombreViaLocalidad(this.TextBoxViasNombreViaLocalidadEnti.Text, this.TextBoxViasNombreViaLocalidadVia.Text, this.comboIdioma.SelectedItem.Text);
                GridViewViasNombreViaLocalidadM.DataSource = resultadoVNVL.Municipio;
                GridViewViasNombreViaLocalidadM.DataBind();
                GridViewViasNombreViaLocalidadES.DataSource = resultadoVNVL.EntidadSingular;
                GridViewViasNombreViaLocalidadES.DataBind();
                GridViewViasNombreViaLocalidad.DataSource = resultadoVNVL.Via;
                GridViewViasNombreViaLocalidad.DataBind();
            }
            else
            {
                this.lblAvisoVNVL.Visible = true;
            }
            this.TextBoxViasNombreViaLocalidadEnti.Focus();
        }

        protected void BtnViasNombreViaEntSingular_Click(object sender, EventArgs e)
        {
            if ((this.TextBoxViasNombreViaEntSingularEnti.Text.Length > 0) && (this.TextBoxViasNombreViaEntSingularVia.Text.Length > 0))
            {
                this.lblAvisoVNVES.Visible = false;
                AlfaWS.GDPClass resultadoVNVES = _OperacionesAlfaWS.ObtenerViasNombreViaEntSingular(Convert.ToInt32(this.TextBoxViasNombreViaEntSingularEnti.Text), this.TextBoxViasNombreViaEntSingularVia.Text, this.comboIdioma.SelectedItem.Text);
                GridViewViasNombreViaEntSingularM.DataSource = resultadoVNVES.Municipio;
                GridViewViasNombreViaEntSingularM.DataBind();
                GridViewViasNombreViaEntSingularES.DataSource = resultadoVNVES.EntidadSingular;
                GridViewViasNombreViaEntSingularES.DataBind();
                GridViewViasNombreViaEntSingular.DataSource = resultadoVNVES.Via;
                GridViewViasNombreViaEntSingular.DataBind();
            }
            else
            {
                this.lblAvisoVNVES.Visible = true;
            }
            this.TextBoxViasNombreViaEntSingularEnti.Focus();
        }

        protected void BtnPostalCodPortal_Click(object sender, EventArgs e)
        {
            if (this.TextBoxPostalCodPortal.Text.Length > 0)
            {
                this.lblAvisoPCP.Visible = false;
                AlfaWS.GDPClass resultadoPCP = _OperacionesAlfaWS.ObtenerPostalCodPortal(Convert.ToInt32(this.TextBoxPostalCodPortal.Text), this.comboIdioma.SelectedItem.Text);
                GridViewPostalCodPortalM.DataSource = resultadoPCP.Municipio;
                GridViewPostalCodPortalM.DataBind();
                GridViewPostalCodPortalES.DataSource = resultadoPCP.EntidadSingular;
                GridViewPostalCodPortalES.DataBind();
                GridViewPostalCodPortalV.DataSource = resultadoPCP.Via;
                GridViewPostalCodPortalV.DataBind();
                GridViewPostalCodPortalP.DataSource = resultadoPCP.NumPostal;
                GridViewPostalCodPortalP.DataBind();
            }
            else
            {
                this.lblAvisoPCP.Visible = true;
            }
            this.TextBoxPostalCodPortal.Focus();
        }


        protected void BtnPostales_Click(object sender, EventArgs e)
        {
            if (this.TextBoxPostalesVia.Text.Length > 0)
            {
                this.lblAvisoP.Visible = false;
                AlfaWS.GDPClass resultadoP = _OperacionesAlfaWS.ObtenerPostales(Convert.ToInt32(this.TextBoxPostalesVia.Text), this.TextBoxPostalesNum.Text, this.comboIdioma.SelectedItem.Text);
                GridViewPostalesM.DataSource = resultadoP.Municipio;
                GridViewPostalesM.DataBind();
                GridViewPostalesES.DataSource = resultadoP.EntidadSingular;
                GridViewPostalesES.DataBind();
                GridViewPostalesV.DataSource = resultadoP.Via;
                GridViewPostalesV.DataBind();
                GridViewPostales.DataSource = resultadoP.NumPostal;
                GridViewPostales.DataBind();
            }
            else
            {
                this.lblAvisoP.Visible = true;
            }
            this.TextBoxPostalesVia.Focus();
        }

        protected void BtnPostal_Click(object sender, EventArgs e)
        {
            if (this.TextBoxPostalVia.Text.Length > 0)
            {
                this.lblAvisoPs.Visible = false;
                AlfaWS.GDPClass resultadoPs = _OperacionesAlfaWS.ObtenerPostal(Convert.ToInt32(this.TextBoxPostalVia.Text), this.TextBoxPostalNum.Text, this.comboIdioma.SelectedItem.Text);
                GridViewPostalM.DataSource = resultadoPs.Municipio;
                GridViewPostalM.DataBind();
                GridViewPostalESs.DataSource = resultadoPs.EntidadSingular;
                GridViewPostalESs.DataBind();
                GridViewPostalV.DataSource = resultadoPs.Via;
                GridViewPostalV.DataBind();
                GridViewPostal.DataSource = resultadoPs.NumPostal;
                GridViewPostal.DataBind();
            }
            else
            {
                this.lblAvisoPs.Visible = true;
            }
            this.TextBoxPostalVia.Focus();
        }

        protected void BtnPostalesNombreLocalidad_Click(object sender, EventArgs e)
        {
            if ((this.TextBoxPostalesNombreLocalidadEnti.Text.Length > 0) && (this.TextBoxPostalesNombreLocalidadVia.Text.Length > 0))
            {
                this.lblAvisoPNL.Visible = false;
                AlfaWS.GDPClass resultadoPNL = _OperacionesAlfaWS.ObtenerPostalesNombreLocalidad(this.TextBoxPostalesNombreLocalidadEnti.Text, this.TextBoxPostalesNombreLocalidadVia.Text, this.TextBoxPostalesNombreLocalidadNum.Text, this.comboIdioma.SelectedItem.Text);
                GridViewPostalesNombreLocalidadM.DataSource = resultadoPNL.Municipio;
                GridViewPostalesNombreLocalidadM.DataBind();
                GridViewPostalesNombreLocalidadES.DataSource = resultadoPNL.EntidadSingular;
                GridViewPostalesNombreLocalidadES.DataBind();
                GridViewPostalesNombreLocalidadV.DataSource = resultadoPNL.Via;
                GridViewPostalesNombreLocalidadV.DataBind();
                GridViewPostalesNombreLocalidad.DataSource = resultadoPNL.NumPostal;
                GridViewPostalesNombreLocalidad.DataBind();
            }
            else
            {
                this.lblAvisoPNL.Visible = true;
            }
            this.TextBoxPostalesNombreLocalidadEnti.Focus();
        }

        protected void BtnPostalesEntidadNombreCasa_Click(object sender, EventArgs e)
        {
            if ((this.TextBoxPostalesEntidadNombreCasaEnti.Text.Length > 0) && (this.TextBoxPostalesEntidadNombreCasaCasa.Text.Length > 0))
            {
                this.lblAvisoPENC.Visible = false;
                AlfaWS.GDPClass resultadoPENC = _OperacionesAlfaWS.ObtenerPostalesEntidadNombreCasa(Convert.ToInt32(this.TextBoxPostalesEntidadNombreCasaEnti.Text), this.TextBoxPostalesEntidadNombreCasaCasa.Text, this.comboIdioma.SelectedItem.Text);
                GridViewPostalesEntidadNombreCasaM.DataSource = resultadoPENC.Municipio;
                GridViewPostalesEntidadNombreCasaM.DataBind();
                GridViewPostalesEntidadNombreCasaES.DataSource = resultadoPENC.EntidadSingular;
                GridViewPostalesEntidadNombreCasaES.DataBind();
                GridViewPostalesEntidadNombreCasaV.DataSource = resultadoPENC.Via;
                GridViewPostalesEntidadNombreCasaV.DataBind();
                GridViewPostalesEntidadNombreCasaP.DataSource = resultadoPENC.NumPostal;
                GridViewPostalesEntidadNombreCasaP.DataBind();
            }
            else
            {
                this.lblAvisoPENC.Visible = true;
            }
            this.TextBoxPostalesEntidadNombreCasaEnti.Focus();
        }

        protected void BtnPostalesViaNombreCasa_Click(object sender, EventArgs e)
        {
            if ((this.TextBoxPostalesViaNombreCasaVia.Text.Length > 0) && (this.TextBoxPostalesViaNombreCasaCasa.Text.Length > 0))
            {
                this.lblAvisoPVNC.Visible = false;
                AlfaWS.GDPClass resultadoPVNC = _OperacionesAlfaWS.ObtenerPostalesViaNombreCasa(Convert.ToInt32(this.TextBoxPostalesViaNombreCasaVia.Text), this.TextBoxPostalesViaNombreCasaCasa.Text, this.comboIdioma.SelectedItem.Text);
                GridViewPostalesViaNombreCasaM.DataSource = resultadoPVNC.Municipio;
                GridViewPostalesViaNombreCasaM.DataBind();
                GridViewPostalesViaNombreCasaES.DataSource = resultadoPVNC.EntidadSingular;
                GridViewPostalesViaNombreCasaES.DataBind();
                GridViewPostalesViaNombreCasaV.DataSource = resultadoPVNC.Via;
                GridViewPostalesViaNombreCasaV.DataBind();
                GridViewPostalesViaNombreCasaP.DataSource = resultadoPVNC.NumPostal;
                GridViewPostalesViaNombreCasaP.DataBind();
            }
            else
            {
                this.lblAvisoPVNC.Visible = true;
            }
            this.TextBoxPostalesViaNombreCasaVia.Focus();
        }

        protected void BtnPostalesNombreEntidadSingular_Click(object sender, EventArgs e)
        {
            if ((this.TextBoxPostalesNombreEntidadSingularEnti.Text.Length > 0) && (this.TextBoxPostalesNombreEntidadSingularVia.Text.Length > 0))
            {
                this.lblAvisoPNES.Visible = false;
                AlfaWS.GDPClass resultadoPNES = _OperacionesAlfaWS.ObtenerPostalesNombreEntidadSingular(Convert.ToInt32(this.TextBoxPostalesNombreEntidadSingularEnti.Text), this.TextBoxPostalesNombreEntidadSingularVia.Text, this.TextBoxPostalesNombreEntidadSingularNum.Text, this.comboIdioma.SelectedItem.Text);
                GridViewPostalesNombreEntidadSingularM.DataSource = resultadoPNES.Municipio;
                GridViewPostalesNombreEntidadSingularM.DataBind();
                GridViewPostalesNombreEntidadSingularES.DataSource = resultadoPNES.EntidadSingular;
                GridViewPostalesNombreEntidadSingularES.DataBind();
                GridViewPostalesNombreEntidadSingularV.DataSource = resultadoPNES.Via;
                GridViewPostalesNombreEntidadSingularV.DataBind();
                GridViewPostalesNombreEntidadSingular.DataSource = resultadoPNES.NumPostal;
                GridViewPostalesNombreEntidadSingular.DataBind();
            }
            else
            {
                this.lblAvisoPNES.Visible = true;
            }
            this.TextBoxPostalesNombreEntidadSingularEnti.Focus();
        }

        private void MsgBox(string sMessage)
        {
            string msg = "<script language=\"javascript\">";
            msg += "alert('" + sMessage + "');";
            msg += "</script>";
            Response.Write(msg);
        }

    }
}