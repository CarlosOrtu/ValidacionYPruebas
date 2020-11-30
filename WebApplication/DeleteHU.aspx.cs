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
    public partial class DeleteHU : System.Web.UI.Page
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

            if (DropProjects.Items.Count != dataBase.TblProyectos.Values.Count)
            {
                int a = 0;
                foreach (Proyecto p in dataBase.TblProyectos.Values)
                {
                    DropProjects.Items.Insert(a, p.Nombre);
                    a++;
                }
            }
                
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("HUAdministration.aspx");
        }

        protected void ButtonProject_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DropProjects.SelectedValue))
            {
                Proyecto project = dataBase.leeProyecto(DropProjects.SelectedValue);
                int b = 0;
                foreach (HistoriasUsuario hu in project.Lista_historia_usuario)
                {
                    DropHU.Items.Insert(b, hu.ID1.ToString());
                    b++;
                }
                lblInfo.Visible = true;
                ButtonDelete.Visible = true;
                DropHU.Visible = true;
                lblEmpty1.Text = "";
            }
            else
            {
                lblEmpty1.Text = "No puede haber un campo vacio";
            }
            
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DropHU.SelectedValue))
            {
                HistoriasUsuario aux = null;
                Proyecto project = dataBase.leeProyecto(DropProjects.SelectedValue);
                foreach(HistoriasUsuario hu in project.Lista_historia_usuario)
                {
                    if (hu.ID1.ToString().Equals(DropHU.SelectedValue))
                    {
                        aux = hu;
                    }
                }
                project.RetirarHistoriaUsuario(aux);
                dataBase.modificaDatosProyecto(project);
                Server.Transfer("DeleteHU.aspx");
            }
            else
            {
                lblEmpty2.Text = "No puede haber campos vacios";
            }
        }
    }
}