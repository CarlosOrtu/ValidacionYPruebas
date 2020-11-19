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
            if (dataBase == null)
            {
                dataBase = new DBPruebas();
                Application["Base de Datos"] = dataBase;
            }

            //Variable de sesión. Al crear un usuario, inicio el usuario como null.
            user = null;
            Session["Usuario"] = user;
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("LogIn.aspx");
        }

        protected void ButtonCreateNewUser_Click(object sender, EventArgs e)
        {
            //Elimina el texto de error de los label. ¿Alguna Herramienta que no nos haga hacer esto? Una herramienta del tipo "Error"?
            newLabel();

            if (string.IsNullOrEmpty(NewTBUserName.Text) || string.IsNullOrEmpty(NewTBPassword.Text) || string.IsNullOrEmpty(NewTBRepeatPassword.Text)
                || string.IsNullOrEmpty(NewTBEmail.Text) || string.IsNullOrEmpty(NewTBName.Text) || string.IsNullOrEmpty(NewTBSurname.Text)
                || string.IsNullOrEmpty(NewTBPhone.Text))
            {
                ErrorEmpty.Text = "No debe quedar ningún campo vacio, todos los campos son obligatorios";
                
            }
            else 
            {
                if (null == dataBase.leeUsuario(NewTBUserName.Text))
                {
                    user = new Usuario(NewTBUserName.Text, NewTBPassword.Text, NewTBEmail.Text, NewTBName.Text, NewTBSurname.Text, NewTBPhone.Text);
                    if (user.SyntaxPassword(NewTBPassword.Text))
                    {
                        if (NewTBPassword.Text.Equals(NewTBRepeatPassword.Text))
                        {
                            if (user.checkEmail(NewTBEmail.Text))
                            {
                                if (user.checkPhone())
                                {
                                    Session["Usuario"] = user;
                                    dataBase.insertaUsuario(user);
                                    Server.Transfer("ChangePassword.aspx");
                                }
                                else
                                {
                                    ErrorPhone.Text = "El telefono debe tener 9 digitos.";
                                }
                            }
                            else
                            {
                                ErrorEmail.Text = "El email no es sintacticamente correcto. Debe tener un @ y una terminación de '.es' o '.com'";
                            }
                        }
                        else
                        {
                            ErrorRepeat.Text = "Las contraseñas deben ser iguales";
                        }
                    }
                    else
                    {
                        ErrorPassword.Text = "La contraseña debe tener al menos 7 caracteres, un número y un guión bajo '_'";
                    }

                }
                else
                {
                    ErrorUserNameExists.Text = "El nombre de usuario ya existe";
                }
            }
        }

        private void newLabel()
        {
            ErrorEmpty.Text = "";
            ErrorUserNameExists.Text = "";
            ErrorPassword.Text = "";
            ErrorRepeat.Text = "";
            ErrorEmail.Text = "";
            ErrorPhone.Text = "";
        }
    }
}