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
    class LojasBLL
    {
        //A CAMADA DAL ENVIA OS DADOS PARA CA, QUE IRA ENVIAR PARA A CAMADA DTO
        LojaDAL ljDAL = new LojaDAL();
        public int inserir(LojasDTO Loja)
        {
            return ljDAL.inserirLoja(Loja);
        }
        public IList<LojasDTO> carregarLoja()
        {
            return new LojaDAL().CarregarLoja();
        }
        public IList<LojasDTO> buscarLoja (LojasDTO LojaDTO)
        {
            return ljDAL.BuscarLoja(LojaDTO);
        }
        public int alterar(LojasDTO dto)
        {
            return ljDAL.alterar(dto);
        }
        public int DeletarLoja(LojasDTO lojadto)
        {
            return ljDAL.deletarLoja(lojadto);
        }
    }
}
