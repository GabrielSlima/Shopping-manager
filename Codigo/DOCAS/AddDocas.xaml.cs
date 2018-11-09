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
using System.Windows.Threading;
using MahApps.Metro.Controls.Dialogs;
using Tcc.Code.DTO;
using Tcc.Code.BLL;

namespace Tcc.DOCAS
{
    /// <summary>
    /// Interaction logic for AddDocas.xaml
    /// </summary>
    public partial class AddDocas : MetroWindow
    {
        public AddDocas()
        {
             InitializeComponent();
        
        }

        private void tlSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DocasBLL docaBll = new DocasBLL();
                DocasDTO DocaDto = new DocasDTO();

                DocaDto.Cod_Funcionario = Convert.ToInt16(txtCodigoDoFunc.Text);
                DocaDto.Data_entrega = txtData.Text;
                DocaDto.Descricao1 = txtDescricao.Text;
                DocaDto.Hora_Entrega = txtHora.Text;
                DocaDto.Nome_Loja = txtNomeLoja.Text;
                DocaDto.Altura = Convert.ToDecimal(txtAltura.Text);
                DocaDto.Peso = Convert.ToDecimal(txtPeso.Text);



                int x = docaBll.inserir(DocaDto);
                if (x > 0)
                {
                    this.ShowMessageAsync("Sucesso!", "Dados salvos com sucesso!");
                }
                else
                {
                    this.ShowMessageAsync("Erro!", "Erro ao incluir os dados!");
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
