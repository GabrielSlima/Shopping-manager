using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Vision.Motion;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Tcc.SEGURANCA
{
    public partial class Cameras : MetroFramework.Forms.MetroForm
    {
        public Cameras()
        {
            InitializeComponent();
        }
        private FilterInfoCollection Dispositivos;
        private VideoCaptureDevice FontesDeVideo;

        private void Cameras_Load(object sender, EventArgs e)
        {
            Dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo x in Dispositivos)
            {
                metroComboBox1.Items.Add(x.Name);
            }
            metroComboBox1.SelectedIndex = 0;
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                FontesDeVideo = new VideoCaptureDevice(Dispositivos[metroComboBox1.SelectedIndex].MonikerString);
                videoSourcePlayer1.VideoSource = FontesDeVideo;
                videoSourcePlayer1.Start();
            }
            catch (Exception erro)
            {
                videoSourcePlayer1.SignalToStop();
                MetroFramework.MetroMessageBox.Show(Owner, "Conecte uma camera!" + erro);
            }
                 
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            videoSourcePlayer1.SignalToStop();
        }
    }
}
