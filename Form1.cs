using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMixing
{
   
    public partial class PlayTonBoy : Form
    {
        int red = 0;
        int green = 0;
        int blue = 0;
        int redStep = 1;
        int greenStep = 1;
        int blueStep = 1;
        Random rand = new Random();
        
        
        public PlayTonBoy()
        {
            InitializeComponent();
        }

        private void RandomRed_Click(object sender, EventArgs e)
        {
            int red = rand.Next(0, 256);
            RedSlider.Value = red;
            platonbox1.BackColor = Color.FromArgb( red, 0, 0);
            this.BackColor = Color.FromArgb(red, green, blue);

        }

        private void RandomGreen_Click(object sender, EventArgs e)
        {
            int green = rand.Next(0, 256);
             GreenSlider.Value = green;
            platonbox2.BackColor = Color.FromArgb(0, green, 0);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void RandomBlue_Click(object sender, EventArgs e)
        {
            int blue = rand.Next(0, 256);
             BlueSlider.Value = blue;
            platonbox3.BackColor = Color.FromArgb(0, 0, blue);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void RandomMix_Click(object sender, EventArgs e)
        {
            RandomRed_Click(sender, e);
            RandomGreen_Click(sender, e);
            RandomBlue_Click(sender, e);

            red = rand.Next(0, 256);
            green = rand.Next(0, 256);
            blue = rand.Next(0, 256);
            RedSlider.Value = red;
            GreenSlider.Value = green;
            BlueSlider.Value = blue;
            platonbox1.BackColor = Color.FromArgb(red, 0, 0);
           platonbox2.BackColor = Color.FromArgb(0, green, 0);
           platonbox3.BackColor = Color.FromArgb(0, 0, blue);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void RedSlider_Scroll(object sender, EventArgs e)
        {
            UpdateRed();

        }

        private void GreenSlider_Scroll(object sender, EventArgs e)
        {
            UpdateGreen();
        }

        private void BlueSlider_Scroll(object sender, EventArgs e)
        {
            UpdateBlue();
        }

        private void ResetColors_Click(object sender, EventArgs e)
        {


            red = 0;
            green = 0;
            blue = 0;
            RedSlider.Value = red;
            GreenSlider.Value = green;
            BlueSlider.Value = blue;
            platonbox1.BackColor = Color.FromArgb(red, 0, 0);
            platonbox2.BackColor = Color.FromArgb(0, green, 0);
            platonbox3.BackColor = Color.FromArgb(0, 0, blue);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void timerred_Tick(object sender, EventArgs e)
        {
            if(RedSlider.Value == RedSlider.Maximum)
            {
                redStep = -1;
            }

            else if(RedSlider.Value == RedSlider.Minimum)
            {
                redStep = 1;
            }

            RedSlider.Value += redStep;
            UpdateRed();
        }

        private void RedTimerStart_Click(object sender, EventArgs e)
        {
            timerred.Interval = 1;
            timerred.Start();
        }

        private void UpdateRed()
        {
            red = RedSlider.Value;
            platonbox1.BackColor = Color.FromArgb(red, 0, 0);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void UpdateGreen()
        {
            green = GreenSlider.Value;
            platonbox2.BackColor = Color.FromArgb(0, green, 0);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void UpdateBlue()
        {
            blue = BlueSlider.Value;
            platonbox3.BackColor = Color.FromArgb(0, 0, blue);
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void GreenTimerStart_Click(object sender, EventArgs e)
        {
            timergreen.Interval = 1;
            timergreen.Start();
        }

        private void BlueTimerStart_Click (object sender, EventArgs e)
        {
            timerblue.Interval = 1;
            timerblue.Start();
        }

        private void timergreen_Tick(object sender, EventArgs e)
        {
            if (GreenSlider.Value == GreenSlider.Maximum)
            {
                greenStep = -1;
            }

            else if(GreenSlider.Value == GreenSlider.Minimum)
            {
                greenStep = 1;
            }

            GreenSlider.Value += greenStep;
            UpdateGreen();
        }

        private void timerblue_Tick(object sender, EventArgs e)
        {
            if (BlueSlider.Value == BlueSlider.Maximum)
            {
                blueStep = -1;
            }

            else if(BlueSlider.Value == BlueSlider.Minimum)
            {
                blueStep = 1;
            }

            BlueSlider.Value += blueStep;
            UpdateBlue();
        }
    }
}
