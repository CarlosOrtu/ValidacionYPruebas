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
            if (dataBase == null)
            {
                dataBase = new DBPruebas();
                Application["Base de Datos"] = dataBase;
            }

            user = (Usuario)Session["Usuario"];
            //Si la variable de sesión es nula pasamos a la pagina de login ya que es necesario iniciar sesión.
            if (user == null)
            {
                Server.Transfer("LogIn.aspx");
            }
        }

        protected void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            if(user.ChangePassword(TBOldPassword.Text,TBChangePassword.Text) && TBChangePassword.Text.Equals(TBChangePassword2.Text))
            {
                user.LastChangePassword = DateTime.Now;
                user.Active = true; //Al cambiar la contraseña se activa el usuario
                Server.Transfer("Captcha.aspx");
            }
            else
            {
                ErrorChangePassword.Text = "Error al cambiar la contraseña.";
            }
        }
    }
}