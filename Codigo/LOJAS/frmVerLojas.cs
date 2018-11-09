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
namespace Tcc.LOJAS
{
    public partial class frmVerLojas : MetroFramework.Forms.MetroForm
    {
        public frmVerLojas()
        {
            InitializeComponent();
        }

        private void frmVerLojas_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }
        private void carregarGrid()
        {
            try
            {
                IList<LojasDTO> loja = new List<LojasDTO>();
                {
                    loja = new LojasBLL().carregarLoja();
                    dgvVer.AutoGenerateColumns = false;
                    dgvVer.DataSource = loja;
                }
            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner,"Erro ao tentar buscar os dados!" + erro);
            }

            }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                IList<LojasDTO> lojaDTO = new List<LojasDTO>();
                {
                    LojasBLL lojaBLL = new LojasBLL();
                    LojasDTO loja = new LojasDTO();
                    loja.Nome = txtNome.Text;
                    lojaDTO = lojaBLL.buscarLoja(loja);
                    dgvVer.AutoGenerateColumns = false;
                    dgvVer.DataSource = lojaDTO;
                }
            }
            catch(Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner,"Erro ao tentar buscar os dados!" + erro);
             }
        }

        private void txtNome_Click(object sender, EventArgs e)
        {

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
        }
    }
