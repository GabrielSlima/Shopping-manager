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
    class VeiculosDAL
    {
        //TODAS AS AÇÕES REGISTRADAS AQUI SÃO PASSADAS PARA A CAMADA BLL/MODEL
        public int inserir(VeiculosDTO VeiculoDTO)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                con.Open();
                cm.CommandText = "insert into tb_Veiculos (placa, modelo, marca, cod_Func)" +
                    "values (@placa, @modelo, @marca, @cod_Func)";
                cm.Parameters.Add("placa", SqlDbType.VarChar).Value = VeiculoDTO.Placa;
                cm.Parameters.Add("modelo", SqlDbType.VarChar).Value = VeiculoDTO.Modelo;
                cm.Parameters.Add("marca", SqlDbType.VarChar).Value = VeiculoDTO.Marca;
                cm.Parameters.Add("cod_Func", SqlDbType.Int).Value = VeiculoDTO.CodFuncionario;
                cm.Connection = con;
                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        public IList<VeiculosDTO> ListarVeiculos()
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from tb_Veiculos";
                cm.Connection = con;
                SqlDataReader Leitor;
                IList<VeiculosDTO> ListarVeiculos = new List<VeiculosDTO>();
                con.Open();
                Leitor = cm.ExecuteReader();
                if (Leitor.HasRows)
                {
                    while (Leitor.Read())
                    {
                        VeiculosDTO veiculoDTO = new VeiculosDTO();
                        veiculoDTO.Codigo = Convert.ToInt16(Leitor["codigo"]);
                        veiculoDTO.Placa = Convert.ToString(Leitor["placa"]);
                        veiculoDTO.Modelo = Convert.ToString(Leitor["modelo"]);
                        veiculoDTO.Marca = Convert.ToString(Leitor["marca"]);
                        veiculoDTO.CodFuncionario = Convert.ToInt32(Leitor["cod_Func"]);
                        ListarVeiculos.Add(veiculoDTO);
                    }
                }
                return ListarVeiculos;
            }
        }
        public IList<VeiculosDTO> buscarVeiculos(VeiculosDTO veiculosdto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "select * from tb_Veiculos where placa like @placa + '%'";
                cm.Connection = con;
                cm.Parameters.Add("placa", SqlDbType.VarChar).Value = veiculosdto.Placa;
                SqlDataReader Leitor;
                IList<VeiculosDTO> ListarVeiculos = new List<VeiculosDTO>();
                con.Open();
                Leitor = cm.ExecuteReader();
                if (Leitor.HasRows)
                {
                    while (Leitor.Read())
                    {
                        VeiculosDTO veiculoDTO = new VeiculosDTO();

                        veiculoDTO.Placa = Convert.ToString(Leitor["palca"]);
                        veiculoDTO.Modelo = Convert.ToString(Leitor["modelo"]);
                        veiculoDTO.Marca = Convert.ToString(Leitor["marca"]);
                        veiculoDTO.CodFuncionario = Convert.ToInt32(Leitor["cod_Func"]);
                        ListarVeiculos.Add(veiculoDTO);
                    }
                }
                return ListarVeiculos;
            }

        }
        internal int alterar(VeiculosDTO veiculo)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand("Alterar_veiculos");


                cm.Parameters.AddWithValue("codigo", veiculo.CodFuncionario);
                cm.Parameters.AddWithValue("placa", veiculo.Placa);
                cm.Parameters.AddWithValue("modelo", veiculo.Modelo);
                cm.Parameters.AddWithValue("marca", veiculo.Marca);
                cm.Parameters.AddWithValue("cod_Func", veiculo.CodFuncionario);

                cm.Connection = con;
                cm.CommandType = CommandType.Text;
                con.Open();
                cm.CommandText = "update tb_Veiculos set placa =@placa, modelo=@modelo, marca =@marca, cod_Func =@cod_Func where codigo=@codigo ";
                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        internal int deletarVeiculo(VeiculosDTO veic)
        {
            using (SqlConnection con = new SqlConnection())
            {
                //Conexão com o banco
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand("Deletar_Veiculos");



                cm.CommandType = CommandType.Text;

                cm.CommandText = "delete from tb_Veiculos where codigo =" + veic.Codigo;
                cm.Connection = con;
                con.Open();
                int valor = cm.ExecuteNonQuery();
                return valor;
            }

        }
    }
}
