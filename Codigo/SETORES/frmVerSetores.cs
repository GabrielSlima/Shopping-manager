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
    public partial class frmVerSetores : MetroFramework.Forms.MetroForm
    {
        public frmVerSetores()
        {
            InitializeComponent();
        }

        private void frmVerSetores_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }
        public void carregarGrid()
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

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                IList<SetorDTO> listar = new List<SetorDTO>();
                {
                    SetorDTO setor = new SetorDTO();
                   
                    setor.Nome = Convert.ToString(txtNome.Text);

                    listar = new SetorBLL().buscar(setor);
                    dgvVer.AutoGenerateColumns = false;
                    dgvVer.DataSource = listar;
                }
                if (txtNome.Text == "")
                {
                    carregarGrid();
                }
            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Erro ao tentar buscar dados!" + erro);
            }
        }

        

        private void btnAtulizar_Click(object sender, EventArgs e)
        {
            try
            {
                carregarGrid();

            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Erro ao tentar carregar os dados!" + erro);
            }
        }

        
    }
}
