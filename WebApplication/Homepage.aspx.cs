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
            if (user != null)
            {
                lblUserName.Text = user.UserName;
                lblEmail.Text = user.Email;
                lblName.Text = user.Name;
                lblSurname.Text = user.Surname;
                lblPhone.Text = user.Phone;
                lblLastPasswordChange.Text = user.LastChangePassword.ToString();
                lblLastLogin.Text = user.LastLogIn.ToString();
                if(user.AdministradorUsuarios || user.AdministradorProyectos)
                {
                    LblTitleAdmin.Text = "Apartado del Administrador";
                    if (user.AdministradorProyectos)
                    {
                        ButtonAdminisProyect.Visible = true;
                    }
                    if (user.AdministradorUsuarios)
                    {
                        ButtonAdminisUser.Visible = true;
                    }
                }
            }
            else
            {
                Server.Transfer("LogIn.aspx");
            }

            Rol r = new Rol("Roleo", 1, "Roleillo");
            Proyecto p1 = new Proyecto("proyecto1", 12, "Primer proyecto");
            p1.AnadirUsuarioConRol(user, r);
            Proyecto p2 = new Proyecto("proyecto2", 1, "Segundo proyecto");
            p2.AnadirUsuarioConRol(user, r);
            Proyecto p3 = new Proyecto("proyecto_vacio", 3, "Vacio");
            p3.AnadirUsuarioConRol(user, r);
            user.AnadirProyecto(p1);
            user.AnadirProyecto(p2);
            user.AnadirProyecto(p3);
            dataBase.insertaProyecto(p1);
            dataBase.insertaProyecto(p2);
            dataBase.insertaProyecto(p3);
        }

        protected void ButtonLogOut_Click(object sender, EventArgs e)
        {
            user = null;
            Server.Transfer("LogIn.aspx");
            //Si usamos Botton.Visible = True; vemos el boton si esta en falso no. TENER EN CUENTA
        }

        protected void ButtonChangePassword_Click(object sender, EventArgs e)
        {
            Server.Transfer("ChangePassword.aspx");
        }

        protected void ButtonListProjects_Click(object sender, EventArgs e)
        {
            Server.Transfer("ProyectList.aspx");
        }

        protected void ButtonChangeUserDates_Click(object sender, EventArgs e)
        {
            Server.Transfer("ChangeUserDates.aspx");
        }

        protected void ButtonAdminisUser_Click(object sender, EventArgs e)
        {
            Server.Transfer("UserAdministration.aspx");
        }
    }
}