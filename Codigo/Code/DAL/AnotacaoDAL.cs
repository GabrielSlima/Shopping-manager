using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tcc.Code.DTO;
using System.Data.SqlClient;
using System.Data;


namespace Tcc.Code.DAL
{
    class AnotacaoDAL
    {
        public int inseritAnot(AnotacaoDTO anotdto)
        {

            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                con.Open();
                cm.CommandText = "insert into tb_Anot ( anota_Ocor, date_Ocor, hora_Ocor, cod_Func)" +
                    "values ( @anota_Ocor, @date_Ocor, @hora_Ocor, @cod_Func )";
                cm.Parameters.Add("anota_Ocor", SqlDbType.VarChar).Value = anotdto.Anotacao1;
                cm.Parameters.Add("date_Ocor", SqlDbType.VarChar).Value = anotdto.Data;
                cm.Parameters.Add("hora_Ocor", SqlDbType.VarChar).Value = anotdto.Hora;
                cm.Parameters.Add("cod_Func", SqlDbType.Int).Value = anotdto.CodFuncionario;
                cm.Connection = con;
                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        public IList<AnotacaoDTO> carregarAnot()
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from tb_Anot";
                cm.Connection = con;
                SqlDataReader leitor;

                IList<AnotacaoDTO> listar = new List<AnotacaoDTO>();
                con.Open();
                leitor = cm.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {
                        AnotacaoDTO anot = new AnotacaoDTO();
                        anot.CodigoAnot = Convert.ToInt16(leitor["cod_Ocor"]);
                        anot.CodFuncionario = Convert.ToInt16(leitor["cod_Func"]);
                        anot.Data = Convert.ToString(leitor["date_Ocor"]);
                        anot.Hora = Convert.ToString(leitor["hora_Ocor"]);
                        anot.Anotacao1 = Convert.ToString(leitor["anota_Ocor"]);
                        listar.Add(anot);
                    }
                }
                return listar;
            }
        }
            public IList<AnotacaoDTO> BuscarAnot (AnotacaoDTO anotDto)
            {
                 using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                
                cm.CommandText = "select * from tb_Anot where date_Ocor like @date_Ocor + '%'";
                     cm.Connection= con;
                     cm.Parameters.Add("date_Ocor",SqlDbType.VarChar).Value = anotDto.Data;
                     SqlDataReader leitor;
                     IList<AnotacaoDTO> Lista = new List<AnotacaoDTO>();
                     con.Open();
                     leitor = cm.ExecuteReader();
                     if (leitor.HasRows)
                     {
                         while (leitor.Read())
                         {
                             anotDto.Anotacao1 = Convert.ToString(leitor["anota_Ocor"]);
                             anotDto.Data = Convert.ToString(leitor["date_Ocor"]);
                             anotDto.Hora = Convert.ToString(leitor["hora_Ocor"]);
                             Lista.Add(anotDto);
                         }
                     }
                     return Lista;
                }
            }
        internal int alterar (AnotacaoDTO anot )
            {
                using (SqlConnection con = new SqlConnection())
                {
                    //Conexão com o banco
                    con.ConnectionString = Properties.Settings.Default.Sql;
                    SqlCommand cm = new SqlCommand("Alterar_Anot");

                    cm.Parameters.AddWithValue("@cod_Ocor", anot.CodigoAnot);
                    cm.Parameters.AddWithValue("@anota_Ocor", anot.Anotacao1);
                    cm.Parameters.AddWithValue("@date_Ocor", anot.Data);
                    cm.Parameters.AddWithValue("@hora_Ocor", anot.Hora);
                    cm.Parameters.AddWithValue("@cod_Func", anot.CodFuncionario);
                    cm.Connection = con;
                    cm.CommandType = CommandType.Text;
                    con.Open();
                    cm.CommandText = "update tb_Anot set anota_Ocor =@anota_Ocor, date_Ocor = @date_Ocor, hora_Ocor =@hora_Ocor, cod_Func = @cod_Func where cod_Ocor = @cod_Ocor";
                    cm.Connection = con;
                    int valor = cm.ExecuteNonQuery();
                    return valor;
                }
            }
        internal int ApagarAnot(AnotacaoDTO anotDTo)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand("Deletar");


                cm.CommandType = CommandType.Text;
                
                cm.CommandText = "delete from tb_Anot where cod_Ocor=" + anotDTo.CodigoAnot;
                
                cm.Connection = con;
                con.Open();
                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
    }
 }

