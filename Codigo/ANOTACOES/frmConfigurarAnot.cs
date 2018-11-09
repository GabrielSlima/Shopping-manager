using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tcc.Code;
using Tcc.Code.DTO;
using Tcc.Code.BLL;

namespace Tcc
{
    public partial class frmEditAnot : MetroFramework.Forms.MetroForm
    {
        public frmEditAnot()
        {
            InitializeComponent();
        }

        private void intializeComponent()
        {
            throw new NotImplementedException();
        }

        private void frmEditAnot_Load(object sender, EventArgs e)
        {
            carregarGrid();
           
        }
        public void carregarGrid()
        {
            try
            {
                //CRIA UMA LISTA PARA ENVIAR PARA O DGV
                IList<AnotacaoDTO> listarAnot = new List<AnotacaoDTO>();
                {
                    listarAnot = new AnotacaoBLL().carregarAnot();
                    dgvver.AutoGenerateColumns = false;
                    dgvver.DataSource = listarAnot;
                }
            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Erro ao tentar carregar as informações", "Erro!" + erro, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void dgvver_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //ENVIA OS DADOS SELECIONADOS NO DGV E, ENVIA PARA O FORM DE ALTERAÇÃO
                ANOTACOES.frmAlterarAnot alterar = new ANOTACOES.frmAlterarAnot();
                alterar.txtID.Text = dgvver.SelectedRows[0].Cells[0].Value.ToString();
                alterar.txtAnot.Text = dgvver.SelectedRows[0].Cells[1].Value.ToString();
                alterar.txtData.Text = dgvver.SelectedRows[0].Cells[2].Value.ToString();
                alterar.txtHora.Text = dgvver.SelectedRows[0].Cells[3].Value.ToString();
                alterar.txtCode.Text = dgvver.SelectedRows[0].Cells[4].Value.ToString();
                alterar.txtID.IsEnabled = false;
                alterar.ShowDialog();
            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Erro ao tentar carregar os dados!" + erro);
            }
        }



        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            carregarGrid();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //CRIA UMA CAIXA DE DIALOGO E CONFIRMA A RESPOSTA DO USUARIO
                DialogResult resp = MetroFramework.MetroMessageBox.Show(Owner, "Deseja mesmo deletar ?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == DialogResult.Yes)
                {
                    deletarAnot();
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
        public void deletarAnot()
        {

            try
            {
                //VARIAVEL QUE ARMAZENA O CODIGO/ID DO REGISTRO
                string deletar = dgvver.CurrentRow.Cells[0].Value.ToString();

                //INSTANCIAS
                AnotacaoBLL bll = new AnotacaoBLL();
                AnotacaoDTO anotdto = new AnotacaoDTO();

                //ENVIA O CODIGO SELECIONADO PARA O DTO
                anotdto.CodigoAnot = Convert.ToInt16(deletar);

                //EXECUTA A AÇAO DE DELETAR DA BLL/MODEL ENVIADO O CODIGO ARMAZENADO NO DTO
                bll.apagarAnot(anotdto);
                int x = new AnotacaoBLL().apagarAnot(anotdto);
                carregarGrid();
            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Erro ao deletar a anotação!" + erro);
            }
        }
    }
}



