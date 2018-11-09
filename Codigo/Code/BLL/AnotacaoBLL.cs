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
    class AnotacaoBLL
    {
        //CAMADA DE NEGOCIOS --> PASSA OS DADOS DO DTO PARA O BANCO DE DADOS
        AnotacaoDAL anotDal = new AnotacaoDAL();
        public int inserir(AnotacaoDTO AnotDto)
        {
            return anotDal.inseritAnot(AnotDto);
        }
        
        public IList<AnotacaoDTO> carregarAnot()
        {
            return new AnotacaoDAL().carregarAnot();

        }
        public IList<AnotacaoDTO> Buscar(AnotacaoDTO anot)
        {
            return anotDal.BuscarAnot(anot);
        }
        public int alterar (AnotacaoDTO anot)
        {
            return new AnotacaoDAL().alterar(anot);
        }
        internal int apagarAnot (AnotacaoDTO anotdto)
        {
            return new AnotacaoDAL().ApagarAnot(anotdto);
        }
    }
}