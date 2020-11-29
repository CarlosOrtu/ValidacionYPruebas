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
    public partial class NewHU : System.Web.UI.Page
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
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("HUAdministration.aspx");
        }

        protected void ButtonAcept_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TextBoxID.Text) || string.IsNullOrEmpty(TextBoxDescription.Text) || string.IsNullOrEmpty(TextBoxQue.Text)
                || string.IsNullOrEmpty(TextBoxComo.Text) || string.IsNullOrEmpty(TextBoxPara.Text) || string.IsNullOrEmpty(DropProjects.SelectedValue))
            {
                lblEmpty.Text = "No puede qeudar ningun campo vacio";
            }
            else
            {
                Proyecto project = dataBase.leeProyecto(DropProjects.SelectedValue);
                HistoriasUsuario hu = new HistoriasUsuario(Int32.Parse(TextBoxID.Text), TextBoxDescription.Text, TextBoxComo.Text, TextBoxQue.Text, TextBoxPara.Text, project);
                if (!project.LeerHistoriaUsuario(hu))
                {
                    project.AñadirHistoriaUsuario(hu);
                    dataBase.modificaDatosProyecto(project);
                    Server.Transfer("NewHU.aspx");
                }
                else
                {
                    lblError.Text = "La historia de usuario ya existe para ese proyecto";
                }
            }
        }
    }
}