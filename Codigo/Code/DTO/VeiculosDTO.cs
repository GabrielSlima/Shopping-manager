using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tcc.Code.DTO
{
    class VeiculosDTO
    {

        private int codigo;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        private string placa;
        private string modelo;
        private string marca;
        private int codFuncionario;
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }
       

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        

        public int CodFuncionario
        {
            get { return codFuncionario; }
            set { codFuncionario = value; }
        }
    }
}
