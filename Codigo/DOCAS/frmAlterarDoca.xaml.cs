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
using Tcc.Code.DTO;
using Tcc.Code.BLL;
using MahApps.Metro.Controls.Dialogs;

namespace Tcc.DOCAS
{
    /// <summary>
    /// Interaction logic for frmAlterarDoca.xaml
    /// </summary>
    public partial class frmAlterarDoca : MetroWindow
    {
        public frmAlterarDoca()
        {
            InitializeComponent();
        }

        private void tlSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DocasBLL docaBll = new DocasBLL();
                DocasDTO DocaDto = new DocasDTO();

                DocaDto.Codigo = Convert.ToInt16(txtID.Text);
                DocaDto.Cod_Funcionario = Convert.ToInt16(txtCodigoDoFunc.Text);
                DocaDto.Data_entrega = txtData.Text;
                DocaDto.Descricao1 = txtDescricao.Text;
                DocaDto.Hora_Entrega = txtHora.Text;
                DocaDto.Nome_Loja = txtNomeLoja.Text;
                DocaDto.Altura = Convert.ToDecimal(txtAltura.Text);
                DocaDto.Peso = Convert.ToDecimal(txtPeso.Text);

                

                int x = docaBll.alterar(DocaDto);
                if (x > 0)
                {
                    this.ShowMessageAsync("Sucesso!", "Dados alterados com sucesso!");
                }
               
            }
            catch (Exception erro)
            {
                this.ShowMessageAsync("Erro!", "Erro ao alterar os dados!" + erro);
            }
        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        
    }
}
