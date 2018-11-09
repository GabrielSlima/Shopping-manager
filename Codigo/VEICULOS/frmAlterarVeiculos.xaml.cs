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
namespace Tcc.VEICULOS
{
    /// <summary>
    /// Interaction logic for frmAlterarVeiculos.xaml
    /// </summary>
    public partial class frmAlterarVeiculos : MetroWindow
    {
        public frmAlterarVeiculos()
        {
            InitializeComponent();
        }

        private void tlSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                VeiculoBLL veiculosbll = new VeiculoBLL();
                VeiculosDTO veiculosdto = new VeiculosDTO();
                veiculosdto.Codigo = Convert.ToInt16(txtID.Text);
                veiculosdto.CodFuncionario = Convert.ToInt16(txtCodFunc.Text);
                veiculosdto.Marca = Convert.ToString(txtMarca.Text);
                veiculosdto.Modelo = Convert.ToString(txtModelo.Text);
                veiculosdto.Placa = Convert.ToString(txtPlaca.Text);
                
                int x = veiculosbll.alterar(veiculosdto);
                if (x > 0)
                {
                    this.ShowMessageAsync("Sucesso!", "Dados incluidos com sucesso!");
                }
                else
                {
                    this.ShowMessageAsync("Erro!", "Erro ao tentar alterar os dados!");
                }
            }
            catch (Exception erro)
            { this.ShowMessageAsync("Erro", "Erro ao tentar alterar os dados!" + erro); }
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
    }
}
