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
    class SetorBLL
    {
        SetorDAL stDAL = new SetorDAL();
          public int inserir(SetorDTO setordto)
         {
             return stDAL.inserir(setordto);

          }
          public IList<SetorDTO> CarregarSetor()
          {
              return new SetorDAL().CarregaSetor();
          }
          public IList<SetorDTO> buscar(SetorDTO setordto)
          {
              return stDAL.buscarSetor(setordto);
          }
          public int alterar(SetorDTO setordto)
          {
              return new SetorDAL().alterar(setordto);
          }
        public int DeletarSetor (SetorDTO setor)
          {
              return stDAL.deletarSetor(setor);
        }
    }
}
