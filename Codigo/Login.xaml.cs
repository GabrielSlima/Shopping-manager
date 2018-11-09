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

namespace Tcc
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : MetroWindow
    {
        public string nome;
        public Login()
        {

            InitializeComponent();
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Logar();
               

            }
            catch (Exception erro)
            {
                this.ShowMessageAsync("Erro", "Algo deu errado!" + erro);
            }
        }

        private void txtSenha_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            txtNome.Focus();

        }

        private void Login_Load(object sender, RoutedEventArgs e)
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            txtNome.Focus();

        }
        private void Logar()
        {
            try
            {
                if (txtNome.Text == "" || txtSenha.Password == "")
                {
                    this.ShowMessageAsync("Alerta", "Preencha os campos para continuar");
                }
                else
                {
                    UsuarioDTO user = new UsuarioDTO();
                    UsuarioBLL userbll = new UsuarioBLL();

                    user.Login1 = txtNome.Text;
                    user.Senha = criptografar(txtSenha.Password);
                    user.Nivel = "Gerente";
                    user = userbll.AutenticarUsuario(user);
                    if (user.Login1 == null && user.Senha == null)
                    {
                        this.ShowMessageAsync("Alerta", "Dados invalidos!");
                    }
                    else
                    {
                        MainWindow mn = new MainWindow();
                        mn.nivel = 0;
                        this.ShowMessageAsync("Boas vindas!", "Bem vindo " + txtNome.Text);
                        mn.lblNome.Content = "Bem vindo " + txtNome.Text + "!";

                        mn.Show();
                        this.Hide();
                    }

                }
                if (txtNome.Text == "" || txtSenha.Password == "")
                {
                    this.ShowMessageAsync("Alerta", "Preencha os campos para continuar");
                }
                else
                {
                    UsuarioDTO user = new UsuarioDTO();
                    UsuarioBLL userbll = new UsuarioBLL();

                    user.Login1 = txtNome.Text;
                    user.Senha = criptografar(txtSenha.Password);
                    user.Nivel = "Diretor";
                    user = userbll.AutenticarUsuario(user);
                    if (user.Login1 == null && user.Senha == null)
                    {
                        this.ShowMessageAsync("Alerta", "Dados invalidos!");
                    }
                    else
                    {
                        MainWindow mn = new MainWindow();
                        mn.nivel = 1;
                        this.ShowMessageAsync("Boas vindas!", "Bem vindo " + txtNome.Text);
                        mn.lblNome.Content = "Bem vindo " + txtNome.Text + "!";

                        mn.Show();
                        this.Hide();
                    }

                }
                if (txtNome.Text == "" || txtSenha.Password == "")
                {
                    this.ShowMessageAsync("Alerta", "Preencha os campos para continuar");
                }
                else
                {
                    UsuarioDTO user = new UsuarioDTO();
                    UsuarioBLL userbll = new UsuarioBLL();

                    user.Login1 = txtNome.Text;
                    user.Senha =criptografar(txtSenha.Password);
                    user.Nivel = "Presidente";
                    user = userbll.AutenticarUsuario(user);
                    if (user.Login1 == null && user.Senha == null)
                    {
                        this.ShowMessageAsync("Alerta", "Dados invalidos!");
                    }
                    else
                    {
                        MainWindow mn = new MainWindow();
                        mn.nivel = 1;
                        this.ShowMessageAsync("Boas vindas!", "Bem vindo " + txtNome.Text);
                        mn.lblNome.Content = "Bem vindo " + txtNome.Text + "!";

                        mn.Show();
                        this.Hide();
                    }

                }
                if (txtNome.Text == "" || txtSenha.Password == "")
                {
                    this.ShowMessageAsync("Alerta", "Preencha os campos para continuar");
                }
                else
                {
                    UsuarioDTO user = new UsuarioDTO();
                    UsuarioBLL userbll = new UsuarioBLL();

                    user.Login1 = txtNome.Text;
                    user.Senha = criptografar(txtSenha.Password);
                    user.Nivel = "Recepcao";
                    user = userbll.AutenticarUsuario(user);
                    if (user.Login1 == null && user.Senha == null)
                    {
                        this.ShowMessageAsync("Alerta", "Dados invalidos!");
                    }
                    else
                    {
                        MainWindow mn = new MainWindow();
                        mn.nivel = 2;
                        this.ShowMessageAsync("Boas vindas!", "Bem vindo " + txtNome.Text);
                        mn.lblNome.Content = "Bem vindo " + txtNome.Text + "!";

                        mn.Show();
                        this.Hide();
                    }

                }
            }
            
            
            catch (Exception erro)
            {
                this.ShowMessageAsync("Erro", "Usuario ou senha invalidos" + erro);
            }
            
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

       
        private void txtSenha_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (txtSenha.Password != string.Empty)
            {
                Clipboard.SetData(DataFormats.Text,"Slc");
            }
        }
    }
    }

