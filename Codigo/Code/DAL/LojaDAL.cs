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
    class LojaDAL
    {
        public int inserirLoja(LojasDTO LojaDTO)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                con.Open();
                cm.CommandText = "insert into tb_Lojas ( nome_fantasia,nome_Loja, cnpj_Loja,localizacao_Loja, cod_Setor)" +
                    "values (@nome_fantasia,@nome_Loja, @cnpj_Loja,@localizacao_Loja , @cod_Setor )";
                cm.Parameters.Add("nome_fantasia", SqlDbType.VarChar).Value = LojaDTO.NomeFantasia;
                cm.Parameters.Add("nome_Loja", SqlDbType.VarChar).Value = LojaDTO.Nome;
                cm.Parameters.Add("cnpj_Loja", SqlDbType.VarChar).Value = LojaDTO.Cnpj;
                cm.Parameters.Add("localizacao_Loja", SqlDbType.VarChar).Value = LojaDTO.Localizacao;
                cm.Parameters.Add("cod_Setor", SqlDbType.Int).Value = LojaDTO.Setor1;
                
                cm.Connection = con;
                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        public IList<LojasDTO> CarregarLoja() 
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText ="Select * from tb_Lojas";
                cm.Connection = con;
               SqlDataReader Leitor;
               IList<LojasDTO> Loja = new List<LojasDTO>();
                con.Open();
                Leitor = cm.ExecuteReader();
                if (Leitor.HasRows)
                {
                    while (Leitor.Read())
                    {
                        LojasDTO lojaDTO = new LojasDTO();
                        lojaDTO.Codigo = Convert.ToInt16(Leitor["cod_Loja"]);
                        lojaDTO.NomeFantasia = Convert.ToString(Leitor["nome_fantasia"]);
                        lojaDTO.Nome = Convert.ToString(Leitor["nome_Loja"]);
                        lojaDTO.Cnpj = Convert.ToString(Leitor["cnpj_Loja"]);
                        lojaDTO.Localizacao = Convert.ToString(Leitor["localizacao_Loja"]);
                        lojaDTO.Setor1 = Convert.ToInt32(Leitor["cod_Setor"]);
                        Loja.Add(lojaDTO);
                    }
                }
                return Loja;
                }
            }
        public IList<LojasDTO> BuscarLoja(LojasDTO lojaDTO)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "Select * from tb_Lojas where nome_Loja like @nome_Loja + '%'";
                cm.Connection = con;
                cm.Parameters.Add("nome_Loja", SqlDbType.VarChar).Value = lojaDTO.Nome;
                SqlDataReader Leitor;
                IList<LojasDTO> Loja = new List<LojasDTO>();
                con.Open();
                Leitor = cm.ExecuteReader();
                if (Leitor.HasRows)
                {
                    while (Leitor.Read())
                    {
                       
                        lojaDTO.NomeFantasia = Convert.ToString(Leitor["nome_fantasia"]);
                        lojaDTO.Nome = Convert.ToString(Leitor["nome_Loja"]);
                        lojaDTO.Cnpj = Convert.ToString(Leitor["cnpj_Loja"]);
                        lojaDTO.Localizacao = Convert.ToString(Leitor["localizacao-Loja"]);
                        lojaDTO.Setor1 = Convert.ToInt32(Leitor["cod_Setor"]);
                        Loja.Add(lojaDTO);
                    }
                }
                return Loja;
            }
        }
        internal int alterar(LojasDTO LojaDTO)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand("Alterar_loja");


                cm.Parameters.AddWithValue("cod_Loja", LojaDTO.Codigo);
                cm.Parameters.AddWithValue("nome_fantasia", LojaDTO.NomeFantasia);
                cm.Parameters.AddWithValue("nome_Loja", LojaDTO.Nome);
                cm.Parameters.AddWithValue("cnpj_Loja", LojaDTO.Cnpj);
                cm.Parameters.AddWithValue("localizacao_Loja", LojaDTO.Localizacao);
                cm.Parameters.AddWithValue("cod_Setor", LojaDTO.Setor1);

                cm.Connection = con;
                cm.CommandType = CommandType.Text;
                con.Open();
                cm.CommandText = "update tb_Lojas set nome_fantasia =@nome_fantasia,nome_Loja =@nome_Loja, cnpj_Loja =@cnpj_Loja,localizacao_Loja =@localizacao_Loja , cod_Setor = @cod_Setor where cod_Loja = @cod_Loja";
                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        internal int deletarLoja(LojasDTO loja)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand("Deletar_Loja");



                cm.CommandType = CommandType.Text;

                cm.CommandText = "delete from tb_Lojas where cod_Loja =" + loja.Codigo;
                cm.Connection = con;
                con.Open();
                int valor = cm.ExecuteNonQuery();
                return valor;
            }

        }
        }
    }
