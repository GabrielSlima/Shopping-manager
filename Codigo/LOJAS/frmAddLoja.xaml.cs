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
namespace Tcc.LOJAS
{
    /// <summary>
    /// Interaction logic for frmAddLoja.xaml
    /// </summary>
    public partial class frmAddLoja : MetroWindow
    {
        public frmAddLoja()
        {
            InitializeComponent();
        }

        private void tlSalvar_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                LojasBLL bll = new LojasBLL();
                LojasDTO loja = new LojasDTO();
                loja.NomeFantasia = txtnomeFant.Text;
                loja.Nome = txtNome.Text;
                loja.Cnpj = txtCNPJ.Text;
                loja.Localizacao = txtLocalizacao.Text;
                loja.Setor1 = Convert.ToInt16(txtCodigo.Text);
               

                int x =bll.inserir(loja);
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
                this.ShowMessageAsync("Erro!", "Erro ao tentar salvar os dados!" + erro);
            }
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
    }
}
