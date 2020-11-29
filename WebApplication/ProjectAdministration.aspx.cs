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
    public partial class ProjectAdministration : System.Web.UI.Page
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

            //Cargamos todos los poryectos de la base de datos, comprobando que en la lista haya el mismo numero de poryectos que número de proyectos hay en la base.
            if(DropProject.Items.Count != dataBase.TblProyectos.Values.Count)
            {
                int a = 0;
                foreach (Proyecto p in dataBase.TblProyectos.Values)
                {
                    DropProject.Items.Insert(a, p.Nombre);
                    a++;
                }
            }
            
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("Homepage.aspx");
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            Server.Transfer("DeleteProject.aspx");
        }

        protected void ButtonCreateUser_Click(object sender, EventArgs e)
        {
            Server.Transfer("NewProject.aspx");
        }

        protected void ButtonAddUserProject_Click(object sender, EventArgs e)
        {
            Server.Transfer("AddUserToProject.aspx");
        }

        protected void ButtonAdminRoles_Click(object sender, EventArgs e)
        {
            Server.Transfer("RolAdministration.aspx");
        }

        protected void ButtonChangeDates_Click(object sender, EventArgs e)
        {
            Server.Transfer("ChangeProjectData.aspx");
        }

        protected void ButtonShowData_Click(object sender, EventArgs e)
        {
            //Mostramos los datos del proyecto.
            if (!string.IsNullOrEmpty(DropProject.SelectedValue))
            {
                Proyecto project = dataBase.leeProyecto(DropProject.SelectedValue);
                lblName.Text = project.Nombre;
                lblMax.Text = project.Max.ToString();
                lblDescription.Text = project.Descripcion;
                int b = 0;
                foreach (Usuario u in project.Lista_usuarios.Keys)
                {
                    DropUsers.Items.Insert(b, u.UserName);
                    b++;
                }
                DropUsers.Visible = true;
            }
            else
            {
                lblEmpty.Text = "No se puede mostrar datos porque el campo está vacio";
            }
                
        }
    }
}