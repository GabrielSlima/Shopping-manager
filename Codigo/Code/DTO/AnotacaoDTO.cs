using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tcc.Code.DTO
{
    class AnotacaoDTO
    {
        private int codigoAnot;

        public int CodigoAnot
        {
            get { return codigoAnot; }
            set { codigoAnot = value; }
        }
        private string anotacao;
        private string data;
        private string hora;
        private int codFuncionario;


        public string Anotacao1
        {
            get { return anotacao; }
            set { anotacao = value; }
        }
        

        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        

        public int CodFuncionario
        {
            get { return codFuncionario; }
            set { codFuncionario = value; }
        }
    }
}
