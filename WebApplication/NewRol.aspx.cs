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
    public partial class NewRol : System.Web.UI.Page
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
            if (user == null)
            {
                Server.Transfer("LogIn.aspx");
            }

            LabelError.Text = "";
        }

        protected void ButtonAcept_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TextBoxName.Text) || string.IsNullOrEmpty(TextBoxID.Text) || string.IsNullOrEmpty(TextBoxDescription.Text))
            {
                LabelError.Text = "No puede haber ningun campo nulo";
            }
            else
            {
                if(dataBase.LeeRol(TextBoxName.Text) == null)
                {
                    Rol rol = new Rol(TextBoxName.Text, Int32.Parse(TextBoxID.Text), TextBoxDescription.Text);
                    dataBase.InsertarRol(rol);
                    Server.Transfer("NewRol.aspx");
                }
                else
                {
                    LabelError.Text = "El rol ya existe";
                }
              
            }
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("RolAdministration.aspx");
        }
    }
}