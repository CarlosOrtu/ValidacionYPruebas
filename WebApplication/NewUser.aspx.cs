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
    public partial class NewUser : System.Web.UI.Page
    {
        Usuario user;
        DBPruebas dataBase;

        protected void Page_Load(object sender, EventArgs e)
        {
            dataBase = (DBPruebas)Application["Base de Datos"];
            user = (Usuario)Session["Usuario"];
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("LogIn.aspx");
        }

        protected void ButtonCreateNewUser_Click(object sender, EventArgs e)
        {
            if(null == dataBase.leeUsuario(NewTBUserName.Text))
            {
                /*
                if (user.SyntaxPassword(NewTBPassword.Text))
                {
                    ErrorPassword.Text = "contraseña correcta";
                }
                else
                {
                    ErrorPassword.Text = "La contraseña debe tener mas de 7 carácteres,tener un (guión)'-' y un número";
                }*/
            }
            else
            {
                ErrorUserNameExists.Text = "El nombre de usuario ya existe";
            }
        }
    }
}