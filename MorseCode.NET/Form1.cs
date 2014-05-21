using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using CWLibrary;

namespace MorseCode.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            ConvertAndPlayMorse(int.Parse(cbxWPM.SelectedItem.ToString()),double.Parse(cbxFrequency.SelectedItem.ToString()));
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            ConvertTextToMorse();
        }
        private void ConvertAndPlayMorse(int WPM, double Freqency)
        {
            TextToMorse converter = new TextToMorse(WPM, WPM, Freqency); ;
            string text = txtOriginalText.Text;

            byte[] outfile = converter.ConvertToMorse(text);
            System.Media.SoundPlayer player = new SoundPlayer(new MemoryStream(outfile));
            player.Play();

            //FileStream stream = new FileStream("hello.wav", FileMode.Create,
            //                                    FileAccess.Write);
            //stream.Write(outfile, 0, outfile.Length);
            //stream.Close();
        }

        private void ConvertTextToMorse()
        {
            TextToMorseSymbols converter = new TextToMorseSymbols();

            string text = txtOriginalText.Text;
            string symbols = converter.ConvertToMorse(text);
            txtMorseCode.Text = symbols;
        }
    }
}
