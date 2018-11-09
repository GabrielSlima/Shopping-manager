using MetroFramework;
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


namespace Tcc
{
    public partial class frmFuncionarios : MetroFramework.Forms.MetroForm
    {
        public frmFuncionarios()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;

        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            carregarGrid();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(Owner, "Funciona", "Mesagem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void carregarGrid()
        {
            IList<FuncionarioDTO> listarFunc = new List<FuncionarioDTO>();
            {
                listarFunc = new FuncionarioBLL().carregarFuncionarios();
                dgvVer.AutoGenerateColumns = false;
                dgvVer.DataSource = listarFunc;
            }
        }



        private void txtNome_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
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

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_KeyUp_1(object sender, KeyEventArgs e)
        {
            try
            {
                //Pega osdados retornados da bll e envia para o grid 
                IList<FuncionarioDTO> Listar = new List<FuncionarioDTO>();
                {
                    FuncionarioBLL funcbll = new FuncionarioBLL();
                    FuncionarioDTO func = new FuncionarioDTO();

                    func.Nome = Convert.ToString(txtNome.Text);
                    Listar = funcbll.BuscarPorNome(func);
                    dgvVer.AutoGenerateColumns = false;
                    dgvVer.DataSource = Listar;

                    if (txtCpf.Text == "")
                    {
                        carregarGrid();
                    }

                }
            }
            catch (Exception erro)
            {
                MetroMessageBox.Show(Owner, "Erro ao tentar buscar os dados!" + erro);
            }
        }

        private void txtCpf_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                //Pega osdados retornados da bll e envia para o grid 
                IList<FuncionarioDTO> Listar = new List<FuncionarioDTO>();
                {
                    FuncionarioBLL funcbll = new FuncionarioBLL();
                    FuncionarioDTO func = new FuncionarioDTO();

                    func.Cpf = Convert.ToString(txtCpf.Text);
                    Listar = funcbll.BuscarFunc(func);
                    dgvVer.AutoGenerateColumns = false;
                    dgvVer.DataSource = Listar;

                    if (txtCpf.Text == "")
                    {
                        carregarGrid();
                    }

                }
            }
            catch (Exception erro)
            {
                MetroMessageBox.Show(Owner, "Erro ao tentar buscar os dados!" + erro);
            }
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                //Pega osdados retornados da bll e envia para o grid 
                IList<FuncionarioDTO> Listar = new List<FuncionarioDTO>();
                {
                    FuncionarioBLL funcbll = new FuncionarioBLL();
                    FuncionarioDTO func = new FuncionarioDTO();

                    func.Nome = Convert.ToString(txtNome.Text);
                    Listar = funcbll.BuscarPorNome(func);
                    dgvVer.AutoGenerateColumns = false;
                    dgvVer.DataSource = Listar;

                    if (txtCpf.Text == "")
                    {
                        carregarGrid();
                    }

                }
            }
            catch (Exception erro)
            {
                MetroMessageBox.Show(Owner, "Erro ao tentar buscar os dados!" + erro);
            }
        }
    }
}