using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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

            DirectoryInfo pfadSound = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\sound\\");
            DirectoryInfo pfadBild = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\img\\");

            foreach (var fi in pfadSound.GetFiles())
            {
                cb_sound_1.Items.Add(fi.Name);
            }

            foreach (var fi in pfadBild.GetFiles())
            {
                cb_img_1.Items.Add(fi.Name);
            }

            // ToDo: Wähle die Einstellung aus Datei
            cb_sound_1.SelectedIndex = 0;
            cb_img_1.SelectedIndex = 0;

            string img_file = cb_img_1.Text;
            Image image = Image.FromFile(pfadBild + img_file);
            picbox_1.Image = image;
            picbox_1.SizeMode = PictureBoxSizeMode.Zoom;

            for (int i = 1; i < 51; i++)
            {
                cb_buttons.Items.Add("Button " + i);
            }

            // ToDo: Wähle die Einstellung aus Datei
            cb_buttons.SelectedIndex = 0;


        }

        private void SimpleSoundboard_Config_Load(object sender, EventArgs e)
        {
            fillContent();
        }

        private void cb_img_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // https://stackoverflow.com/questions/16966264/what-event-handler-to-use-for-combobox-item-selected-selected-item-not-necessar

            DirectoryInfo pfadBild = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\img\\");

            string img_file = cb_img_1.Text;

            Image image = Image.FromFile(pfadBild + img_file);

            picbox_1.Image = image;
            picbox_1.SizeMode = PictureBoxSizeMode.Zoom;

        }

        private void cb_buttons_SelectedIndexChanged(object sender, EventArgs e)
        {

            string dateipfad = Directory.GetCurrentDirectory();
            string[] zeile = System.IO.File.ReadAllLines(dateipfad + "\\config_pic.cfg");

            cb_img_1.Text = zeile[Int32.Parse(cb_buttons.Text.Remove(0, 7)) - 1].Remove(0, 3);

            zeile = System.IO.File.ReadAllLines(dateipfad + "\\config_sound.cfg");

            cb_sound_1.Text = zeile[Int32.Parse(cb_buttons.Text.Remove(0, 7)) - 1].Remove(0, 3);


        }

        private void btn_play_1_Click(object sender, EventArgs e)
        {
            DirectoryInfo pfadSound = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\sound\\");
            string meinSound = cb_sound_1.Text;

            SoundPlayer simpleSound = new SoundPlayer(pfadSound + meinSound);
            simpleSound.Play();
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            new Main().Show();
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string dateipfad = Directory.GetCurrentDirectory() + "\\config_pic.cfg";
            string[] zeile = System.IO.File.ReadAllLines(dateipfad);

            int buttonNumber = Int32.Parse(cb_buttons.Text.Remove(0, 7));


            if (buttonNumber < 10)
            {
                zeile[buttonNumber - 1] = "0" + buttonNumber + ":" + cb_img_1.Text;
                File.WriteAllLines(dateipfad, zeile);
            }
            else
            {
                zeile[buttonNumber - 1] = buttonNumber + ":" + cb_img_1.Text;
                File.WriteAllLines(dateipfad, zeile);
            }

            dateipfad = Directory.GetCurrentDirectory() + "\\config_sound.cfg";
            zeile = System.IO.File.ReadAllLines(dateipfad);

            if (buttonNumber < 10)
            {
                zeile[buttonNumber - 1] = "0" + buttonNumber + ":" + cb_sound_1.Text;
                File.WriteAllLines(dateipfad, zeile);
            }
            else
            {
                zeile[buttonNumber - 1] = buttonNumber + ":" + cb_sound_1.Text;
                File.WriteAllLines(dateipfad, zeile);
            }
        }
    }
}
