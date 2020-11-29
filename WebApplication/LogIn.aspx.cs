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
    public partial class LogIn : System.Web.UI.Page
    {
        DBPruebas dataBase;
        Usuario user;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Variable de aplicación
            dataBase = (DBPruebas)Application["Base de Datos"];
            if(dataBase == null)
            {
                dataBase = new DBPruebas();
                Application["Base de Datos"] = dataBase;
            }

            //Variable de sesión. Al ser un inicio de sesión, inicio el usuario como null.
            user = null;
            Session["Usuario"] = user;
        }

        protected void ButtonLogIn_Click(object sender, EventArgs e)
        {
            user = dataBase.leeUsuario(TBUsername.Text);
            //Si el usuario no es null significa que está en la base de datos.
            if( user != null && user.CheckPassword(TBPassword.Text))
            {
                //Si está activo el usuario entramos al captcha, si no, tiene que cambiar la contraseña para que el usuario se active.
                if(user.Active == true)
                {
                    Session["Usuario"] = user;
                    user.LastLogIn = DateTime.Now;
                    Server.Transfer("Captcha.aspx");
                }
                else
                {
                    Session["Usuario"] = user;
                    user.LastLogIn = DateTime.Now;
                    Server.Transfer("ChangePassword.aspx");
                }
            }
            else
            {
                lblError.Text = "Usuario y/o contraseña erroneo";
            }
        }

        protected void ButtonNewUser_Click(object sender, EventArgs e)
        {
            Server.Transfer("NewUser.aspx");
        }
    }
}