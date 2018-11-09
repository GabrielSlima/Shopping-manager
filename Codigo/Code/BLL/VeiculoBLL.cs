using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tcc.Code.DTO;
using Tcc.Code.DAL;
using Tcc.Code.BLL;

namespace Tcc.Code.BLL
{
    class VeiculoBLL
    {
        VeiculosDAL veicDAl = new VeiculosDAL();
        public int inserir(VeiculosDTO veiculos)
        {
            return veicDAl.inserir(veiculos);
        }
        public IList<VeiculosDTO> CarregarVeiculos()
        {
            return new VeiculosDAL().ListarVeiculos();
        }
        public IList<VeiculosDTO> buscar(VeiculosDTO veiculos)
        {
            return veicDAl.buscarVeiculos(veiculos);
        }
        public int alterar(VeiculosDTO veiculodto)
        {
            return new VeiculosDAL().alterar(veiculodto);
        }
        public int Deletar (VeiculosDTO veic)
        {
            return veicDAl.deletarVeiculo(veic);   
       }
    }
}
