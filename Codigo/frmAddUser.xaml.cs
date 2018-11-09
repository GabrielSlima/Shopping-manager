using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Tcc.Code.DTO;
using Tcc.Code.BLL;
using System.Security;
using System.Security.Cryptography;
using System.IO;


namespace Tcc
{
    /// <summary>
    /// Interaction logic for frmAddUser.xaml
    /// </summary>
    public partial class frmAddUser : MetroWindow
    {
        

        public frmAddUser()
        {
            InitializeComponent();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtSenha.Password != txtConfirmSenha.Password)
                {
                    this.ShowMessageAsync("Erro!", "Senha não coincidem!");
                }
                else
                {
                    UsuarioDTO userdto = new UsuarioDTO();
                    UsuarioBLL userbll = new UsuarioBLL();
                    
                   
                    userdto.Login1 =txtNome.Text;
                   
                    userdto.Senha = criptografar(txtSenha.Password);
                    if (cboCargo.Text == "Presidente")
                    {
                        userdto.Nivel = "Presidente";
                    }
                    else if (cboCargo.Text == "Diretor")
                    {
                        userdto.Nivel = "Diretor";
                    }
                    else if (cboCargo.Text == "Gerente")
                    {
                        userdto.Nivel = "Gerente";
                    }
                    else
                    {
                        userdto.Nivel = "Recepcao";
                    }


                    int x = userbll.inseriruser(userdto);
                    if (x > 0)
                    {
                        this.ShowMessageAsync("Sucesso!", "Dados salvos com sucesso!");
                    }
                    else
                    {
                        this.ShowMessageAsync("Erro", "Erro ao tentar incluir os dados!");
                    }
                }
                
                    
                
                
            }
            catch(Exception erro)
            {
                this.ShowMessageAsync("Erro", "Erro ao tentar salvar os dados" + erro);
            }
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            
        }
        public string criptografar(string entrada)
        {
            string resultado = "";
            // criação da Hash
            byte[] mensagem = System.Text.Encoding.Default.GetBytes(entrada);
            System.Security.Cryptography.MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();

            byte[] hashCode = MD5.ComputeHash(mensagem);

            for (int i = 0; i < hashCode.Length; i++)
            {
                resultado += (char)(hashCode[i]);
            }
            return resultado;
        }

        
    }
}
