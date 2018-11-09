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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using System.Windows.Threading;
using MahApps.Metro.Controls.Dialogs;
using Tcc.ANOTACOES;
using Tcc.SEGURANCA;
using MaterialSkin;
using MaterialSkin.Controls;
using Tcc;

namespace Tcc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
       
        public int nivel = 0;
        public MainWindow()
        {
            InitializeComponent();
           
      }

        private void startclock()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick( object sender, EventArgs e)
        {
            Login lg = new Login();
            lblHora.Content = DateTime.Now.ToLongTimeString();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login lg = new Login();
            lg.ShowDialog();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
             if (nivel == 0)
            {
                Doca.IsEnabled = false;
                Lojas.IsEnabled = false;

            }
             else if (nivel ==2)
             {
                 funcionario.IsEnabled = false;
                
                 Seguranca.IsEnabled = false;
             }
             startclock();
             lblData.Content = DateTime.Now.ToShortDateString();
           

             
           
        }

        private void lblData_Loaded(object sender, RoutedEventArgs e)
        {
            
           
        }

        private void lblHora_Loaded(object sender, RoutedEventArgs e)
        {
           

        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            Func.IsOpen = true;
        }

        private void Tile_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Ver_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void editar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Tile_Click_2(object sender, RoutedEventArgs e)
        {
            frmFuncionarios ver = new frmFuncionarios();
            ver.ShowDialog();
        }

        private void Tile_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void funcionario_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void funcionario_Click(object sender, RoutedEventArgs e)
        {
            Func.IsOpen = true;
        }

        private void Doca_Click(object sender, RoutedEventArgs e)
        {

            Docas.IsOpen = true;
            
        }

        

        private void Sair_Click(object sender, RoutedEventArgs e)
        {
            try
            {
             //   MessageDialogStyle.AffirmativeAndNegative ;
              //  this.ShowMessageAsync("Mensagem","Deseja mesmos sair ?");
                var lg = new Login();
                lg.Show();
                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro");
                return;
            }
        }

        private void Lojas_Click(object sender, RoutedEventArgs e)
        {
            loja.IsOpen = true;
        }


        //SETORES
        private void Setores_Click(object sender, RoutedEventArgs e)
        {
            setores.IsOpen = true;
        }
        private void VerSetor_Click(object sender, RoutedEventArgs e)
        {
            SETORES.frmVerSetores Ver = new SETORES.frmVerSetores();
            Ver.ShowDialog();
        }

        private void EDITSETOR_Click(object sender, RoutedEventArgs e)
        {
            SETORES.frmConfigurarSetor editar = new SETORES.frmConfigurarSetor();
            editar.ShowDialog();
        }

        private void ADDSETOR_Click(object sender, RoutedEventArgs e)
        {
            SETORES.frmAddSetor add = new SETORES.frmAddSetor();
            add.ShowDialog();
        }




        //ANOTAÇÕEs
        private void AddAnot_Click(object sender, RoutedEventArgs e)
        {
            frmAdcAnot AddAnot = new frmAdcAnot();
            AddAnot.ShowDialog();
        }
        private void Anot_Click(object sender, RoutedEventArgs e)
        {
            anotacao.IsOpen = true;
        }

        private void verAnot_Click(object sender, RoutedEventArgs e)
        {
            frmEditarAnot ver = new frmEditarAnot();
            ver.ShowDialog();
            
        }
       
        private void editAnot_Click(object sender, RoutedEventArgs e)
        {
            frmEditAnot editar = new frmEditAnot();
            editar.ShowDialog();
        }


        //FUNCIONARIOS
        private void Tile_Click_6(object sender, RoutedEventArgs e)
        {
            frmFuncionarios func = new frmFuncionarios();
            func.ShowDialog();
        }

        private void Tile_Click_7(object sender, RoutedEventArgs e)
        {
            Funcionarios.frmConfigurarFuncionario Config = new Funcionarios.frmConfigurarFuncionario();
            Config.ShowDialog();
        }



        //VEICULOS  

        private void Veiculos_Click(object sender, RoutedEventArgs e)
        {
            veiculos.IsOpen = true;
        }
        private void Tile_Click_9(object sender, RoutedEventArgs e)
        {
            VEICULOS.frmVerVeiculos Ver = new VEICULOS.frmVerVeiculos();
            Ver.ShowDialog();
        }

        private void Tile_Click_4(object sender, RoutedEventArgs e)
        {
            VEICULOS.frmConfigurarVeiculo config = new VEICULOS.frmConfigurarVeiculo();
            config.ShowDialog();
        }

        private void Tile_Click_10(object sender, RoutedEventArgs e)
        {
            VEICULOS.frmAddVeiculo Add = new VEICULOS.frmAddVeiculo();
            Add.ShowDialog();
            
        }


     
        //Docas
        private void Tile_Click_5(object sender, RoutedEventArgs e)
        {
            DOCAS.frmVerDocas ver = new DOCAS.frmVerDocas();
            ver.ShowDialog();
        }

        private void EditarDoca_Click(object sender, RoutedEventArgs e)
        {
            DOCAS.frmConfigurarDoca config = new DOCAS.frmConfigurarDoca();
            config.ShowDialog();
        }

        private void ADDDoca_Click(object sender, RoutedEventArgs e)
        {
            DOCAS.AddDocas Add = new DOCAS.AddDocas();
            Add.ShowDialog();
        }


        //LOJAS
        private void VerLoja_Click_1(object sender, RoutedEventArgs e)
        {
            LOJAS.frmVerLojas Ver = new LOJAS.frmVerLojas();
            Ver.ShowDialog();
        }

        private void EditarLoja_Click_1(object sender, RoutedEventArgs e)
        {
            LOJAS.frmConfigurarLoja config = new LOJAS.frmConfigurarLoja();
            config.ShowDialog();
        }

        private void AddLoja_Click(object sender, RoutedEventArgs e)
        {
            LOJAS.frmAddLoja add = new LOJAS.frmAddLoja();
            add.ShowDialog();
        }

        private void tlAddFunc_Click(object sender, RoutedEventArgs e)
        {
            Funcionarios.frmAdcFunc Add = new Funcionarios.frmAdcFunc();
            Add.ShowDialog();
        }
        //CAMERAS
        private void Seguranca_Click(object sender, RoutedEventArgs e)
        {
            Cameras cam = new Cameras();
            cam.ShowDialog();
        }

        private void FlipView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var flipview = ((FlipView)sender);
            switch (flipview.SelectedIndex)
            {
                case 0:
                    flipview.BannerText = "Aplicativos.";
                    
                    break;
                case 1:
                    flipview.BannerText = "Paginas web.";
                    
                    break;
                case 2:
                    flipview.BannerText = "HighSoftware.";
                    break;
            }
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_Loaded_2(object sender, RoutedEventArgs e)
        {

        }

        private void Tile_Click_8(object sender, RoutedEventArgs e)
        {
            frmAddUser adduser = new frmAddUser();
            adduser.ShowDialog();
        }

        private void funcionario_MouseLeave(object sender, MouseEventArgs e)
        {
            lblData.Content = DateTime.Now.ToShortDateString();
        }

        private void funcionario_MouseMove(object sender, MouseEventArgs e)
        {
            lblData.Content = "Funcionários";
        }

        private void Doca_MouseLeave(object sender, MouseEventArgs e)
        {
            lblData.Content = DateTime.Now.ToShortDateString();
        }

        private void Doca_MouseMove(object sender, MouseEventArgs e)
        {
            lblData.Content = "Docas";
        }

        private void Lojas_MouseLeave(object sender, MouseEventArgs e)
        {
            lblData.Content = DateTime.Now.ToShortDateString();
        }

        private void Lojas_MouseMove(object sender, MouseEventArgs e)
        {
            lblData.Content = "Lojas";
        }

        private void Setores_MouseLeave(object sender, MouseEventArgs e)
        {
            lblData.Content = DateTime.Now.ToShortDateString();
        }

        private void Setores_MouseMove(object sender, MouseEventArgs e)
        {
            lblData.Content = "Setores";
        }

        private void Veiculos_MouseLeave(object sender, MouseEventArgs e)
        {
            lblData.Content = DateTime.Now.ToShortDateString();
        }

        private void Veiculos_MouseMove(object sender, MouseEventArgs e)
        {
            lblData.Content = "Veículos";
        }

        private void Anot_MouseLeave(object sender, MouseEventArgs e)
        {
            lblData.Content = DateTime.Now.ToShortDateString();
        }

        private void Anot_MouseMove(object sender, MouseEventArgs e)
        {
            lblData.Content = "Anotações";
        }

        private void Seguranca_MouseLeave(object sender, MouseEventArgs e)
        {
            lblData.Content = DateTime.Now.ToShortDateString();
        }

        private void Seguranca_MouseMove(object sender, MouseEventArgs e)
        {
            lblData.Content = "Câmeras";
        }

        private void FlipView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            /* ta aqui doidoooooooooooooooooooo
             * oooooooooooooooooooooooo
             * ooooooooooooooo */
            System.Diagnostics.Process.Start("file:C:/Users/3ainfo/Desktop/Tcc/Mensagem.bat");
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            lblData.Content = DateTime.Now.ToShortDateString();
        }

        private void Grid_MouseLeave_1(object sender, MouseEventArgs e)
        {
            lblData.Content = DateTime.Now.ToShortDateString();
        }

        private void Grid_MouseMove_1(object sender, MouseEventArgs e)
        {
            lblData.Content = "Duplo clique para ver mais sobre a empresa!";
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {

        }
      } 
  }
