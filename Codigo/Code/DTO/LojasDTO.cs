using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tcc.Code.DTO
{
    class LojasDTO
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string nomeFantasia;
        private string nome;
        private string cnpj;
        private string localizacao;
        private int Setor;

        public string Localizacao
        {
            get { return localizacao; }
            set { localizacao = value; }
        }
        

        public string NomeFantasia
        {
            get { return nomeFantasia; }
            set { nomeFantasia = value; }
        }
       

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }
        

        public int Setor1
        {
            get { return Setor; }
            set { Setor = value; }
        } 

    }
}
