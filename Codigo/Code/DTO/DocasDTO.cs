using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tcc.Code.DTO;

namespace Tcc.Code.DTO
{
    class DocasDTO
    {
        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string nome_Loja;
        private string hora_Entrega;
        private string data_entrega;
        private decimal altura;
        private decimal peso;
        private int cod_Funcionario;
        private string Descricao;

        public decimal Altura
        {
            get { return altura; }
            set { altura = value; }
        }
       

        public decimal Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        

        public string Nome_Loja
        {
            get { return nome_Loja; }
            set { nome_Loja = value; }
        }
      

        public string Hora_Entrega
        {
            get { return hora_Entrega; }
            set { hora_Entrega = value; }
        }
             

        public string Data_entrega
        {
            get { return data_entrega; }
            set { data_entrega = value; }
        }
        

        public int Cod_Funcionario
        {
            get { return cod_Funcionario; }
            set { cod_Funcionario = value; }
        }
      

        public string Descricao1
        {
            get { return Descricao; }
            set { Descricao = value; }
        }
    }
}
