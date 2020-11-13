using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICapaDatos
    {
        Usuario leeUsuario(string userName);
        
        Usuario borraUsuario(string userName);
        
        bool insertaUsuario(Usuario usuario);

        bool modificaDatosUsuario(Usuario usuario);
    }
}
