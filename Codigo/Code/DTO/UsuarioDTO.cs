using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tcc.Code.DTO
{
    class UsuarioDTO
    {
        private int CodFunc;

        public int CodFunc1
        {
            get { return CodFunc; }
            set { CodFunc = value; }
        }
        private string Login;

        public string Login1
        {
            get { return Login; }
            set { Login = value; }
        }
        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        private string nivel;

        public string Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }
    }
}
