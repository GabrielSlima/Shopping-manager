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
    public partial class frmEditAnot : MetroFramework.Forms.MetroForm
    {
        public frmEditAnot()
        {
            InitializeComponent();
        }

        private void frmEditAnot_Load(object sender, EventArgs e)
        {
           
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            frmEditAnot Editar = new frmEditAnot();
            Editar.ShowDialog();
        }
    }
}
