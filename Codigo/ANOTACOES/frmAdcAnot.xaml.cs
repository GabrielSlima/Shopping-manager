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
using Tcc.Code.BLL;
using Tcc.Code.DTO;
namespace Tcc.ANOTACOES
{
    /// <summary>
    /// Interaction logic for frmAdcAnot.xaml
    /// </summary>
    public partial class frmAdcAnot : MetroWindow
    {
        AnotacaoBLL AnotBll = new AnotacaoBLL();
        AnotacaoDTO AnotDto = new AnotacaoDTO();
        public frmAdcAnot()
        {
            InitializeComponent();
        }

        private void tlAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AnotDto.Anotacao1 = txtAnot.Text;
                AnotDto.Data = txtData.Text;
                AnotDto.Hora = txtHora.Text;
                AnotDto.CodFuncionario = Convert.ToInt32(txtCode.Text);


                int x = AnotBll.inserir(AnotDto);
                if (x > 0)
                {
                    this.ShowMessageAsync("Sucesso!", "Dados salvos com sucesso!");
                }
                else
                {
                    this.ShowMessageAsync("Erro!", "Erro ao tentar inserir os dados!");
                }
            }
            catch (Exception erro)
            {
                this.ShowMessageAsync("Erro !", "Erro ao tentar inserir os dados!" + erro);
            }
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
    }
}
