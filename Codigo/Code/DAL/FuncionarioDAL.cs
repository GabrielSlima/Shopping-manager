using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Tcc.Code.DTO;

namespace Tcc.Code.DAL
{
    class FuncionarioDAL
    {

        //   private SqlDataAdapter Adapter;


        public int inserirFunc(FuncionarioDTO funcdto)
        {

            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                con.Open();
                cm.CommandText = "insert into tb_Funcionario (nome_FuncShop,end_FuncShop,complemento,Email,cidade_FuncShop,tel_FuncShop,cel_FuncShop,rg_FuncShop,cpf_FuncShop,cargo_FuncShop, sex_func, turno)" +
                    "values (@nome_FuncShop,@end_FuncShop,@complemento,@Email,@cidade_FuncShop,@tel_FuncShop,@cel_FuncShop,@rg_FuncShop,@cpf_FuncShop,@cargo_FuncShop, @sex_func, @turno)";
                cm.Parameters.Add("nome_FuncShop", SqlDbType.VarChar).Value = funcdto.Nome;
                cm.Parameters.Add("end_FuncShop", SqlDbType.VarChar).Value = funcdto.Endereco;
                cm.Parameters.Add("complemento", SqlDbType.VarChar).Value = funcdto.Complemento;
                cm.Parameters.Add("Email", SqlDbType.VarChar).Value = funcdto.Email;
                cm.Parameters.Add("cidade_FuncShop", SqlDbType.VarChar).Value = funcdto.Cidade;
                cm.Parameters.Add("tel_FuncShop", SqlDbType.VarChar).Value = funcdto.Telefone;
                cm.Parameters.Add("cel_FuncShop", SqlDbType.VarChar).Value = funcdto.Celular;
                cm.Parameters.Add("rg_FuncShop", SqlDbType.VarChar).Value = funcdto.Rg;
                cm.Parameters.Add("cpf_FuncShop", SqlDbType.VarChar).Value = funcdto.Cpf;
                cm.Parameters.Add("cargo_FuncShop", SqlDbType.VarChar).Value = funcdto.Cargo;
                cm.Parameters.Add("sex_func", SqlDbType.VarChar).Value = funcdto.Sexo;
                cm.Parameters.Add("turno", SqlDbType.VarChar).Value = funcdto.Turno;

                cm.Connection = con;
                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        public IList<FuncionarioDTO> carregarFunc()
        {

            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from tb_Funcionario";
                cm.Connection = con;
                SqlDataReader leitor;
                IList<FuncionarioDTO> listar = new List<FuncionarioDTO>();
                con.Open();
                leitor = cm.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        FuncionarioDTO func = new FuncionarioDTO();
                        func.Codigo = Convert.ToInt16(leitor["cod_FuncShop"]);
                        func.Nome = Convert.ToString(leitor["nome_FuncShop"]);
                        func.Endereco = Convert.ToString(leitor["end_FuncShop"]);
                        func.Complemento = Convert.ToString(leitor["complemento"]);
                        func.Email = Convert.ToString(leitor["Email"]);
                        func.Cidade = Convert.ToString(leitor["cidade_FuncShop"]);
                        func.Telefone = Convert.ToString(leitor["tel_FuncShop"]);
                        func.Celular = Convert.ToString(leitor["cel_FuncShop"]);
                        func.Rg = Convert.ToString(leitor["rg_FuncShop"]);
                        func.Cpf = Convert.ToString(leitor["cpf_FuncShop"]);
                        func.Cargo = Convert.ToString(leitor["cargo_FuncShop"]);
                        func.Sexo = Convert.ToChar(leitor["sex_func"]);
                        func.Turno = Convert.ToChar(leitor["turno"]);
                        listar.Add(func);
                    }
                }
                return listar;
            }
        }
        public IList<FuncionarioDTO> BuscarFuncionario(FuncionarioDTO Func)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from tb_Funcionario where cpf_FuncShop like @cpf_FuncShop + '%'";
                cm.Connection = con;
                cm.Parameters.Add("cpf_FuncShop", SqlDbType.VarChar).Value = Func.Cpf;
                SqlDataReader Leitor;
                IList<FuncionarioDTO> Listar = new List<FuncionarioDTO>();

                con.Open();
                Leitor = cm.ExecuteReader();
                if (Leitor.HasRows)
                {
                    while (Leitor.Read())
                    {

                        Func.Nome = Convert.ToString(Leitor["nome_FuncShop"]);
                        Func.Endereco = Convert.ToString(Leitor["end_FuncShop"]);
                        Func.Complemento = Convert.ToString(Leitor["complemento"]);
                        Func.Email = Convert.ToString(Leitor["Email"]);
                        Func.Cidade = Convert.ToString(Leitor["cidade_FuncShop"]);
                        Func.Telefone = Convert.ToString(Leitor["tel_FuncShop"]);
                        Func.Celular = Convert.ToString(Leitor["cel_FuncShop"]);
                        Func.Rg = Convert.ToString(Leitor["rg_FuncShop"]);
                        Func.Cpf = Convert.ToString(Leitor["cpf_FuncShop"]);
                        Func.Cargo = Convert.ToString(Leitor["cargo_FuncShop"]);
                        Func.Sexo = Convert.ToChar(Leitor["sex_func"]);
                        Func.Turno = Convert.ToChar(Leitor["turno"]);
                        Listar.Add(Func);
                    }
                }
                return Listar;
            }
        }
             public IList<FuncionarioDTO> BuscarFuncionarioPorNome(FuncionarioDTO Func)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from tb_Funcionario where nome_FuncShop like @nome_FuncShop + '%'";
                cm.Connection = con;
                cm.Parameters.Add("nome_FuncShop", SqlDbType.VarChar).Value = Func.Nome;
                SqlDataReader Leitor;
                IList<FuncionarioDTO> Listar = new List<FuncionarioDTO>();

                con.Open();
                Leitor = cm.ExecuteReader();
                if (Leitor.HasRows)
                {
                    while (Leitor.Read())
                    {

                        Func.Nome = Convert.ToString(Leitor["nome_FuncShop"]);
                        Func.Endereco = Convert.ToString(Leitor["end_FuncShop"]);
                        Func.Complemento = Convert.ToString(Leitor["complemento"]);
                        Func.Email = Convert.ToString(Leitor["Email"]);
                        Func.Cidade = Convert.ToString(Leitor["cidade_FuncShop"]);
                        Func.Telefone = Convert.ToString(Leitor["tel_FuncShop"]);
                        Func.Celular = Convert.ToString(Leitor["cel_FuncShop"]);
                        Func.Rg = Convert.ToString(Leitor["rg_FuncShop"]);
                        Func.Cpf = Convert.ToString(Leitor["cpf_FuncShop"]);
                        Func.Cargo = Convert.ToString(Leitor["cargo_FuncShop"]);
                        Func.Sexo = Convert.ToChar(Leitor["sex_func"]);
                        Func.Turno = Convert.ToChar(Leitor["turno"]);
                        Listar.Add(Func);
                    }
                }
                return Listar;
            }
        }
        internal int alterar(FuncionarioDTO func)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand("Alterar");

                cm.Parameters.AddWithValue("@cod_FuncShop", func.Codigo);
                cm.Parameters.AddWithValue("@nome_FuncShop", func.Nome);
                cm.Parameters.AddWithValue("@end_FuncShop", func.Endereco);
                cm.Parameters.AddWithValue("@complemento", func.Complemento);
                cm.Parameters.AddWithValue("@email", func.Email);
                cm.Parameters.AddWithValue("@cidade_FuncShop", func.Cidade);
                cm.Parameters.AddWithValue("@tel_FuncShop", func.Telefone);
                cm.Parameters.AddWithValue("@cel_FuncShop", func.Celular);
                cm.Parameters.AddWithValue("@rg_FuncShop", func.Rg);
                cm.Parameters.AddWithValue("@cpf_FuncShop", func.Cpf);
                cm.Parameters.AddWithValue("@cargo_FuncShop", func.Cargo);
                cm.Parameters.AddWithValue("@sex_func", func.Sexo);
                cm.Parameters.AddWithValue("@turno", func.Turno);

                cm.Connection = con;
                cm.CommandType = CommandType.Text;
                con.Open();
                cm.CommandText = " update tb_Funcionario set nome_FuncShop= @nome_FuncShop,end_FuncShop=@end_FuncShop,complemento =@complemento,Email= @Email,cidade_FuncShop = @cidade_FuncShop,tel_FuncShop =@tel_FuncShop,cel_FuncShop =@cel_FuncShop,rg_FuncShop =@rg_FuncShop,cpf_FuncShop =@cpf_FuncShop,cargo_FuncShop =@cargo_FuncShop, sex_func=@sex_func , turno=@turno where cod_FuncShop =@cod_FuncShop";
                cm.Connection = con;
                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        internal int deletarFuncionario(FuncionarioDTO func)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand("Deletar_Func");



                cm.CommandType = CommandType.Text;

                cm.CommandText = "delete from tb_Funcionario where cod_FuncShop =" + func.Codigo;
                cm.Connection = con;
                con.Open();
                int valor = cm.ExecuteNonQuery();
                return valor;
            }

        }
    }
}