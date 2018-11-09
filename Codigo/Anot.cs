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

namespace Tcc
{
    public partial class frmAnot : MetroFramework.Forms.MetroForm
    {
        public frmAnot()
        {
            InitializeComponent();
            this.StyleManager = msmMain;
        }

        private void frmVerAnot_Load(object sender, EventArgs e)
        {
            msmMain.Style = MetroFramework.MetroColorStyle.Black;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
