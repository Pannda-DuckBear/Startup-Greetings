using System;
using System.Collections;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.IO;
using System.Threading.Tasks;

namespace Sound_Greetings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Startup Greetings!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1,000 milliseconds = 1 second
            // 60,000 milliseconds = 1 minute (60 seconds)

            Thread.Sleep(7000); // voicemeeter startup wait

            #region get random file
            var rand = new Random();
            var files = Directory.GetFiles(@"C:\Users\User\Desktop\Sound Greetings\Sound Files", "*.wav");
            int i = rand.Next(0, files.Length);
            var file = files[i];
            #endregion
            #region play audio
            SoundPlayer sp = new SoundPlayer(file);
            sp.Play();
            #endregion
            #region set text
            string newTitle = file.Substring(file.LastIndexOf('\\') + 1); // removes the directory
            newTitle = newTitle.Remove(newTitle.Length - 4); // removes the file type at the end of the text
            label1.Text = newTitle; // sets the text to the new file name
            #endregion

            #region first pass // inactive
            /*SoundPlayer ss = new SoundPlayer();
            
            Random r = new Random();
            int target = r.Next(0, 12); // there are 11 Japanese greetings

            if (target == 0)
            {
                ss = new SoundPlayer(@"C:\Users\User\Desktop\Sound Greetings\Sound Files\Kon'nichiwa こんにちは.wav");
                label1.Text = "Hello!";
            }
            else if (target == 1)
            {
                ss = new SoundPlayer(@"C:\Users\User\Desktop\Sound Greetings\Sound Files\EngineRevving エンジンの回転数 .wav");
                label1.Text = "Engine revving!";
            }
            else if (target == 2)
            {
                ss = new SoundPlayer(@"C:\Users\User\Desktop\Sound Greetings\Sound Files\HelloAgain またあったね .wav");
                label1.Text = "Hello again";
            }
            else if (target == 3)
            {
                ss = new SoundPlayer(@"C:\Users\User\Desktop\Sound Greetings\Sound Files\LetsDoOurBestToday 今日も頑張りましょう .wav");
                label1.Text = "Lets do our best today";
            }
            else if (target == 4)
            {
                ss = new SoundPlayer(@"C:\Users\User\Desktop\Sound Greetings\Sound Files\LetsDoOurBestToday2 今日も頑張りましょう .wav");
                label1.Text = "Lets do our best today!";
            }
            else if (target == 5)
            {
                ss = new SoundPlayer(@"C:\Users\User\Desktop\Sound Greetings\Sound Files\ReadyToGo 準備完了 .wav");
                label1.Text = "Ready to go!";
            }
            else if (target == 6)
            {
                ss = new SoundPlayer(@"C:\Users\User\Desktop\Sound Greetings\Sound Files\LetsGetToWork 仕事に取り掛かりましょう .wav");
                label1.Text = "Lets get to work!";
            }
            else if (target == 7)
            {
                ss = new SoundPlayer(@"C:\Users\User\Desktop\Sound Greetings\Sound Files\SeizeTheDay その日を摘め .wav");
                label1.Text = "Seize the day!";
            }
            else if (target == 8)
            {
                ss = new SoundPlayer(@"C:\Users\User\Desktop\Sound Greetings\Sound Files\WelcomeHome おかえりなさい .wav");
                label1.Text = "Welcome home!";
            }
            else if (target == 9)
            {
                ss = new SoundPlayer(@"C:\Users\User\Desktop\Sound Greetings\Sound Files\WelcomeHome2 おかえりなさい .wav");
                label1.Text = "Welcome home";
            }
            else if (target == 10)
            {
                ss = new SoundPlayer(@"C:\Users\User\Desktop\Sound Greetings\Sound Files\SystemsOverclocked システムがオーバークロックされました .wav");
                label1.Text = "Systems overclocked!";
            }

            ss.Play();
            */
            #endregion

            #region auto close
            /*
            Thread.Sleep(10000);
            Application.Exit();
            */
            #endregion
        }
    }
}
