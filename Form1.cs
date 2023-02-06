using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_SA_client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.settings.enableErrorDialogs = false;
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
           linkLabel1.Text = ("Join Official Discord");
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
            label3.Text = trackBar1.Value.ToString();
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            {
                button1.Enabled = false;
                axWindowsMediaPlayer1.settings.autoStart = true;
                axWindowsMediaPlayer1.settings.enableErrorDialogs = false;
                axWindowsMediaPlayer1.URL = " http://y0b.net/radiosa.m3u";
                label2.Text = ("Loading Radio SA");

                DateTime stopAt = DateTime.Now.AddSeconds(10);
                while (DateTime.Now < stopAt && axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    await Task.Delay(250);
                }
                button1.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                label2.Text = ("Playing Radio SA ");
                label2.ForeColor = Color.Green;
                if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    MessageBox.Show("Failed to load stream!");
                    label2.Text = ("Failed to play Radio Sa ");
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.settings.enableErrorDialogs = false;
            axWindowsMediaPlayer1.URL = "http://y0b.net/radiosa2.m3u";
            label2.Text = ("Loading Radio SA Classic");


            DateTime stopAt = DateTime.Now.AddSeconds(10);
            while (DateTime.Now < stopAt && axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                await Task.Delay(250);
            }
            button2.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            label2.Text = ("Playing Radio SA Classic");
            label2.ForeColor = Color.Black;
            if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {
                MessageBox.Show("Failed to load stream!");
                label2.Text = ("Failed to play Radio Sa Classic");
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            label2.Text = ("Idle");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private  async void  button3_Click(object sender, EventArgs e)
        {
            {
                button3.Enabled = false;
                axWindowsMediaPlayer1.settings.autoStart = true;
                axWindowsMediaPlayer1.settings.enableErrorDialogs = false;
                axWindowsMediaPlayer1.URL = "http://y0b.net/radiosa3.m3u";
                label2.Text = ("Loading Radio Sa Dance Dept");

                DateTime stopAt = DateTime.Now.AddSeconds(10);
                while (DateTime.Now < stopAt && axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    await Task.Delay(250);
                }
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                label2.Text = ("Playing Radio SA Dance Dept");
                label2.ForeColor = Color.Pink;
                if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPlaying)
                {
                    MessageBox.Show("Failed to load stream!");
                    label2.Text = ("Failed to play Radio Sa Dance Dept");
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/bfTUkAwmxD");
        }
    }
  
}


