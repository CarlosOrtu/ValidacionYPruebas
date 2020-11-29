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
            if(CheckBoxProject.Checked == true)
            {
                userNew.AdministradorProyectos = true;
            }
            if(CheckBoxUser.Checked == true)
            {
                userNew.AdministradorUsuarios = true;
            }

            dataBase.insertaUsuario(userNew);
        }
    }
}