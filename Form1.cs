using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Twitch_to_Facebook
{
    public partial class Form1 : Form
    {
        Twtfb client;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/streamlink/streamlink/releases");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ffmpeg.zeranoe.com/builds/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (MessageBox.Show("Warning: this software is delivered AS IS and without any warranty. You are fully responsible for any outcomes related to the usage of this application.", "Disclaimer", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                this.Close();
            }
            samplingrate.SelectedIndex = 0;
                
            client = new Twtfb();
            client.Load();

            facebook.Text = client.Get("facebook");
            twitch.Text = client.Get("twitch");
            streamlink_test.Text = client.Get("streamlink") == "" ? "ERROR" : "OK";
            ffmpeg_test.Text = client.Get("ffmpeg") == "" ? "ERROR" : "OK";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            client.ClearStreamlink();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            client.ClearFfmpeg();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fileOpen.Filter ="Executables|*.exe";
            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                if (client.SetStreamlink(fileOpen.FileName) == false)
                {
                    MessageBox.Show("Invalid Streamlink output.");
                    streamlink_test.Text = "ERROR";
                } else
                {
                    streamlink_test.Text = "OK";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fileOpen.Filter = "Executables|*.exe";
            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                if (client.SetFfmpeg(fileOpen.FileName) == false)
                {
                    MessageBox.Show("Invalid ffmpeg output.");
                    ffmpeg_test.Text = "ERROR";
                }
                else
                {
                    ffmpeg_test.Text = "OK";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            client.SetSamplingrate(samplingrate.SelectedItem.ToString());
            client.SetFacebook(facebook.Text);
            client.SetTwitch(twitch.Text);

            int result = client.Start();
            switch(result)
            {
                case 0:
                    MessageBox.Show("ffmpeg path not set.");
                    ffmpeg_test.Text = "ERROR";
                    break;

                case 1:
                    MessageBox.Show("Invalid ffmpeg output.");
                    ffmpeg_test.Text = "ERROR";
                    break;

                case 2:
                    MessageBox.Show("streamlink path not set.");
                    streamlink_test.Text = "ERROR";
                    break;

                case 3:
                    MessageBox.Show("Invalid streamlink output.");
                    streamlink_test.Text = "ERROR";
                    break;
                case 4:
                    MessageBox.Show("Facebook key not set.");
                    break;
                case 5:
                    MessageBox.Show("Enter Twitch account to re-stream.");
                    break;
                default:

                    break;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://idct.pl/article/twitch-to-facebook");

        }
    }
}
