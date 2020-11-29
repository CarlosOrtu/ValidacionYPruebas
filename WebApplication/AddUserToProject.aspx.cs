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
    public partial class AddUserToProject : System.Web.UI.Page
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
                Server.Transfer("LogIn.aspx", false);
            }

            //Cargamos en el desplegable los proyectos de la base de datos.
            int a = 0;
            foreach (string project in dataBase.TblProyectos.Keys)
            {
                DropProjects.Items.Insert(a, project);
                a++;
            }

            //Cargamos en el desplegable los usarios de la base de datos.
            int b = 0;
            foreach(string user in dataBase.TblUsuarios.Keys)
            {
                DropUsers.Items.Insert(b, user);
                b++;
            }

            //Cargamos en el desplegable los roles de la base de datos.
            int c = 0;
            foreach(string rol in dataBase.TblRoles.Keys)
            {
                DropRol.Items.Insert(c, rol);
                c++;
            }

            lblError.Text = "";
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("ProjectAdministration.aspx");
        }

        protected void ButtonAcept_Click(object sender, EventArgs e)
        {
            //Si seleccionamos todos los campos, y el usuario no tiene ya ese proyecto añadimos un proyecto con un rol a un usuario.
            if(string.IsNullOrEmpty(DropUsers.SelectedValue) || string.IsNullOrEmpty(DropProjects.SelectedValue) || string.IsNullOrEmpty(DropRol.SelectedValue))
            {
                lblEmpty.Text = "No puede haber ningun campo vacio";
            }
            else
            {
                Proyecto project = dataBase.leeProyecto(DropProjects.SelectedValue);
                Usuario userNew = dataBase.leeUsuario(DropUsers.SelectedValue);
                Rol rol = dataBase.LeeRol(DropRol.SelectedValue);
            
                if (!project.LeerUsuario(userNew))
                {
                    project.AnadirUsuarioConRol(userNew, rol);
                    userNew.AnadirProyecto(project);
                    dataBase.insertaProyecto(project);
                    Server.Transfer("AddUserToProject.aspx");
                }
                else
                {
                    lblError.Text = "El proyecto ya contiene a este usuario";
                }   
            }

        }
    }
}