using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DongHoDienTu_1512371
{
    public partial class DongHoDienTuUserControl : UserControl
    {
        //intial Time
        public int InitialMinutes = 0;
        public int InitialSeconds = 30;

        //Time that ticks
        public int Minutes = 0;
        public int Seconds = 30;

        //Event "Time over;
        public delegate void TimeOverHandler();
        public event TimeOverHandler TimeOver;

        public DongHoDienTuUserControl()
        {
            InitializeComponent();
            SetDigitPictures(Minutes, Seconds);
            this.timer1.Enabled = false;
        }

        public void SetTimer(int minutes, int seconds)
        {
            InitialMinutes = minutes;
            InitialSeconds = seconds;
            timer1.Enabled = false;
            Minutes = minutes;
            Seconds = seconds;
            SetDigitPictures(minutes, seconds);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Minutes != 0 || Seconds != 0)
            {
                if (Seconds == 0)
                {
                    Minutes--;
                    Seconds = 59;
                }
                else
                {
                    Seconds--;
                }
            }
            else
            {
                this.timer1.Enabled = false;
                TimeOver();
            }
            SetDigitPictures(Minutes, Seconds);
        }

        public void Start()
        {
            Minutes = InitialMinutes;
            Seconds = InitialSeconds;
            SetDigitPictures(Minutes, Seconds);
            timer1.Enabled = true;
        }

        public void Stop()
        {
            timer1.Enabled = false;
            Minutes = InitialMinutes;
            Seconds = InitialSeconds;
            SetDigitPictures(Minutes, Seconds);
        }

        public void Pause()
        {
            timer1.Enabled = false;
        }

        public void Resume()
        {
            timer1.Enabled = true;
        }

        private void SetDigitPictures(int minutes, int seconds)
        {
            string minutesText = minutes.ToString("00");
            string secondsText = seconds.ToString("00");
            pictureBox1.Image = (System.Drawing.Image)(Properties.Resources.ResourceManager.GetObject(minutesText[0].ToString()));
            pictureBox2.Image = (System.Drawing.Image)(Properties.Resources.ResourceManager.GetObject(minutesText[1].ToString()));
            pictureBox3.Image = (System.Drawing.Image)(Properties.Resources.ResourceManager.GetObject(secondsText[0].ToString()));
            pictureBox4.Image = (System.Drawing.Image)(Properties.Resources.ResourceManager.GetObject(secondsText[1].ToString()));
        }
    }
}
