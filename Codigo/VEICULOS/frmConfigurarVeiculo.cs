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

namespace Tcc.VEICULOS
{
    public partial class frmConfigurarVeiculo : MetroFramework.Forms.MetroForm
    {
        public frmConfigurarVeiculo()
        {
            InitializeComponent();
        }

        private void frmConfigurarVeiculo_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }

        private void dgvVer_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                frmAlterarVeiculos alterar = new frmAlterarVeiculos();
                alterar.txtID.Text = dgvVer.SelectedRows[0].Cells[0].Value.ToString();
                alterar.txtPlaca.Text = dgvVer.SelectedRows[0].Cells[1].Value.ToString();
                alterar.txtModelo.Text = dgvVer.SelectedRows[0].Cells[2].Value.ToString();
                alterar.txtMarca.Text = dgvVer.SelectedRows[0].Cells[3].Value.ToString();
                alterar.txtCodFunc.Text = dgvVer.SelectedRows[0].Cells[4].Value.ToString();
                alterar.txtID.IsEnabled = false;
                alterar.ShowDialog();
            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Erro ao tentar carregar os dados!" + erro);
            }
        }
        public void carregarGrid()
        {
            try
            {
                IList<VeiculosDTO> listar = new List<VeiculosDTO>();
                listar = new VeiculoBLL().CarregarVeiculos();
                dgvVer.AutoGenerateColumns = false;
                dgvVer.DataSource = listar;
            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Erro ao tentar carregar os dados! " + erro);
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
                VeiculosDTO veicDto = new VeiculosDTO();
                VeiculoBLL veicBll = new VeiculoBLL();

                //ENVIA O CODIGO SELECIONADO PARA A DTO
                veicDto.Codigo = Convert.ToInt16(deletar);

                //EXECUTA A AÇÃO DA BLL/MODEL
                veicBll.Deletar(veicDto);

            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Erro ao tentar alterar os dados!" + erro);
            }
        }

        private void brnDeletar_Click(object sender, EventArgs e)
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

