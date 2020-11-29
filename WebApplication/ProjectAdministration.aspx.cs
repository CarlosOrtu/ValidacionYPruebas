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
    }
}