using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tcc.Code.DTO;
using Tcc.Code.DAL;
namespace Tcc.Code.BLL
{
    class DocasBLL
    {
        DocaDAL DocaDAL = new DocaDAL();
       public int inserir(DocasDTO DocaDto)
        {
            return DocaDAL.inserir(DocaDto);
        }
       public IList<DocasDTO> CarregarDocas()
       {
           return new DocaDAL().CarregarDocas();
       }
        public IList<DocasDTO> Buscar(DocasDTO docaDto)
       {
           return DocaDAL.buscarDTO(docaDto);
       }
        public int alterar (DocasDTO docaDto)
        {
            return DocaDAL.alterar(docaDto);
        }
        public int deletarDoca(DocasDTO doca)
        {
            return DocaDAL.deletarDoca(doca);
        }
    }
}
