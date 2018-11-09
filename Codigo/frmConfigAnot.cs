using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tcc
{
    public partial class frmConfigurarAnot : MetroFramework.Forms.MetroForm
    {
        DataSet1TableAdapters.tb_AnotTableAdapter taAnot = new DataSet1TableAdapters.tb_AnotTableAdapter();
        public frmConfigurarAnot()
        {
            InitializeComponent();
        }

        private void mtlDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resp = MessageBox.Show("Deseja continuar ?", "Mensagem", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == System.Windows.Forms.DialogResult.Yes)
                {
                    int codigo = Convert.ToInt16(dgvAnot.CurrentRow.Cells[0].Value);
                    taAnot.DeletarAnot(codigo);
                    dgvAnot.DataSource = taAnot.SelectAnot();
                    string total = (dgvAnot.RowCount - 1).ToString();               
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

       
    }
}

