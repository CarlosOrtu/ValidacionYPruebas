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
    public partial class ChangeProjectDates : System.Web.UI.Page
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
            else if (user.AdministradorProyectos == false)
            {
                Server.Transfer("Homepage.aspx");
            }

            //Cargamos en el desplegable los proyectos de la base de datos.
            int a = 0;
            foreach(Proyecto p in dataBase.TblProyectos.Values)
            {
                DropProjects.Items.Insert(a, p.Nombre);
                a++;
            }
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("ProjectAdministration.aspx");
        }

        protected void ButtonAcept_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TextBoxDescription.Text) || string.IsNullOrEmpty(TextBoxMax.Text))
            {
                lblEmpty.Text = "No puede haber ningún campo vacio";
            }
            else
            {
                Proyecto proyecto = dataBase.leeProyecto(DropProjects.SelectedValue);
                proyecto.ModificarDatos(Int32.Parse(TextBoxMax.Text), TextBoxDescription.Text);
                dataBase.modificaDatosProyecto(proyecto);
                Server.Transfer("ChangeProjectData.aspx");
            }
        }
    }
}