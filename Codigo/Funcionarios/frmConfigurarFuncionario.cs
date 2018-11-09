using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tcc.Code.DTO;
using Tcc.Code.BLL;

namespace Tcc.Funcionarios
{
    public partial class frmConfigurarFuncionario : MetroFramework.Forms.MetroForm
    {
        public frmConfigurarFuncionario()
        {
            InitializeComponent();
        }

        private void frmConfigurarFuncionario_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }

        private void dgvVer_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                frmAlterarFunc alterar = new frmAlterarFunc();
                alterar.txtID.Text = dgvVer.SelectedRows[0].Cells[0].Value.ToString();
                alterar.txtNomeAddUser.Text = dgvVer.SelectedRows[0].Cells[1].Value.ToString();
                alterar.txtEndereco.Text = dgvVer.SelectedRows[0].Cells[2].Value.ToString();
                alterar.txtCidade.Text = dgvVer.SelectedRows[0].Cells[3].Value.ToString();
                alterar.txtTelefone.Text = dgvVer.SelectedRows[0].Cells[4].Value.ToString();
                alterar.txtCelular.Text = dgvVer.SelectedRows[0].Cells[5].Value.ToString();

                //alterar.cboSexo.Text = dgvVer.SelectedRows[0].Cells[6].Value.ToString(); 
                string sexo = dgvVer.SelectedRows[0].Cells[6].Value.ToString();
                if (sexo == "M")
                {
                    alterar.cboSexo.Text = "Masculino";
                }
                else
                {
                    alterar.cboSexo.Text = "Feminino";
                }
                //   alterar.cboSexo.SelectedItem = alterar.cboSexo.valumember
                alterar.cboCargo.Text = dgvVer.SelectedRows[0].Cells[7].Value.ToString();

                alterar.txtCPF.Text = dgvVer.SelectedRows[0].Cells[8].Value.ToString();
                alterar.txtRG.Text = dgvVer.SelectedRows[0].Cells[9].Value.ToString();
                string turno = dgvVer.SelectedRows[0].Cells[10].Value.ToString();
                if (turno == "M")
                {
                    alterar.cboTurno.Text = "Manhã";
                }
                else if (turno == "T")
                {
                    alterar.cboTurno.Text = "Tarde";
                }
                else
                {
                    alterar.cboTurno.Text = "Noite";
                }
                alterar.txtComplemento.Text = dgvVer.SelectedRows[0].Cells[11].Value.ToString();
                alterar.txtEmail.Text = dgvVer.SelectedRows[0].Cells[12].Value.ToString();
                alterar.txtID.IsEnabled = false;
                alterar.ShowDialog();
            }
            catch (Exception erro)
            {
               MetroFramework.MetroMessageBox.Show(Owner,"Erro !", "Erro ao tentar inserir os dados!" + erro);
            }
        }
        private void carregarGrid()
        {
            try
            {
                IList<FuncionarioDTO> listarFunc = new List<FuncionarioDTO>();
                {
                    listarFunc = new FuncionarioBLL().carregarFuncionarios();
                    dgvVer.AutoGenerateColumns = false;
                    dgvVer.DataSource = listarFunc;
                }
            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Erro ao tentar carregar os dados!" + erro);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                carregarGrid();
            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Erro ao tentar carregar os dados! " + erro);
            }
        }
        private void deletar()
        {
            try
            {
                //VARIAVEL QUE ARMAZENA O CODIGO DA TABELA 
                String deletar = dgvVer.CurrentRow.Cells[0].Value.ToString();

                //INSTANCIAS
                FuncionarioDTO funcDto = new FuncionarioDTO();
                FuncionarioBLL funcBLL = new FuncionarioBLL();
                //ENVIA O CODIGO SELECIONADO PARA A DTO
                funcDto.Codigo = Convert.ToInt16(deletar);

                //EXECUTA A AÇÃO DA BLL/MODEL
                funcBLL.deletarFunc(funcDto);

            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Erro ao tentar deletar os dados!" + erro);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                //CRIA UMA CAIXA DE DIALOGO E CONFIRMA A RESPOSTA DO USUARIO
                DialogResult resp = MetroFramework.MetroMessageBox.Show(Owner, "Deseja mesmo deletar ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    deletar();
                    carregarGrid();
                }
                else
                {
                    carregarGrid();
                }
            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Não foi possivel deletar !" + erro);
            }
        }
    }
}