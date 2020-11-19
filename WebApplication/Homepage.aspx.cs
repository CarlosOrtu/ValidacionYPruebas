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
    public partial class Homepage : System.Web.UI.Page
    {
        DBPruebas dataBase;
        Usuario user;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Variable de aplicación
            dataBase = (DBPruebas)Application["Base de Datos"];
            if (dataBase == null)
            {
                dataBase = new DBPruebas();
                Application["Base de Datos"] = dataBase;
            }

            //Variable de sesión. 
            user = (Usuario)Session["Usuario"];
            if(user != null)
            {
                lblUserName.Text = user.UserName;
                lblLastPasswordChange.Text = user.LastChangePassword.ToString();
            }

            
        }

        protected void ButtonLogOut_Click(object sender, EventArgs e)
        {
            Server.Transfer("LogIn.aspx");
            //Si usamos Botton.Visible = True; vemos el boton si esta en falso no. TENER EN CUENTA
        }

        protected void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            Server.Transfer("ChangePassword.aspx");
        }
    }
}