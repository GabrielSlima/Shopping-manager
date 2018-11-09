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

namespace Tcc.Funcionarios
{
    /// <summary>
    /// Interaction logic for frmAlterarFunc.xaml
    /// </summary>
    public partial class frmAlterarFunc : MetroWindow
    {
        public frmAlterarFunc()
        {
            InitializeComponent();
        }

        private void tlSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                FuncionarioDTO funcDTO = new FuncionarioDTO();
                FuncionarioBLL funcBll = new FuncionarioBLL();
                funcDTO.Codigo = Convert.ToInt16 (txtID.Text);
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
                else if (cboCargo.Text == "Administração")
                {
                    funcDTO.Cargo = "Administração";
                }
                else
                {
                    funcDTO.Cargo = "Outro...";
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
               

                int x = funcBll.alterar(funcDTO);
                if (x > 0)
                {
                    this.ShowMessageAsync("Sucesso!", "Dados salvos com sucesso!");
                }
                else
                {
                    this.ShowMessageAsync("Erro", "Erro ao tentar incluir os dados!");
                }
            }
            catch (Exception erro)
            {
                this.ShowMessageAsync("Erro", "Erro ao tentar alterar os dados!" + erro);
            }
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
    }
}
