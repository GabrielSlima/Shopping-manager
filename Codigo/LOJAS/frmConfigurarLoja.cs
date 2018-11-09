using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tcc.Code.BLL;
using Tcc.Code.DTO;

namespace Tcc.LOJAS
{
    public partial class frmConfigurarLoja : MetroFramework.Forms.MetroForm
    {
        public frmConfigurarLoja()
        {
            InitializeComponent();
        }

        private void frmConfigurarLoja_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }

        private void dgvVer_DoubleClick(object sender, EventArgs e)
        {
            frmAlterarLoja alterar = new frmAlterarLoja();
            alterar.txtID.Text = dgvVer.SelectedRows[0].Cells[0].Value.ToString();
            alterar.txtnomeFant.Text = dgvVer.SelectedRows[0].Cells[2].Value.ToString();
            alterar.txtNome.Text = dgvVer.SelectedRows[0].Cells[1].Value.ToString();
            alterar.txtCNPJ.Text = dgvVer.SelectedRows[0].Cells[3].Value.ToString();
            alterar.txtLocalizacao.Text = dgvVer.SelectedRows[0].Cells[4].Value.ToString();
            alterar.txtCodigo.Text = dgvVer.SelectedRows[0].Cells[5].Value.ToString();
            alterar.txtID.IsEnabled = false;
            alterar.ShowDialog();
        }
        private void carregarGrid()
        {
            try
            {
                IList<LojasDTO> listar = new List<LojasDTO>();
                {
                    listar = new LojasBLL().carregarLoja();
                    dgvVer.AutoGenerateColumns = false;
                    dgvVer.DataSource = listar;
                }
            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner,"Erro ao tentar carregar os dados!" + erro);
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

        private void metroTabControl1_DoubleClick(object sender, EventArgs e)
        {

        }
        private void deletar ()
        {
        try 
            {
                //VARIAVEL QUE ARMAZENA O CODIGO DA TABELA 
                String deletar = dgvVer.CurrentRow.Cells[0].Value.ToString();

                //INSTANCIAS
               LojasDTO LjaDto = new LojasDTO();
               LojasBLL LojaBLL = new LojasBLL();
                //ENVIA O CODIGO SELECIONADO PARA A DTO
               LjaDto.Codigo = Convert.ToInt16(deletar);

                //EXECUTA A AÇÃO DA BLL/MODEL
                LojaBLL.DeletarLoja(LjaDto);

            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Erro ao tentar alterar os dados!" + erro);
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
