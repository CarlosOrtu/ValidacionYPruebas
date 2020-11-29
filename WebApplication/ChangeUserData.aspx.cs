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
    public partial class ChangeUserDates : System.Web.UI.Page
    {

        DBPruebas dataBase;
        Usuario user;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Variable de aplicación
            dataBase = (DBPruebas)Application["Base de Datos"];
            if (dataBase == null)
            {
                dataBase = new DBPruebas();
                Application["Base de Datos"] = dataBase;
            }

            //Variable de sesión. 
            user = (Usuario)Session["Usuario"];
            if(user == null)
            {
                Server.Transfer("LogIn.aspx");
            }
        }

        protected void ButtonChange_Click(object sender, EventArgs e)
        {
            //Si no hay ningún campo vacio y se cumplen las normas sintácticas se modifican los datos.
            if(string.IsNullOrEmpty(TextBoxEmail.Text) || string.IsNullOrEmpty(TextBoxName.Text) || string.IsNullOrEmpty(TextBoxSurname.Text) || string.IsNullOrEmpty(TextBoxPhone.Text))
            {
                lblEmpty.Text = "No puede haber campos vacios";
            }
            else
            {
                user.ModificarDatos(TextBoxEmail.Text, TextBoxName.Text, TextBoxSurname.Text, TextBoxPhone.Text);
                dataBase.modificaDatosUsuario(user);
                if (!user.Email.Equals(TextBoxEmail.Text))
                {
                    LblNoChangeEmail.Text = "No se modifico el email porque no es sintacticamente correcto";
                }
                if (!user.Phone.Equals(TextBoxPhone.Text))
                {
                    LblNoChangePhone.Text = "No se modificó el telefono porque no es correcto";
                }
            }
            
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("Homepage.aspx");
        }
    }
}