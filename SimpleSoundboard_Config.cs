using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Net.Mime.MediaTypeNames;

namespace SimpleSoundboard
{
    public partial class SimpleSoundboard_Config : Form
    {
        public SimpleSoundboard_Config()
        {
            InitializeComponent();
        }

        public void fillContent()
        {
            // https://learn.microsoft.com/de-de/dotnet/api/system.io.directoryinfo.getfiles?view=net-8.0

            DirectoryInfo pfadSound = new DirectoryInfo(@"C:\Users\IT-User\git-ea\SimpleSoundboard\sound\");
            DirectoryInfo pfadBild = new DirectoryInfo(@"C:\Users\IT-User\git-ea\SimpleSoundboard\img\");

            foreach (var fi in pfadSound.GetFiles())
            {
                cb_sound_1.Items.Add(fi.Name);
            }

            foreach (var fi in pfadBild.GetFiles())
            {
                cb_img_1.Items.Add(fi.Name);
            }

            // ToDo: Wähle die Einstellung aus Datei
            cb_sound_1.SelectedIndex = 4;
            cb_img_1.SelectedIndex = 0;

            string img_file = cb_img_1.Text;
            Image image = Image.FromFile("C:/Users/IT-User/git-ea/SimpleSoundboard/img/" + img_file);
            picbox_1.Image = image;
            picbox_1.SizeMode = PictureBoxSizeMode.Zoom;

            for (int i = 1; i < 50; i++) 
            { 
                cb_buttons.Items.Add("Button " + i); 
            }

        }

        private void SimpleSoundboard_Config_Load(object sender, EventArgs e)
        {
            fillContent();
        }

        private void cb_img_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // https://stackoverflow.com/questions/16966264/what-event-handler-to-use-for-combobox-item-selected-selected-item-not-necessar

            string img_file = cb_img_1.Text;
            Image image = Image.FromFile("C:/Users/IT-User/git-ea/SimpleSoundboard/img/" + img_file);

            picbox_1.Image = image;
            picbox_1.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void btn_play_1_Click(object sender, EventArgs e)
        {
            string meinSound = cb_sound_1.Text;
            SoundPlayer simpleSound = new SoundPlayer("C:/Users/IT-User/git-ea/SimpleSoundboard/sound/" + meinSound);
            simpleSound.Play();
        }

        private void btn_play_2_Click(object sender, EventArgs e)
        {
            string meinSound = cb_sound_2.Text;
            SoundPlayer simpleSound = new SoundPlayer("C:/Users/IT-User/git-ea/SimpleSoundboard/sound/" + meinSound);
            simpleSound.Play();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Close();
        }

    }
}
