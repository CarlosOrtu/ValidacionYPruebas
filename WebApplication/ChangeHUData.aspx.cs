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
    public partial class ChangeHUData : System.Web.UI.Page
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

            if (DropProjects.Items.Count != dataBase.TblProyectos.Values.Count)
            {
                int a = 0;
                foreach (Proyecto p in dataBase.TblProyectos.Values)
                {
                    DropProjects.Items.Insert(a, p.Nombre);
                    a++;
                }
            }

            if (DropProyects.Items.Count != dataBase.TblProyectos.Values.Count)
            {
                int a = 0;
                foreach (Proyecto p in dataBase.TblProyectos.Values)
                {
                    DropProyects.Items.Insert(a, p.Nombre);
                    a++;
                }
            }
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("HUAdministration.aspx");
        }

        protected void ButtonShow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DropProjects.SelectedValue))
            {
                lblError.Text = "Debes seleccionar un proyecto";
            }
            else
            {
                Proyecto project = dataBase.leeProyecto(DropProjects.SelectedValue);
                DropHU.Visible = true;
                int b = 0;
                foreach (HistoriasUsuario hu in project.Lista_historia_usuario)
                {
                    DropHU.Items.Insert(b, hu.ID1.ToString());
                    b++;
                }
                TextBoxDescription.Visible = true;
                TextBoxComo.Visible = true;
                TextBoxQue.Visible = true;
                TextBoxPara.Visible = true;
                DropProyects.Visible = true;
                ButtonAcept.Visible = true;
            }
        }

        protected void ButtonAcept_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(DropHU.SelectedValue) || string.IsNullOrEmpty(TextBoxDescription.Text) || string.IsNullOrEmpty(TextBoxQue.Text)
                || string.IsNullOrEmpty(TextBoxComo.Text) || string.IsNullOrEmpty(TextBoxPara.Text) || string.IsNullOrEmpty(DropProyects.SelectedValue))
            {
                lblEmpty.Text = "No puede haber ningun campo vacio";
            }
            else
            {
                HistoriasUsuario aux = null;
                Proyecto project = dataBase.leeProyecto(DropProjects.SelectedValue);
                foreach (HistoriasUsuario hu in project.Lista_historia_usuario)
                {
                    if (hu.ID1.ToString().Equals(DropHU.SelectedValue))
                    {
                        aux = hu;
                    }
                }
                Proyecto projectNew = dataBase.leeProyecto(DropProyects.SelectedValue);
                aux.ModificarDatos(TextBoxDescription.Text, TextBoxComo.Text, TextBoxQue.Text, TextBoxPara.Text, projectNew);
                project.RetirarHistoriaUsuario(aux);
                projectNew.AñadirHistoriaUsuario(aux);
                dataBase.modificaDatosProyecto(project);
                dataBase.modificaDatosProyecto(projectNew);
                Server.Transfer("ChangeHUDAta.aspx");
            }
        }
    }
}