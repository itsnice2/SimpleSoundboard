using System.Windows.Forms;
using System.Media;

namespace SimpleSoundboard
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //public string Button1 = "1";

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
                        child.Text = index.ToString();

                        listBox1.Items.Add(child.Name.ToString());
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
                        child.Text = index.ToString();
                        
                        //listBox1.Items.Add(child.Name.ToString());
                        index++;
                    }


                }
            }
            while (index < 51);
        }

        private void btn_test_Click(object sender, EventArgs e)
        {

            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\IT-User\git-ea\SimpleSoundboard\sound\Ding.wav");
            simpleSound.Play();

        }

        private void btn_no1_Click(Object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\IT-User\git-ea\SimpleSoundboard\sound\Ding.wav");
            simpleSound.Play();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            nameLabels();
            nameButtons();
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
    }
}
