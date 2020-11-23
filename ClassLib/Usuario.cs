using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace ClassLib
{
    public class Usuario : IComparable
    {
        private String userName;
        private String password;
        private String email;
        private String name;
        private String surname;
        private String phone;
        private Boolean active;
        private DateTime lastLogIn;
        private DateTime lastChangePassword;
        private Boolean AdminProyectos;
        private Boolean AdminUsuarios;
        private List<Proyecto> lista_proyectos = new List<Proyecto>();

        public Usuario(string userName, String password, String email, String name, String surname, String phone)
        {
            this.userName = userName;
            this.active = false;
            this.password = EncryptPassword(password);
            this.email = email;
            this.name = name;
            this.surname = surname;
            this.phone = phone;
        }

        public string UserName { get => userName; }
        public string Email { get => email; set => email = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Phone { get => phone; set => phone = value; }
        public bool Active { get => active; set => active = value; }
        public DateTime LastLogIn { get => lastLogIn; set => lastLogIn = value; }
        public DateTime LastChangePassword { get => lastChangePassword; set => lastChangePassword = value; }
        public bool AdministradorProyectos { get => AdminProyectos; set => AdminProyectos = value; }
        public bool AdministradorUsuarios { get => AdminUsuarios; set => AdminUsuarios = value; }
        public List<Proyecto> Lista_proyectos { get => lista_proyectos; set => lista_proyectos = value; }

        public Boolean CheckEmail(string email)
        {
            return Regex.IsMatch(email, @"\A[^@\s]+@[^@\s]+\.(com|es)\Z");
        }

        public Boolean CheckPhone()
        {
            if (this.phone.Length == 9 && (this.phone.First() == '6' || this.phone.First() == '7'))
            {
                return true;
            }

            return false;
        }

        public Boolean ChangePassword(string oldPassword, string newPassword)
        {
            if (SyntaxPassword(newPassword) && this.password.Equals(EncryptPassword(oldPassword)) && !this.password.Equals(EncryptPassword(newPassword)))
            {
                this.active = true;
                this.password = EncryptPassword(newPassword);
                lastChangePassword = DateTime.Now;
                return true;
            }

            return false;
        }

        public Boolean CheckPassword(string password)
        {
            if (this.password.Equals(EncryptPassword(password)))
            {
                return true;
            }

            return false;
        }

        public Boolean SyntaxPassword(string password)
        {
            if (password.Length > 7 && password.Contains("_") && ContainsNumber(password))
            {
                return true;
            }

            return false;
        }

        public Boolean ContainsNumber(string password)
        {
            string numbers = "0123456789";

            foreach (char a in password)
            {
                if (numbers.Contains(a))
                {
                    return true;
                }
            }

            return false;
        }

        public string EncryptPassword(string password)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(password);
            SHA256 mySHA256 = SHA256.Create(); bytes = mySHA256.ComputeHash(bytes);
            return (System.Text.Encoding.ASCII.GetString(bytes));
        }

        public Boolean LogIn(string userName, string password)
        {
            if (userName.Equals(this.userName) && EncryptPassword(password).Equals(this.password) && active == true)
            {
                lastLogIn = DateTime.Now;
                return true;
            }

            return false;
        }

        public void ModificarDatos(string email, string name, string surname, string phone)
        {
            if (CheckEmail(email))
            {
                this.email = email;
            }
            this.name = name;
            this.surname = surname;
            if (CheckPhone())
            {
                this.phone = phone;
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Usuario usuario &&
                   userName == usuario.userName;
        }

        public override int GetHashCode()
        {
            return 1213502048 + userName.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            return userName.CompareTo(obj);
        }

        //Metodos lista proyectos
        public Boolean AnadirProyecto(Proyecto p1)
        {
            if (!lista_proyectos.Any() || !lista_proyectos.Contains(p1))
            {
                lista_proyectos.Add(p1);
                return true;
            }

            return false;

        }

        public Boolean RetirarProyecto(Proyecto p1)
        {
            return lista_proyectos.Remove(p1);
        }

        public Boolean EliminarProyectos()
        {
            if (lista_proyectos.Any())
            {
                lista_proyectos.Clear();
                return true;
            }

            return false;
        }

        public Boolean LeerProyecto(Proyecto p1)
        {
            return lista_proyectos.Contains(p1);
        }
        
    }
}
