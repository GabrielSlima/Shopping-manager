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
    class DocaDAL
    {
        public int inserir(DocasDTO DocaDTO)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                con.Open();
                cm.CommandText = "insert into tb_Docas (nome_Loja ,hora_entrega,data_entrega,altura_entrega,peso_entrega,cod_FuncShop ,descr_Carga )" +
                    "values (@nome_Loja ,@hora_entrega,@data_entrega,@altura_entrega,@peso_entrega,@cod_FuncShop ,@descr_Carga  )";
                cm.Parameters.Add("nome_Loja", SqlDbType.VarChar).Value = DocaDTO.Nome_Loja;
                cm.Parameters.Add("hora_entrega", SqlDbType.VarChar).Value = DocaDTO.Hora_Entrega;
                cm.Parameters.Add("data_entrega", SqlDbType.VarChar).Value = DocaDTO.Data_entrega;
                cm.Parameters.Add("altura_entrega", SqlDbType.Decimal).Value = DocaDTO.Altura;
                cm.Parameters.Add("peso_entrega", SqlDbType.Decimal).Value = DocaDTO.Peso;
                cm.Parameters.Add("cod_FuncShop", SqlDbType.Int).Value = DocaDTO.Cod_Funcionario;
                cm.Parameters.Add("descr_Carga", SqlDbType.VarChar).Value = DocaDTO.Descricao1;
                cm.Connection = con;
                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        public IList<DocasDTO> CarregarDocas()
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from tb_Docas";
                cm.Connection = con;
                SqlDataReader Leitor;
                IList<DocasDTO> ListarDocas = new List<DocasDTO>();

                con.Open();
                Leitor = cm.ExecuteReader();
                if (Leitor.HasRows)
                {
                    while (Leitor.Read())
                    {
                        DocasDTO docas = new DocasDTO();
                        docas.Codigo = Convert.ToInt16(Leitor["cod_Operacao"]);
                        docas.Nome_Loja = Convert.ToString(Leitor["nome_loja"]);
                        docas.Hora_Entrega = Convert.ToString(Leitor["hora_entrega"]);
                        docas.Data_entrega = Convert.ToString(Leitor["data_entrega"]);
                        docas.Altura = Convert.ToDecimal(Leitor["altura_entrega"]);
                        docas.Peso = Convert.ToDecimal(Leitor["peso_entrega"]);
                        docas.Cod_Funcionario = Convert.ToInt16(Leitor["cod_FuncShop"]);
                        docas.Descricao1 = Convert.ToString(Leitor["descr_Carga"]);
                        ListarDocas.Add(docas);
                    }
                }
                return ListarDocas;
            }

        }
        public IList<DocasDTO> buscarDTO(DocasDTO doca)
        {

            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from tb_Docas where nome_Loja like @nome_Loja + '%'";
                cm.Connection = con;
                cm.Parameters.Add("nome_Loja", SqlDbType.VarChar).Value = doca.Nome_Loja;
                SqlDataReader Leitor;
                IList<DocasDTO> ListarDocas = new List<DocasDTO>();

                con.Open();
                Leitor = cm.ExecuteReader();
                if (Leitor.HasRows)
                {
                    while (Leitor.Read())
                    {
                        doca.Nome_Loja = Convert.ToString(Leitor["nome_Loja"]);
                        doca.Hora_Entrega = Convert.ToString(Leitor["hora_entrega"]);
                        doca.Data_entrega = Convert.ToString(Leitor["data_entrega"]);
                        doca.Altura = Convert.ToDecimal(Leitor["altura_entrega"]);
                        doca.Peso = Convert.ToDecimal(Leitor["peso_entrega"]);
                        doca.Cod_Funcionario = Convert.ToInt16(Leitor["cod_FuncShop"]);
                        doca.Descricao1 = Convert.ToString(Leitor["descr_Carga"]);
                        ListarDocas.Add(doca);
                    }
                }
                return ListarDocas;
            }
        }
        internal int alterar(DocasDTO doca)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand("Alterar_Doca");

                cm.Parameters.AddWithValue("@cod_Operacao", doca.Codigo);
                cm.Parameters.AddWithValue("@nome_Loja", doca.Nome_Loja);
                cm.Parameters.AddWithValue("@hora_entrega", doca.Hora_Entrega);
                cm.Parameters.AddWithValue("@data_entrega", doca.Data_entrega);
                cm.Parameters.AddWithValue("@altura_entrega", doca.Altura);
                cm.Parameters.AddWithValue("@peso_entrega", doca.Peso);
                cm.Parameters.AddWithValue("@cod_FuncShop", doca.Cod_Funcionario);
                cm.Parameters.AddWithValue("descr_Carga", doca.Descricao1);
                cm.Connection = con;
                cm.CommandType = CommandType.Text;
                con.Open();
                cm.CommandText = "update tb_Docas set nome_Loja =@nome_Loja, hora_entrega = @hora_entrega, data_entrega =@data_entrega, altura_entrega = @altura_entrega, peso_entrega =@peso_entrega, cod_FuncShop = @cod_FuncShop, descr_Carga = @descr_Carga where cod_Operacao = @cod_Operacao";
                cm.Connection = con;
                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        internal int deletarDoca(DocasDTO docadto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand("Deletar_Doca");


           
                cm.CommandType = CommandType.Text;
               
                cm.CommandText = "delete from tb_Docas where cod_Operacao =" + docadto.Codigo;
                cm.Connection = con;
                con.Open();
                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
    }
}
