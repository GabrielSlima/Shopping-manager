using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tcc.Code.DTO;
using System.Data.SqlClient;
using System.Data;
using System.Security;
using System.Security.Cryptography;

namespace Tcc.Code.DAL
{
    class UsuarioDAL
    {
        public UsuarioDTO autentica(UsuarioDTO usuariodto)
        {
            UsuarioDTO userdto = new UsuarioDTO();
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;

                cm.CommandText = "select * from tb_Usuario where Usuario_Login = @Usuario_Login and senha_Usuario = @senha_Usuario and nivel_Usuario =@nivel_Usuario ";
                cm.Parameters.Add("Usuario_Login", SqlDbType.VarChar).Value = usuariodto.Login1;
                cm.Parameters.Add("senha_Usuario", SqlDbType.VarChar).Value = usuariodto.Senha;
                cm.Parameters.Add("nivel_Usuario", SqlDbType.VarChar).Value = usuariodto.Nivel;
                cm.Connection = con;
                SqlDataReader leitor;
                con.Open();
                leitor = cm.ExecuteReader();
                if (leitor.HasRows)
                {
                    while (leitor.Read())
                    {

                        usuariodto.Login1 = Convert.ToString(leitor["Usuario_Login"]);
                        usuariodto.Senha = Convert.ToString(leitor["senha_Usuario"]);
                        usuariodto.Nivel = Convert.ToString(leitor["nivel_Usuario"]);
                    }
                }
                else
                {
                    usuariodto.Login1 = null;
                    usuariodto.Senha = null;
                }
                return usuariodto;
            }
        }
        public int UsuarioDTOinserir(UsuarioDTO usuariodto)
        {
            UsuarioDTO userdto = new UsuarioDTO();
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Sql;
                SqlCommand cm = new SqlCommand();
                cm.CommandType = CommandType.Text;
                con.Open();
                cm.CommandText = "insert into tb_Usuario (Usuario_Login,senha_Usuario, nivel_Usuario)" +
                    "values (@Usuario_Login, @senha_Usuario,@nivel_Usuario)";
                   
              
                cm.Parameters.Add("Usuario_Login", SqlDbType.VarChar).Value = usuariodto.Login1;
                cm.Parameters.Add("senha_Usuario", SqlDbType.VarChar).Value = usuariodto.Senha;
                cm.Parameters.Add("nivel_Usuario", SqlDbType.VarChar).Value = usuariodto.Nivel;
                
                cm.Connection = con;

                
                int valor = cm.ExecuteNonQuery();
                return valor;
            }
        }
        
    }
}