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
using Tcc.Code.DAL;
namespace Tcc.Funcionarios
{
    /// <summary>
    /// Interaction logic for frmAdcFunc.xaml
    /// </summary>
    public partial class frmAdcFunc : MetroWindow
    {
        public frmAdcFunc()
        {
            InitializeComponent();

        }
        
        FuncionarioDTO funcDTO = new FuncionarioDTO();
        private void tlSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool verivicação = txtEmail.Text.Contains("@") && txtEmail.Text.Contains(".com");

                if (verivicação == false)
                {
                    this.ShowMessageAsync("Erro!", "Digite um email valido!");

                }
                else
                {
                    FuncionarioDAL funcDal = new FuncionarioDAL();
                    FuncionarioBLL funcBll = new FuncionarioBLL();
                    funcDTO.Endereco = txtEndereco.Text;
                    funcDTO.Complemento = txtComplemento.Text;
                    funcDTO.Nome = txtNomeAddUser.Text;
                    funcDTO.Cpf = txtCPF.Text;
                    funcDTO.Rg = txtRG.Text;
                    if (cboCargo.Text == "Presidente")
                    {
                        funcDTO.Cargo = "Presidente";
                    }
                    else if (cboCargo.Text == "Diretor(a)")
                    {
                        funcDTO.Cargo = "Diretor(a)";
                    }
                    else if (cboCargo.Text == "Recepção")
                    {
                        funcDTO.Cargo = "Recepção";
                    }
                    else
                    {
                        funcDTO.Cargo = "Gerente";
                    }
                    funcDTO.Cidade = txtCidade.Text;
                    funcDTO.Celular = txtCelular.Text;
                    funcDTO.Telefone = txtTelefone.Text;
                    if (cboSexo.Text == "Feminino")
                    {
                        funcDTO.Sexo = 'F';
                    }
                    else if (cboSexo.Text == "Masculino")
                    {
                        funcDTO.Sexo = 'M';
                    }
                    else
                    {
                        funcDTO.Sexo = 'O';
                    }
                    if (cboTurno.Text == "Manhã")
                    {
                        funcDTO.Turno = 'M';
                    }
                    else if (cboTurno.Text == "Tarde")
                    {
                        funcDTO.Turno = 'T';
                    }
                    else
                    {
                        funcDTO.Turno = 'N';
                    }
                    funcDTO.Email = txtEmail.Text;


                    int x = funcBll.inserirFuncionario(funcDTO);
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

            catch (Exception erro)
            {
                this.ShowMessageAsync("Erro", "Erro ao tentar inserir os dados!" + erro);
            }

        }
           
        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
    }
}
