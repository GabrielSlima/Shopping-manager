using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MahApps.Metro;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Tcc.Code.DTO;
using Tcc.Code.BLL;

namespace Tcc.SETORES
{
    /// <summary>
    /// Interaction logic for frmAlterar1.xaml
    /// </summary>
    public partial class frmAlterar1 :MetroWindow
    {
        public frmAlterar1()
        {
            InitializeComponent();
        }

        private void tlSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SetorDTO setordto = new SetorDTO();
                SetorBLL setorbll = new SetorBLL();
                setordto.Codigo = Convert.ToInt16(txtID.Text);
                setordto.Nome = txtNomeSetor.Text;
                setordto.Descricao = txtDescricao.Text;
                

                int x = setorbll.alterar(setordto);
                if (x > 0)
                {
                    this.ShowMessageAsync("Sucesso!", "Dados salvos com sucesso!");
                }
            }
            catch (Exception erro)
            {
                this.ShowMessageAsync("Erro!", "Erro ao tentar inserir os dados!" + erro);
            }
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
    }
}
