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
    public partial class HUAdministration : System.Web.UI.Page
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

            if (DropProject.Items.Count != dataBase.TblProyectos.Values.Count)
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
            Server.Transfer("ProjectAdministration.aspx");
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            Server.Transfer("DeleteHU.aspx");
        }

        protected void ButtonNewHU_Click(object sender, EventArgs e)
        {
            Server.Transfer("NewHU.aspx");
        }

        protected void ButtonChangeData_Click(object sender, EventArgs e)
        {
            Server.Transfer("ChangeHUData.aspx");
        }

        protected void ButtonShowHU_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DropProject.SelectedValue))
            {
                lblEmpty1.Text = "El campo no puede estar vacio";
            }
            else
            {
                DropHU.Visible = true;
                ButtonShowData.Visible = true;
                int b = 0;
                Proyecto project = dataBase.leeProyecto(DropProject.SelectedValue);
                foreach(HistoriasUsuario hu in project.Lista_historia_usuario)
                {
                    DropHU.Items.Insert(b, hu.ID1.ToString());
                    b++;
                }
            }
        }

        protected void ButtonShowData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DropHU.SelectedValue))
            {
                lblEmpty2.Text = "El campo no puede estar vacio";
            }
            else
            {
                HistoriasUsuario aux = null;
                Proyecto project = dataBase.leeProyecto(DropProject.SelectedValue);
                foreach (HistoriasUsuario hu in project.Lista_historia_usuario)
                {
                    if (hu.ID1.ToString().Equals(DropHU.SelectedValue))
                    {
                        aux = hu;
                    }
                }
                lblID.Text = aux.ID1.ToString();
                lblDescription.Text = aux.Descripcion;
                lblComo.Text = aux.Como;
                lblQue.Text = aux.Que;
                lblPara.Text = aux.ParaQue;
                lblProject.Text = aux.ProyectoAsociado.Nombre;

            }
        }
    }
}