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
    public partial class captcha : System.Web.UI.Page
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
        }

        protected void ButtonAcept_Click(object sender, EventArgs e)
        {
            if(TextBoxCaptcha.Text == "captcha")
            {
                Server.Transfer("Homepage.aspx");
            }
            else
            {
                LabelError.Text = "Incorrecto";
            }
        }
    }
}