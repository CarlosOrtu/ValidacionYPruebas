using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //VER EL ÚLTIMO VIDEO GRABADO.
        }

        protected void ButtonLogOut_Click(object sender, EventArgs e)
        {
            Server.Transfer("LogIn.aspx");
            //Si usamos Botton.Visible = True; vemos el boton si esta en falso no. TENER EN CUENTA
        }
    }
}