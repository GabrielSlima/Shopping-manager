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
    public partial class frmVerVeiculos : MetroFramework.Forms.MetroForm
    {
        public frmVerVeiculos()
        {
            InitializeComponent();
        }

        private void frmVerVeiculos_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }
        public void CarregarGrid()
        {
            try
            {
                IList<VeiculosDTO> VeiculosDTO = new List<VeiculosDTO>();
                {
                    
                    VeiculosDTO = new VeiculoBLL().CarregarVeiculos();
                    dgvVer.AutoGenerateColumns = false;
                    dgvVer.DataSource = VeiculosDTO;
                }
            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Erro ao tentar carregar as informações", "Erro!" + erro, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void txtNome_Click(object sender, EventArgs e)
        {

        }

        private void cboCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvVer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try {
                CarregarGrid();

            }
            catch(Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner,"Erro ao tentar carregar os dados!" + erro);
            }
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                IList<VeiculosDTO> listar = new List<VeiculosDTO>();
                {
                    VeiculosDTO veiculodto = new VeiculosDTO();
                    veiculodto.Placa = Convert.ToString(txtNome.Text);
                    listar = new VeiculoBLL().buscar(veiculodto);
                    dgvVer.AutoGenerateColumns = false;
                    dgvVer.DataSource = listar;
                }
            }
            catch(Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Erro ao tentar buscar os dados!" + erro);
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
