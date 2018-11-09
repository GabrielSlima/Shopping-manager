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
using MetroFramework.Controls;

namespace Tcc.DOCAS
{
    public partial class frmConfigurarDoca : MetroFramework.Forms.MetroForm
    {
        public frmConfigurarDoca()
        {
            InitializeComponent();
        }

        private void frmConfigurarDoca_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }
        public void carregarGrid()
        {
            try
            {
                IList<DocasDTO> listarDocas = new List<DocasDTO>();
                {
                    listarDocas = new DocasBLL().CarregarDocas();
                    dgvVer.AutoGenerateColumns = false;
                    dgvVer.DataSource = listarDocas;
                }
            }
            catch (Exception erro)
            {
              MetroFramework.MetroMessageBox.Show(Owner, "Erro ao tentar carregar as informações!", "Erro!" + erro, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void dgvVer_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                frmAlterarDoca alterarDoca = new frmAlterarDoca();
                alterarDoca.txtID.Text = dgvVer.SelectedRows[0].Cells[0].Value.ToString();
                alterarDoca.txtNomeLoja.Text = dgvVer.SelectedRows[0].Cells[1].Value.ToString();
                alterarDoca.txtHora.Text = dgvVer.SelectedRows[0].Cells[2].Value.ToString();
                alterarDoca.txtData.Text = dgvVer.SelectedRows[0].Cells[3].Value.ToString();
                alterarDoca.txtAltura.Text = dgvVer.SelectedRows[0].Cells[4].Value.ToString();
                alterarDoca.txtPeso.Text = dgvVer.SelectedRows[0].Cells[5].Value.ToString();
                alterarDoca.txtCodigoDoFunc.Text = dgvVer.SelectedRows[0].Cells[6].Value.ToString();
                alterarDoca.txtDescricao.Text = dgvVer.SelectedRows[0].Cells[7].Value.ToString();
                alterarDoca.txtID.IsEnabled = false;
                alterarDoca.ShowDialog();
            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Erro ao tentar alterar os dados!" + erro);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            carregarGrid();
        }
        private void deletar()
        {
            try 
            {
                //VARIAVEL QUE ARMAZENA O CODIGO DA TABELA 
                String deletar = dgvVer.CurrentRow.Cells[0].Value.ToString();

                //INSTANCIAS
                DocasDTO DOCADTO = new DocasDTO();
                DocasBLL DOCABLL = new DocasBLL();

                //ENVIA O CODIGO SELECIONADO PARA A DTO
                DOCADTO.Codigo = Convert.ToInt16(deletar);

                //EXECUTA A AÇÃO DA BLL/MODEL
                DOCABLL.deletarDoca(DOCADTO);

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
                MetroFramework.MetroMessageBox.Show(Owner, "Erro ao tentar DELETAR os dados!" + erro);
            }
        }
    }
}
