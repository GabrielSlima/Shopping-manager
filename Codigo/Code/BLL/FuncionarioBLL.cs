using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Tcc.Code.DTO;
using Tcc.Code.DAL;
namespace Tcc.Code.BLL
{
    class FuncionarioBLL
    {
        //OS DADOS QUEM VEM DA DAL, PASSAM POR AQUI
        FuncionarioDAL FuncDal = new FuncionarioDAL();
        public int inserirFuncionario(FuncionarioDTO funcDto)
        {
            return FuncDal.inserirFunc(funcDto);
        }

        public IList <FuncionarioDTO> carregarFuncionarios()
        {
            return new FuncionarioDAL().carregarFunc();
        }
        public IList<FuncionarioDTO> BuscarFunc(FuncionarioDTO funcDto)
        {
            return FuncDal.BuscarFuncionario(funcDto);
        }
        public int alterar(FuncionarioDTO funcdto)
        {
            return FuncDal.alterar(funcdto);
        }
        public int deletarFunc(FuncionarioDTO funcDTo)
        {
            return FuncDal.deletarFuncionario(funcDTo);
        }
        public IList<FuncionarioDTO> BuscarPorNome(FuncionarioDTO func)
        {
            return FuncDal.BuscarFuncionarioPorNome(func);
         }
    }
}