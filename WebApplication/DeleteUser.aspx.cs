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
    public partial class DeleteUser : System.Web.UI.Page
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
                if (!u.UserName.Equals("Administrador"))
                {
                    DropDownListUsers.Items.Insert(a, u.UserName);
                    a++;
                }
            }
        }

        protected void ButtonBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("UserAdministration.aspx");
        }

        protected void ButtonDelete_Click(object sender, EventArgs e)
        {
            dataBase.borraUsuario(DropDownListUsers.SelectedValue);
            Server.Transfer("DeleteUser.aspx");
        }
    }
}