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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Tcc.Code.DTO;
using Tcc.Code.BLL;
namespace Tcc.SETORES
{
    /// <summary>
    /// Interaction logic for frmAddSetor.xaml
    /// </summary>
    public partial class frmAddSetor : MetroWindow
    {
        public frmAddSetor()
        {
            InitializeComponent();
        }
        SetorDTO setordto = new SetorDTO();
        SetorBLL setorbll = new SetorBLL();
        private void tlSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                setordto.Nome = txtNomeSetor.Text;
                setordto.Descricao = txtDescricao.Text;
                

                int x = setorbll.inserir(setordto);
                if (x > 0)
                {
                    this.ShowMessageAsync("Sucesso!", "Dados salvos com sucesso!");
                }
                else
                {
                   
                }
            }
            catch (Exception erro)
            {
                this.ShowMessageAsync("Erro!", "Erro ao tentar inserir os dados!" + erro);
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
    }
}
