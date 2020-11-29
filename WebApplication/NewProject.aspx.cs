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
    public partial class NewProject : System.Web.UI.Page
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

            lblEmpty.Text = "";
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("ProjectAdministration.aspx");
        }

        protected void ButtonCreateNewProject_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TextBoxName.Text) || string.IsNullOrEmpty(TextBoxMax.Text) || string.IsNullOrEmpty(TextBoxDescription.Text))
            {
                lblEmpty.Text = "No puede haber campos nulos";
            }
            else
            {
                if(dataBase.leeProyecto(TextBoxName.Text) == null)
                {
                    Proyecto project = new Proyecto(TextBoxName.Text, Int32.Parse(TextBoxMax.Text), TextBoxDescription.Text);
                    dataBase.insertaProyecto(project);
                    Server.Transfer("NewProject.aspx");
                }
                else
                {
                    lblEmpty.Text = "El proyecto ya existe";
                }
                    

            }
        }
    }
}