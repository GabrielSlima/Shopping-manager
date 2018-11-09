using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tcc.Code;
using Tcc.Code.DTO;
using Tcc.Code.DAL;
namespace Tcc.Code.BLL
{
    

    class UsuarioBLL
    {
        UsuarioDAL userdal = new UsuarioDAL();
        public UsuarioDTO AutenticarUsuario(UsuarioDTO Userdto)
        {
            return new UsuarioDAL().autentica(Userdto); 
        }
        public int inseriruser(UsuarioDTO user)
        {
            return userdal.UsuarioDTOinserir(user);
        }
    }
}
