using System.Windows.Forms;
using System.Media;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using SimpleSoundboard.Properties;
using System.Resources;
using System;
using System.Reflection;

namespace SimpleSoundboard
{
    public partial class Main : Form
    {

        string[] myButtonsSound;
        string[] myButtonsPic;

        //public Main(string[] args = Environment.GetCommandLineArgs())
        public Main()
        {
            InitializeComponent();            
        }


        public void pressButton(int buttonNumber)
        {
            string name = "label_btn_no";

            foreach (Control child in this.Controls)
            {

                if (child.Name == name + buttonNumber.ToString())
                {
                    try
                    {
                        if (buttonNumber < 10)
                        {
                            SoundPlayer simpleSound = new SoundPlayer(Directory.GetCurrentDirectory() + "\\sound\\" + child.Text.Remove(0, 3));
                            simpleSound.Play();
                        }
                        else
                        {
                            SoundPlayer simpleSound = new SoundPlayer(Directory.GetCurrentDirectory() + "\\sound\\" + child.Text.Remove(0, 4));
                            simpleSound.Play();
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Fehler bei der Ausgabe des Sounds: " + child.Name);
                    }

                }
            }


        }

        public void readConfigFiles()
        {
            int i = 1;

            foreach (string line in File.ReadLines(Directory.GetCurrentDirectory() + "\\config_sound.cfg"))
            {

                listBox1.Items.Add(line.Remove(0, 3));
                i++;

            }

            MessageBox.Show(Directory.GetCurrentDirectory());

        }

        private void nameLabels()
        {
            // https://www.html.de/threads/c-button-ansprechen-ueber-namen-aus-string.34097/

            string name = "label_btn_no";
            int index = 1;
            do
            {


                foreach (Control child in this.Controls)
                {

                    if (child.Name == name + index.ToString())
                    {
                        // Nicht schön, aber funktioniert
                        string dateipfad = Directory.GetCurrentDirectory() + "\\config_sound.cfg";

                        string[] zeile = System.IO.File.ReadAllLines(dateipfad);

                        child.Text = (index) + ": " + zeile[index - 1].Remove(0, 3);

                        var textBox = child;
                        textBox.Font = new Font("Arial", 7);

                        index++;
                    }

                }
            }
            while (index < 51);
        }

        private void nameButtons()
        {
            // https://www.html.de/threads/c-button-ansprechen-ueber-namen-aus-string.34097/

            // XML-Einlesen
            // https://www.das-grosse-computer-abc.de/CSharp/XML-Verarbeitung/Dateien-lesen

            string name = "btn_no";
            int index = 1;
            do
            {
                foreach (Control child in this.Controls)
                {

                    if (child.Name == name + index.ToString())
                    {
                        // Nicht schön, aber funktioniert
                        string dateipfad = Directory.GetCurrentDirectory() + "\\config_pic.cfg";

                        string[] zeile = System.IO.File.ReadAllLines(dateipfad);

                        child.Text = ""; // index.ToString();

                        child.BackgroundImage = (Image)Image.FromFile(Directory.GetCurrentDirectory() + "\\img\\" + zeile[index - 1].Remove(0, 3));
                        child.BackgroundImageLayout = ImageLayout.Zoom;

                        index++;
                    }


                }
            }
            while (index < 51);
        }

        private void fillListBox()
        {
            DirectoryInfo pfadSound = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\sound\\");

            foreach (var fi in pfadSound.GetFiles())
            {
                listBox1.Items.Add(fi.Name);
            }
        }

        private void hideOrShow()
        {
            string name = "label_btn_no";
            int index = 1;
            do
            {


                foreach (Control child in this.Controls)
                {

                    if (child.Name == name + index.ToString())
                    {
                        if (btn_changeForm.Text == "Liste")
                        {
                            child.Visible = true;
                        }
                        else
                        {
                            child.Visible = false;
                        }

                        index++;
                    }

                }
            }
            while (index < 51);

            name = "btn_no";
            index = 1;
            do
            {
                foreach (Control child in this.Controls)
                {

                    if (child.Name == name + index.ToString())
                    {
                        if (btn_changeForm.Text == "Liste")
                        {
                            child.Visible = true;
                        }
                        else
                        {
                            child.Visible = false;
                        }
                        index++;
                    }


                }
            }
            while (index < 51);
        }

        private void btn_test_Click(object sender, EventArgs e)
        {

            //SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\IT-User\git-ea\SimpleSoundboard\sound\Ding.wav");
            //SoundPlayer simpleSound = new SoundPlayer(@"D:\Projekte\GitHub\SimpleSoundboard\sound\Ding.wav");
            //simpleSound.Play();
            //readConfigFiles();

        }




        private void Main_Load(object sender, EventArgs e)
        {
            nameLabels();
            nameButtons();
            fillListBox();
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            new SimpleSoundboard_Config().Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            // https://www.c-sharpcorner.com/UploadFile/c713c3/how-to-exit-in-C-Sharp/
            Application.Exit();
        }

        private void btn_no1_Click(Object sender, EventArgs e)
        {
            pressButton(1);
        }

        private void btn_no2_Click(object sender, EventArgs e)
        {
            pressButton(2);
        }

        private void btn_no3_Click(object sender, EventArgs e)
        {
            pressButton(3);
        }

        private void btn_no4_Click(object sender, EventArgs e)
        {
            pressButton(4);
        }

        private void btn_no5_Click(object sender, EventArgs e)
        {
            pressButton(5);
        }

        private void btn_no6_Click(object sender, EventArgs e)
        {
            pressButton(6);
        }

        private void btn_no7_Click(object sender, EventArgs e)
        {
            pressButton(7);
        }

        private void btn_no8_Click(object sender, EventArgs e)
        {
            pressButton(8);
        }

        private void btn_no9_Click(object sender, EventArgs e)
        {
            pressButton(9);
        }

        private void btn_no10_Click(object sender, EventArgs e)
        {
            pressButton(10);
        }

        private void btn_no11_Click(object sender, EventArgs e)
        {
            pressButton(11);
        }

        private void btn_no12_Click(object sender, EventArgs e)
        {
            pressButton(12);
        }

        private void btn_no13_Click(object sender, EventArgs e)
        {
            pressButton(13);
        }

        private void btn_no14_Click(object sender, EventArgs e)
        {
            pressButton(14);
        }

        private void btn_no15_Click(object sender, EventArgs e)
        {
            pressButton(15);
        }

        private void btn_no16_Click(object sender, EventArgs e)
        {
            pressButton(16);
        }

        private void btn_no17_Click(object sender, EventArgs e)
        {
            pressButton(17);
        }

        private void btn_no18_Click(object sender, EventArgs e)
        {
            pressButton(18);
        }

        private void btn_no19_Click(object sender, EventArgs e)
        {
            pressButton(19);
        }

        private void btn_no20_Click(object sender, EventArgs e)
        {
            pressButton(20);
        }

        private void btn_no21_Click(object sender, EventArgs e)
        {
            pressButton(21);
        }

        private void btn_no22_Click(object sender, EventArgs e)
        {
            pressButton(22);
        }

        private void btn_no23_Click(object sender, EventArgs e)
        {
            pressButton(23);
        }

        private void btn_no24_Click(object sender, EventArgs e)
        {
            pressButton(24);
        }

        private void btn_no25_Click(object sender, EventArgs e)
        {
            pressButton(25);
        }

        private void btn_no26_Click(object sender, EventArgs e)
        {
            pressButton(26);
        }

        private void btn_no27_Click(object sender, EventArgs e)
        {
            pressButton(27);
        }

        private void btn_no28_Click(object sender, EventArgs e)
        {
            pressButton(28);
        }

        private void btn_no29_Click(object sender, EventArgs e)
        {
            pressButton(29);
        }

        private void btn_no30_Click(object sender, EventArgs e)
        {
            pressButton(30);
        }

        private void btn_no31_Click(object sender, EventArgs e)
        {
            pressButton(31);
        }

        private void btn_no32_Click(object sender, EventArgs e)
        {
            pressButton(32);
        }

        private void btn_no33_Click(object sender, EventArgs e)
        {
            pressButton(33);
        }

        private void btn_no34_Click(object sender, EventArgs e)
        {
            pressButton(34);
        }

        private void btn_no35_Click(object sender, EventArgs e)
        {
            pressButton(35);
        }

        private void btn_no36_Click(object sender, EventArgs e)
        {
            pressButton(36);
        }

        private void btn_no37_Click(object sender, EventArgs e)
        {
            pressButton(37);
        }

        private void btn_no38_Click(object sender, EventArgs e)
        {
            pressButton(38);
        }

        private void btn_no39_Click(object sender, EventArgs e)
        {
            pressButton(39);
        }

        private void btn_no40_Click(object sender, EventArgs e)
        {
            pressButton(40);
        }

        private void btn_no41_Click(object sender, EventArgs e)
        {
            pressButton(41);
        }

        private void btn_no42_Click(object sender, EventArgs e)
        {
            pressButton(42);
        }

        private void btn_no43_Click(object sender, EventArgs e)
        {
            pressButton(43);
        }

        private void btn_no44_Click(object sender, EventArgs e)
        {
            pressButton(44);
        }

        private void btn_no45_Click(object sender, EventArgs e)
        {
            pressButton(45);
        }

        private void btn_no46_Click(object sender, EventArgs e)
        {
            pressButton(46);
        }

        private void btn_no47_Click(object sender, EventArgs e)
        {
            pressButton(47);
        }

        private void btn_no48_Click(object sender, EventArgs e)
        {
            pressButton(48);
        }

        private void btn_no49_Click(object sender, EventArgs e)
        {
            pressButton(49);
        }

        private void btn_no50_Click(object sender, EventArgs e)
        {
            pressButton(50);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            new InfoBoxLeon().Show();
        }

        private void btn_changeForm_Click(object sender, EventArgs e)
        {
            if (btn_changeForm.Text == "Liste")
            {
                this.Location = new Point(10, 10);
                this.Width = 545;
                this.Height = 1000;
                listBox1.Visible = true;
                listBox1.Height = 950;
                listBox1.SelectedIndex = 0;
                btn_config.Location = new Point(475, 12);
                btn_exit.Location = new Point(475, 150);
                btn_changeForm.Location = new Point(475, 79);
                btn_changeForm.Text = "Buttons";
                label_fuer_leon.Location = new Point(475, 329);
                hideOrShow();
            }
            else
            {
                this.Width = 1280;
                this.Height = 720; 
                listBox1.Visible = false;
                btn_config.Location = new Point(1202, 12);
                btn_exit.Location = new Point(1202, 597);
                btn_changeForm.Location = new Point(1202, 79);
                btn_changeForm.Text = "Liste";
                label_fuer_leon.Location = new Point(1221, 329);
                hideOrShow();
            }

        }


        private void listBox1_Click(object sender, EventArgs e)
        {
            try 
            {
                SoundPlayer simpleSound = new SoundPlayer(Directory.GetCurrentDirectory() + "\\sound\\" + listBox1.SelectedItem.ToString());
                simpleSound.Play();
            } 
            catch 
            {
                MessageBox.Show("Fehler bei der Soundwiedergabe. Ist die Datei im WAV-Format?");
            }
        }


        // Damit kann ich hoffentlich irgendwann pressButton(NUMMER) ersetzen
        /*
        private void buttonPress(object sender)
        {
            //int buttonNumber = 1;

            MessageBox.Show(sender.ToString());

            //pressButton(buttonNumber);
        }
        */
    }
}
