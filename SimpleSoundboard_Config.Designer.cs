namespace SimpleSoundboard
{
    partial class SimpleSoundboard_Config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleSoundboard_Config));
            label_b1 = new Label();
            cb_img_1 = new ComboBox();
            cb_sound_1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            picbox_1 = new PictureBox();
            btn_play_1 = new Button();
            btn_save = new Button();
            btn_close = new Button();
            cb_buttons = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picbox_1).BeginInit();
            SuspendLayout();
            // 
            // label_b1
            // 
            label_b1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_b1.Location = new Point(12, 16);
            label_b1.Name = "label_b1";
            label_b1.Size = new Size(100, 25);
            label_b1.TabIndex = 0;
            label_b1.Text = "Button";
            label_b1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cb_img_1
            // 
            cb_img_1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cb_img_1.FormattingEnabled = true;
            cb_img_1.Location = new Point(330, 39);
            cb_img_1.Name = "cb_img_1";
            cb_img_1.Size = new Size(300, 33);
            cb_img_1.TabIndex = 1;
            cb_img_1.SelectedIndexChanged += cb_img_1_SelectedIndexChanged;
            // 
            // cb_sound_1
            // 
            cb_sound_1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cb_sound_1.FormattingEnabled = true;
            cb_sound_1.Location = new Point(330, 101);
            cb_sound_1.Name = "cb_sound_1";
            cb_sound_1.Size = new Size(300, 33);
            cb_sound_1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(330, 18);
            label2.Name = "label2";
            label2.Size = new Size(36, 21);
            label2.TabIndex = 3;
            label2.Text = "Bild";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(330, 80);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 4;
            label3.Text = "Sound";
            // 
            // picbox_1
            // 
            picbox_1.BackgroundImageLayout = ImageLayout.Zoom;
            picbox_1.Location = new Point(636, 32);
            picbox_1.Name = "picbox_1";
            picbox_1.Size = new Size(50, 50);
            picbox_1.TabIndex = 5;
            picbox_1.TabStop = false;
            // 
            // btn_play_1
            // 
            btn_play_1.BackgroundImage = Properties.Resources.icons8_wiedergabe_eingekreist_96;
            btn_play_1.BackgroundImageLayout = ImageLayout.Zoom;
            btn_play_1.Location = new Point(636, 94);
            btn_play_1.Name = "btn_play_1";
            btn_play_1.Size = new Size(50, 50);
            btn_play_1.TabIndex = 6;
            btn_play_1.UseVisualStyleBackColor = true;
            btn_play_1.Click += btn_play_1_Click;
            // 
            // btn_save
            // 
            btn_save.BackgroundImage = Properties.Resources.icons8_speichern_96;
            btn_save.BackgroundImageLayout = ImageLayout.Zoom;
            btn_save.Location = new Point(705, 94);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(50, 50);
            btn_save.TabIndex = 12;
            btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            btn_close.BackgroundImage = Properties.Resources.icons8_ausgang_96;
            btn_close.BackgroundImageLayout = ImageLayout.Zoom;
            btn_close.Location = new Point(778, 94);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(50, 50);
            btn_close.TabIndex = 13;
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // cb_buttons
            // 
            cb_buttons.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cb_buttons.FormattingEnabled = true;
            cb_buttons.Location = new Point(12, 39);
            cb_buttons.Name = "cb_buttons";
            cb_buttons.Size = new Size(300, 33);
            cb_buttons.TabIndex = 14;
            // 
            // SimpleSoundboard_Config
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(839, 156);
            ControlBox = false;
            Controls.Add(cb_buttons);
            Controls.Add(btn_close);
            Controls.Add(btn_save);
            Controls.Add(btn_play_1);
            Controls.Add(picbox_1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cb_sound_1);
            Controls.Add(cb_img_1);
            Controls.Add(label_b1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SimpleSoundboard_Config";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Einstellungen - SimpleSoundboard";
            TopMost = true;
            Load += SimpleSoundboard_Config_Load;
            ((System.ComponentModel.ISupportInitialize)picbox_1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_b1;
        private ComboBox cb_img_1;
        private ComboBox cb_sound_1;
        private Label label2;
        private Label label3;
        private PictureBox picbox_1;
        private Button btn_play_1;
        private Button btn_play_2;
        private PictureBox picbox_2;
        private ComboBox cb_sound_2;
        private ComboBox cb_img_2;
        private Label label_b2;
        private Button btn_save;
        private Button btn_close;
        private ComboBox cb_buttons;
    }
}