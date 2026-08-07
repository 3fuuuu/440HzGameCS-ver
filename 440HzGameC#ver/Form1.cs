using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace _440HzGameC_ver
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        int hzMin;
        int hzMax;

        int retryCount = 0;

        WaveOutEvent? waveOut;
        SignalGenerator? signal;
        System.Windows.Forms.Timer stopTimer = new System.Windows.Forms.Timer();

        int frequency
        {
            get
            {
                return trackBar1.Value;
            }
        }

        bool newBest = false;

        string mode = "main";
        public Form1()
        {
            InitializeComponent();
            stopTimer.Interval = 500; //500ms
            stopTimer.Tick += StopTimer_Tick;
            ResetGame();
        }
        private void ResetGame()
        {
            hzMin = rnd.Next(380, 421);
            hzMax = rnd.Next(440, 481);

            trackBar1.Minimum = hzMin;
            trackBar1.Maximum = hzMax;

            trackBar1.Value =
                (hzMin + hzMax) / 2;

            lblRetry.Text =
                $"Retries : {retryCount}";
        }


        private void btnRetry_Click(object sender, EventArgs e)
        {
            lblResult.Visible = false;
            lblHz.Visible = false;

            btnRetry.Visible = false;
            btnExit.Visible = false;

            btnPlay.Visible = true;
            btnEnter.Visible = true;
            trackBar1.Visible = true;

            ResetGame();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlaySound(frequency);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (frequency == 440)
            {
                mode = "win";

                lblResult.Text = "WIN";
                lblResult.Visible = true;

                btnRetry.Visible = true;
                btnExit.Visible = true;

                btnPlay.Visible = false;
                btnEnter.Visible = false;
                trackBar1.Visible = false;
            }
            else
            {
                retryCount++;

                lblRetry.Text =
                $"Retries : {retryCount}";

                mode = "lose";

                lblResult.Text = "LOSE";
                lblResult.Visible = true;

                lblHz.Visible = true;
                lblHz.Text = frequency + "Hz";

                btnRetry.Visible = true;
                btnExit.Visible = true;

                btnPlay.Visible = false;
                btnEnter.Visible = false;
                trackBar1.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void StopTimer_Tick(object? sender, EventArgs e)
        {
            stopTimer.Stop();

            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
                waveOut = null;
            }
        }
        private void PlaySound(int frequency)
        {
            if (waveOut != null)
            {
                waveOut.Stop();
                waveOut.Dispose();
            }

            signal = new SignalGenerator()
            {
                Gain = 0.3,
                Frequency = frequency,
                Type = SignalGeneratorType.Sin
            };

            waveOut = new WaveOutEvent();
            waveOut.Init(signal);

            waveOut.Play();

            stopTimer.Start();
        }

      
    }


}
