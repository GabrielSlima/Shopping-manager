using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tcc.Code.DTO
{
    class FuncionarioDTO
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string nome;
        private string endereco;
        private string cidade;
        private string telefone;
        private string celular;
        private char sexo;
        private string cargo;
        private string cpf;
        private string rg;
        private char turno;
        private string complemento;
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public char Turno
        {
            get { return turno; }
            set { turno = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
       
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
      

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
       

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
     

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }
     

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
       

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
       
        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
    }
}
