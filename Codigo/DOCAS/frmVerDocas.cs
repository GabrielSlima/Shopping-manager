using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Tcc.Code.DTO;
using Tcc.Code.BLL;
namespace Tcc.DOCAS
{
    public partial class frmVerDocas : MetroFramework.Forms.MetroForm
    {
        public frmVerDocas()
        {
            DocasDTO docaDTO = new DocasDTO();
            InitializeComponent();
           
        }

        private void frmVerDocas_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
        private void CarregarGrid()
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
            catch (Exception erro ) 
            {
                MetroMessageBox.Show( Owner,"Erro ao tentar carregar as informações!", "Erro!" + erro, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                IList<DocasDTO> listarDoca = new List<DocasDTO>();
                {
                    DocasDTO doca = new DocasDTO();
                    doca.Nome_Loja = txtNome.Text;
                    listarDoca = new DocasBLL().Buscar(doca);
                    dgvVer.AutoGenerateColumns = false;
                    dgvVer.DataSource = listarDoca;
                }
                if (txtNome.Text == "")
                {
                    CarregarGrid();
                }
            }
            catch (Exception erro )
            {
                MetroMessageBox.Show(Owner, "Erro ao tentar buscar as informações!", "Erro!" + erro, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid();
            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Erro ao tentar carregar os dados! " + erro);
            }
        }
    }
}
