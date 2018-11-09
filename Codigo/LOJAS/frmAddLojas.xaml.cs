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
    /// Interaction logic for frmAddLojas.xaml
    /// </summary>
    public partial class frmAddLojas : MetroWindow
    {
        public frmAddLojas()
        {
            InitializeComponent();
        }
        LojasDTO lojadto = new LojasDTO();
        LojasBLL lojabll = new LojasBLL();
        private void tlSalvar_Click(object sender, RoutedEventArgs e)
        {
            lojadto.NomeFantasia = txtNomeFant.Text;
            lojadto.Nome = txtNomeLoja.Text;
                lojadto.Cnpj = txtCnpj.Text;
                lojadto.Localizacao = Convert.ToString(txtLocalizacao.Text);
          if (cboSetores.Text == "Roupas")
          {
              lojadto.Setor1 = 2;
          }
          else if (cboSetores.Text == "Alimenticio")
          {
              lojadto.Setor1 = 1;
          }
          else
          {
              lojadto.Setor1 = 3;
              this.ShowMessageAsync("Aviso!", "Manicure especial com Cidade!)");
          }
          lojabll.inserir(lojadto);
          int x = lojabll.inserir(lojadto);
          if (x > 0)
          {
              this.ShowMessageAsync("Sucesso1", "Dados incluidos com sucesso!");
          }
          else
          {
              this.ShowMessageAsync("Erro!", "Erro ao tentar inserir os dados!");
          }
        }
    }
}
