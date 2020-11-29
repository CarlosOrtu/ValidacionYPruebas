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
    public partial class RolAdministration : System.Web.UI.Page
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

            if (DropRoles.Items.Count != dataBase.TblRoles.Values.Count)
            {
                int a = 0;
                foreach (Rol r in dataBase.TblRoles.Values)
                {
                    DropRoles.Items.Insert(a, r.Tipo_rol);
                    a++;
                }
            }
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("ProjectAdministration.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("NewRol.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("DeleteRol.aspx");
        }

        protected void ButtonChangeRol_Click(object sender, EventArgs e)
        {
            Server.Transfer("ChangeRolData.aspx");
        }

        protected void ButtonShow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(DropRoles.SelectedValue))
            {
                lblEmpty.Text = "No podemos msotrar los datos si no hay un rol";
            }
            else
            {
                Rol rol = dataBase.LeeRol(DropRoles.SelectedValue);
                lblNombre.Text = rol.Tipo_rol;
                lblID.Text = rol.ID1.ToString();
                lblDescription.Text = rol.Descripcion;
            }
        }
    }
}