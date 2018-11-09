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
    class SetorDAL
    {
        public int inserir(SetorDTO SetorDTO)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                con.Open();
                cm.CommandText = "insert into tb_Setor (nome_Setor, descr_Setor)" +
                    "values (@nome_Setor, @descr_Setor )";
                cm.Parameters.Add("nome_Setor", SqlDbType.VarChar).Value = SetorDTO.Nome;
                cm.Parameters.Add("descr_Setor", SqlDbType.VarChar).Value = SetorDTO.Descricao;

                cm.Connection = con;
                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        public IList<SetorDTO> CarregaSetor()
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "Select * from tb_Setor";
                cm.Connection = con;
                SqlDataReader Leitor;
                IList<SetorDTO> ListarSetor = new List<SetorDTO>();
                con.Open();
                Leitor = cm.ExecuteReader();
                if (Leitor.HasRows)
                {
                    while (Leitor.Read())
                    {
                        SetorDTO setor = new SetorDTO();
                        setor.Codigo = Convert.ToInt16(Leitor["cod_Setor"]);
                        setor.Nome = Convert.ToString(Leitor["nome_Setor"]);
                        setor.Descricao = Convert.ToString(Leitor["descr_Setor"]);
                        ListarSetor.Add(setor);
                    }

                }
                return ListarSetor;
            }
        }
        public IList<SetorDTO> buscarSetor(SetorDTO setor)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "Select * from tb_Setor where nome_Setor like @nome_Setor + '%'";
                cm.Connection = con;
                cm.Parameters.Add("nome_Setor", SqlDbType.VarChar).Value = setor.Nome;
                SqlDataReader Leitor;
                IList<SetorDTO> ListarSetor = new List<SetorDTO>();
                con.Open();
                Leitor = cm.ExecuteReader();
                if (Leitor.HasRows)
                {
                    while (Leitor.Read())
                    {
                        setor.Codigo = Convert.ToInt16(Leitor["cod_Setor"]);
                        setor.Nome = Convert.ToString(Leitor["nome_Setor"]);
                        setor.Descricao = Convert.ToString(Leitor["descr_Setor"]);
                        ListarSetor.Add(setor);
                    }

                }
                return ListarSetor;
            }
        }
        internal int alterar(SetorDTO setor)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand("Alterar_setor");


                cm.Parameters.AddWithValue("cod_Setor", setor.Codigo);
                cm.Parameters.AddWithValue("nome_Setor", setor.Nome);
                cm.Parameters.AddWithValue("descr_Setor", setor.Descricao);

                cm.Connection = con;
                cm.CommandType = CommandType.Text;
                con.Open();
                cm.CommandText = "update tb_Setor set nome_Setor=@nome_Setor, descr_Setor=@descr_Setor where cod_Setor = @cod_Setor";
                    
                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        internal int deletarSetor(SetorDTO setor)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand("Deletar_Setores");



                cm.CommandType = CommandType.Text;

                cm.CommandText = "delete from tb_Setor where cod_Setor =" + setor.Codigo;
                cm.Connection = con;
                con.Open();
                int valor = cm.ExecuteNonQuery();
                return valor;
            }

        }
    }
}