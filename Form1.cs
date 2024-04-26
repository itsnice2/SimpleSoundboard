

using System.Media;

namespace SimpleSoundboard
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\IT-User\git-ea\SimpleSoundboard\sound\chimes.wav");
            simpleSound.Play();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
