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




namespace Tcc
{
    public partial class frmExcluirFuncionarios : MetroFramework.Forms.MetroForm
    {
        public frmExcluirFuncionarios()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager1;
            
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(Owner, "Funciona","Mesagem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
