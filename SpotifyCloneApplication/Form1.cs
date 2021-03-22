using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SpotifyCloneApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = "";

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";

        }

        ArrayList muzikler = new ArrayList();

        string a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15;
        private int sayi = 0;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); //öncelikle dosya ekranını açtırıcaz butona tıklayıp.
            for (int i=0;i<openFileDialog1.SafeFileNames.Length;i++)
            {
                 muzikler.Add(openFileDialog1.FileNames[i].ToString());

            }
            
            

            axWindowsMediaPlayer1.URL = muzikler[0].ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            button12.Image = Properties.Resources.pau;
            resim.Image = Properties.Resources.istanbul_trip;

            timer1.Start();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            if (muzikler.Count == 1)
            {

            }
            else
            {
                sayi++;
                axWindowsMediaPlayer1.URL = muzikler[sayi].ToString();
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            
            if (muzikler.Count == 1)
            {

            }

            if (sayi==0)
            {

            }
            else
            {
                sayi--;
                axWindowsMediaPlayer1.URL = muzikler[sayi].ToString();
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            label5.Text =axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
            string degerim = axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration.ToString();
            int deger = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            bunifuSlider1.Value = deger;
            

        }

        private void bunifuTrackbar1_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = bunifuTrackbar1.Value; // trackbar değiştiği zaman volumu artacak veya azalacak.
        }
        int tıklanma = 0;
        private void button12_Click(object sender, EventArgs e)
        {
            tıklanma++;
            if (tıklanma%2==0)
            {
                // play.
                axWindowsMediaPlayer1.Ctlcontrols.play();
                button12.Image =Properties.Resources.pau;
            }

            else
            {
                // pause.
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                button12.Image = Properties.Resources.pl;
            }
        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuSlider1_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = bunifuSlider1.Value;
        }

        private void panel10_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel8_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel7_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel9_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel11_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void label20_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = muzikler[0].ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            lblisim.Text = label20.Text;
            lblsanatcı.Text = label19.Text;
            panel10.BackColor = Color.FromArgb(40,40,40);
            button17.BackColor = Color.FromArgb(40, 40, 40);
            resim.Image = Properties.Resources.istanbul_trip;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = muzikler[1].ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            lblisim.Text = label12.Text;
            lblsanatcı.Text = label11.Text;
            panel8.BackColor = Color.FromArgb(40, 40, 40);
            button15.BackColor = Color.FromArgb(40, 40, 40);
            resim.Image = Properties.Resources.ceza;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = muzikler[2].ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            lblisim.Text = label8.Text;
            lblsanatcı.Text = "Dwin";
            panel7.BackColor = Color.FromArgb(40, 40, 40);
            button14.BackColor = Color.FromArgb(40, 40, 40);
            resim.Image = Properties.Resources.dwin;

        }

        private void label16_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = muzikler[3].ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            lblisim.Text = label16.Text;
            lblsanatcı.Text = "Mero - Eno";
            panel9.BackColor = Color.FromArgb(40, 40, 40);
            button16.BackColor = Color.FromArgb(40, 40, 40);
            resim.Image = Properties.Resources.mero;
        }

        private void label24_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = muzikler[4].ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            lblisim.Text = label24.Text;
            lblsanatcı.Text = "Ezhel - Kelvyn Colt";
            panel11.BackColor = Color.FromArgb(40, 40, 40);
            button18.BackColor = Color.FromArgb(40, 40, 40);
            resim.Image = Properties.Resources.ezhel;
        }

        private void label28_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = muzikler[5].ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            lblisim.Text = label28.Text;
            lblsanatcı.Text = "Gazapizm";
            panel12.BackColor = Color.FromArgb(40, 40, 40);
            button19.BackColor = Color.FromArgb(40, 40, 40);
            resim.Image = Properties.Resources.hiza;
        }

        private void label32_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = muzikler[6].ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            lblisim.Text = label32.Text;
            lblsanatcı.Text = "Gentleman";
            panel13.BackColor = Color.FromArgb(40, 40, 40);
            button20.BackColor = Color.FromArgb(40, 40, 40);
            resim.Image = Properties.Resources.ezhel;
        }

        private void label36_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = muzikler[7].ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            lblisim.Text = label36.Text;
            lblsanatcı.Text = "Masked Wolf";
            panel14.BackColor = Color.FromArgb(40, 40, 40);
            button21.BackColor = Color.FromArgb(40, 40, 40);
            resim.Image = Properties.Resources.astronot;
        }

        private void label40_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = muzikler[8].ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            lblisim.Text = label40.Text;
            lblsanatcı.Text = "Mero";
            panel15.BackColor = Color.FromArgb(40, 40, 40);
            button22.BackColor = Color.FromArgb(40, 40, 40);
            resim.Image = Properties.Resources.mero;
        }

        private void label44_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = muzikler[9].ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            lblisim.Text = label44.Text;
            lblsanatcı.Text = "Eduardo Luzquinos";
            panel16.BackColor = Color.FromArgb(40, 40, 40);
            button23.BackColor = Color.FromArgb(40, 40, 40);
            resim.Image = Properties.Resources.callin;
        }

        private void label48_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = muzikler[10].ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            lblisim.Text = label48.Text;
            lblsanatcı.Text = "Andery";
            panel17.BackColor = Color.FromArgb(40, 40, 40);
            button24.BackColor = Color.FromArgb(40, 40, 40);
            resim.Image = Properties.Resources.pewetoo;
        }

        private void label52_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = muzikler[11].ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            lblisim.Text = label52.Text;
            lblsanatcı.Text = "Yüzyüzeyken";
            panel18.BackColor = Color.FromArgb(40, 40, 40);
            button25.BackColor = Color.FromArgb(40, 40, 40);
            resim.Image = Properties.Resources.yüzyüze;
        }

        private void label56_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = muzikler[12].ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            lblisim.Text = label56.Text;
            lblsanatcı.Text = "Hopex";
            panel19.BackColor = Color.FromArgb(40, 40, 40);
            button26.BackColor = Color.FromArgb(40, 40, 40);
            resim.Image = Properties.Resources.hope;
        }

        private void label60_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = muzikler[13].ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            lblisim.Text = label60.Text;
            lblsanatcı.Text ="Xir";
            panel20.BackColor = Color.FromArgb(40, 40, 40);
            button27.BackColor = Color.FromArgb(40, 40, 40);
            resim.Image = Properties.Resources.istanbul_trip;

        }

        private void label64_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = muzikler[14].ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
            lblisim.Text = label64.Text;
            lblsanatcı.Text ="Y2K";
            panel21.BackColor = Color.FromArgb(40, 40, 40);
            button28.BackColor = Color.FromArgb(40, 40, 40);
            resim.Image = Properties.Resources.y2k;
        }

        private void panel12_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel13_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel14_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel15_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel16_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel17_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel18_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel19_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel20_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel21_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel8_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panel7_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panel9_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void label28_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}






































