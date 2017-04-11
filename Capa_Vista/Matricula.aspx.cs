using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capa_Vista
{
    public partial class Informacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) {
                GVMatricula.DataSource = new Capa_Negocios.ClsEstudiante().returnSelect();
                GVMatricula.DataBind();
            }
        }
    }
}