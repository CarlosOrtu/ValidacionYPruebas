﻿using ClassLib;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class DeleteRol : System.Web.UI.Page
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

            //Cargamos en el desplegable los roles de la base de datos.
            int a = 0;
            foreach(Rol r in dataBase.TblRoles.Values)
            {
                DropRol.Items.Insert(a, r.Tipo_rol);
                a++;
            }

        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("RolAdministration.aspx");
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            dataBase.BorrarRol(DropRol.SelectedValue);
            Server.Transfer("DeleteRol.aspx");
        }
    }
}