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
    public partial class ProyectList : System.Web.UI.Page
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
            if (user == null)
            {
                Server.Transfer("LogIn.aspx");
            }

            int a = 0;
            foreach(Proyecto p in user.Lista_proyectos)
            {
                DropProyectList.Items.Insert(a,p.Nombre);
                a++;
            }

            
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("Homepage.aspx");
        }

        protected void ButtonShowData_Click(object sender, EventArgs e)
        {
            Proyecto proyect = dataBase.leeProyecto(DropProyectList.SelectedValue);
            LblName.Text = proyect.Nombre;
            LblMax.Text = proyect.Max.ToString();
            LblDescription.Text = proyect.Descripcion;
        }
    }
}