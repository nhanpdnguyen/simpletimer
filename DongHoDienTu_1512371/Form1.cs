using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DongHoDienTu_1512371
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //Subcribe a TimeOver handler, close this Form
            this.dongHoDienTuUserControl1.TimeOver += () => { this.Close();};
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            dongHoDienTuUserControl1.SetTimer(decimal.ToInt32(MinutesUpDown.Value), decimal.ToInt32(SecondsUpDown.Value));
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            dongHoDienTuUserControl1.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            dongHoDienTuUserControl1.Stop();
        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            dongHoDienTuUserControl1.Resume();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            dongHoDienTuUserControl1.Pause();
        }
    }
}
