using ClassLib;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        Usuario user;
        DBPruebas dataBase;

        protected void Page_Load(object sender, EventArgs e)
        {
            dataBase = (DBPruebas)Application["Base de Datos"];
            user = (Usuario)Session["Usuario"];
        }

        protected void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            if(user.changePassword(TBOldPassword.Text,TBChangePassword.Text) && TBChangePassword.Text.Equals(TBChangePassword2.Text))
            {
                Server.Transfer("Homepage.aspx");
            }
            else
            {
                ErrorChangePassword.Text = "Error al cambiar la contraseña.";
            }
        }
    }
}