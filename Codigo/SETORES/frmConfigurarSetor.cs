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

namespace Tcc.SETORES
{
    public partial class frmConfigurarSetor : MetroFramework.Forms.MetroForm
    {
        public frmConfigurarSetor()
        {
            InitializeComponent();
        }

        private void frmConfigurarSetor_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
        public void CarregarGrid()
        {
            try
            {
                IList<SetorDTO> Setor = new List<SetorDTO>();
                {
                    Setor = new SetorBLL().CarregarSetor();
                    dgvVer.AutoGenerateColumns = false;
                    dgvVer.DataSource = Setor;
                }
            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Erro ao tentar carregar os dados!" + erro);
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void dgvVer_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                frmAlterar1 alterar = new frmAlterar1();
                alterar.txtID.Text = dgvVer.SelectedRows[0].Cells[0].Value.ToString();
                alterar.txtNomeSetor.Text = dgvVer.SelectedRows[0].Cells[1].Value.ToString();
                alterar.txtDescricao.Text = dgvVer.SelectedRows[0].Cells[2].Value.ToString();
                alterar.txtID.IsEnabled = false;
                alterar.ShowDialog();
            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Erro ao tentar carregar os dados!" + erro);
            }
        }
        private void deletar()
        {
            try
            {
                //VARIAVEL QUE ARMAZENA O CODIGO DA TABELA 
                String deletar = dgvVer.CurrentRow.Cells[0].Value.ToString();

                //INSTANCIAS
                SetorDTO setorDto = new SetorDTO();
                SetorBLL SetorBLL = new Code.BLL.SetorBLL();
                //ENVIA O CODIGO SELECIONADO PARA A DTO
                setorDto.Codigo = Convert.ToInt16(deletar);

                //EXECUTA A AÇÃO DA BLL/MODEL
                SetorBLL.DeletarSetor(setorDto);

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
                    CarregarGrid();
                }
                else
                {
                    CarregarGrid();
                }
            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Não foi possivel deletar !" + erro);
            }
        }
    }
}