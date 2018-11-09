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

namespace Tcc.ANOTACOES
{
    /// <summary>
    /// Interaction logic for frmAlterarAnot.xaml
    /// </summary>
    public partial class frmAlterarAnot : MetroWindow
    {
        public frmAlterarAnot()
        {
            InitializeComponent();
        }

        private void tlAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                AnotacaoDTO AnotDto = new AnotacaoDTO();
                AnotacaoBLL AnotBLL = new AnotacaoBLL();
                AnotDto.CodigoAnot = Convert.ToInt32(txtID.Text);
                AnotDto.Anotacao1 = txtAnot.Text;
                AnotDto.Data = txtData.Text;
                AnotDto.Hora = txtHora.Text;
                AnotDto.CodFuncionario = Convert.ToInt32(txtCode.Text);


                int x = AnotBLL.alterar(AnotDto);
                if (x > 0)
                {
                    this.ShowMessageAsync("Sucesso!", "Dados alterados com sucesso!");
                }
                else
                {
                    this.ShowMessageAsync("Erro!", "Erro ao tentar alterar os dados!");
                }
            }
            catch (Exception erro)
            {
                this.ShowMessageAsync("Erro !", "Erro ao tentar Alterar os dados!" + erro);
            }
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
    }
}
