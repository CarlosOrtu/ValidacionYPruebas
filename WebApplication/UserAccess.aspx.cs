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
    public partial class UserAccess : System.Web.UI.Page
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

            int a = 0;
            foreach(Usuario u in dataBase.TblUsuarios.Values)
            {
                DropUsers.Items.Insert(a, u.UserName);
                a++;
            }
        }

        protected void ButtonAcept_Click(object sender, EventArgs e)
        {
            Usuario userNew = dataBase.leeUsuario(DropUsers.SelectedValue);

            //Comprobar los campos seleecionados
            if(CheckBoxProject.Checked == true)
            {
                userNew.AdministradorProyectos = true;
            }
            if(CheckBoxUser.Checked == true)
            {
                userNew.AdministradorUsuarios = true;
            }
            if(CheckBoxNOProject.Checked == true)
            {
                userNew.AdministradorProyectos = false;
            }
            if(CheckBoxNOUser.Checked == true)
            {
                userNew.AdministradorUsuarios = false;
            }

            dataBase.insertaUsuario(userNew);
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("UserAdministration.aspx");
        }

        protected void ButtonShow_Click(object sender, EventArgs e)
        {
            Usuario userNew = dataBase.leeUsuario(DropUsers.SelectedValue);

            //Hacemos visible el botón de aplicar permisos.
            ButtonAcept.Visible = true ;

            //Hacer visible solo los campos necesarios, si no es admin campos que permitan ahcer admin y viceversa.
            if (userNew.AdministradorProyectos == true)
            {
                CheckBoxNOProject.Visible = true;
            }
            else
            {
                CheckBoxProject.Visible = true;
            }
            if (userNew.AdministradorUsuarios == true)
            {
                CheckBoxNOUser.Visible = true;
            }
            else
            {
                CheckBoxUser.Visible = true;
            }

        }
    }
}