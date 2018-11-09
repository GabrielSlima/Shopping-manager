using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using Tcc.Code.BLL;
using Tcc.Code.DAL;
using Tcc.Code.DTO;

namespace Tcc
{
    public partial class frmEditarAnot : MetroFramework.Forms.MetroForm
    {
        public frmEditarAnot()
        {
            InitializeComponent();
        }


        AnotacaoDTO anot = new AnotacaoDTO();
        private void frmVerAnot_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }
        private void carregarGrid()
        {
            try
            {
                IList<AnotacaoDTO> listarAnot = new List<AnotacaoDTO>();
                {
                    listarAnot = new AnotacaoBLL().carregarAnot();
                    dgvVer.AutoGenerateColumns = false;
                    dgvVer.DataSource = listarAnot;
                }
            }
            catch (Exception erro)
            {
                MetroMessageBox.Show(Owner, "Erro ao tentar carregar as informações", "Erro!" + erro, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                IList<AnotacaoDTO> Anot = new List<AnotacaoDTO>();
                {
                    anot.Data = txtData.Text;
                    Anot = new AnotacaoBLL().Buscar(anot);
                    dgvVer.AutoGenerateColumns = false;
                    dgvVer.DataSource = Anot;
                }
                if (txtData.Text == "")
                { 
                    carregarGrid();
                }

            }
            catch (Exception erro)
            {
                MetroFramework.MetroMessageBox.Show(Owner, "Erro ao tentar buscar!" + erro);
            }
        }
        public void deletarAnot()
        {
            try
            {
                string deletar = dgvVer.CurrentRow.Cells[0].Value.ToString();
                AnotacaoBLL bll = new AnotacaoBLL();
                AnotacaoDTO anotdto = new AnotacaoDTO();
                anotdto.CodigoAnot = Convert.ToInt16 (deletar);
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
    
    
