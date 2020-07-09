namespace SpaceGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plMulti1 = new System.Windows.Forms.Panel();
            this.vilansPick = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.heroesPick = new System.Windows.Forms.Button();
            this.btnBackMulti1 = new System.Windows.Forms.Button();
            this.btnNextMulti1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.plMulti2 = new System.Windows.Forms.Panel();
            this.btnBackMulti2 = new System.Windows.Forms.Button();
            this.btnNextMulti2 = new System.Windows.Forms.Button();
            this.plMulti3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMulti3Start = new System.Windows.Forms.Button();
            this.btnBackMulti3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.plMain = new System.Windows.Forms.Panel();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnMultiplayer = new System.Windows.Forms.Button();
            this.superHotbtn = new System.Windows.Forms.Button();
            this.gameName = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.teamScore = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.plEnd = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.labelWin = new System.Windows.Forms.Label();
            this.plPause = new System.Windows.Forms.Panel();
            this.btnResume = new System.Windows.Forms.Button();
            this.playAgainbtn = new System.Windows.Forms.Button();
            this.btnPauseQuit = new System.Windows.Forms.Button();
            this.plSuperHot = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSuperHotStart = new System.Windows.Forms.Button();
            this.btnBackSuperHot = new System.Windows.Forms.Button();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.plMulti1.SuspendLayout();
            this.plMulti2.SuspendLayout();
            this.plMulti3.SuspendLayout();
            this.plMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.plEnd.SuspendLayout();
            this.plPause.SuspendLayout();
            this.plSuperHot.SuspendLayout();
            this.SuspendLayout();
            // 
            // plMulti1
            // 
            this.plMulti1.BackColor = System.Drawing.Color.Transparent;
            this.plMulti1.BackgroundImage = global::SpaceGame.Properties.Resources.plmainbackground;
            this.plMulti1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plMulti1.Controls.Add(this.vilansPick);
            this.plMulti1.Controls.Add(this.label2);
            this.plMulti1.Controls.Add(this.heroesPick);
            this.plMulti1.Controls.Add(this.btnBackMulti1);
            this.plMulti1.Controls.Add(this.btnNextMulti1);
            this.plMulti1.Controls.Add(this.label1);
            this.plMulti1.Controls.Add(this.comboBox2);
            this.plMulti1.Controls.Add(this.comboBox1);
            this.plMulti1.Location = new System.Drawing.Point(393, 3);
            this.plMulti1.Name = "plMulti1";
            this.plMulti1.Size = new System.Drawing.Size(385, 496);
            this.plMulti1.TabIndex = 1;
            this.plMulti1.Visible = false;
            // 
            // vilansPick
            // 
            this.vilansPick.BackgroundImage = global::SpaceGame.Properties.Resources.person_white;
            this.vilansPick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vilansPick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vilansPick.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.vilansPick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.vilansPick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(181)))), ((int)(((byte)(195)))));
            this.vilansPick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vilansPick.Location = new System.Drawing.Point(268, 163);
            this.vilansPick.Name = "vilansPick";
            this.vilansPick.Size = new System.Drawing.Size(48, 48);
            this.vilansPick.TabIndex = 10;
            this.vilansPick.Tag = "on";
            this.vilansPick.UseVisualStyleBackColor = true;
            this.vilansPick.Click += new System.EventHandler(this.player_bot);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(244, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "VILLAINS";
            // 
            // heroesPick
            // 
            this.heroesPick.BackgroundImage = global::SpaceGame.Properties.Resources.person_white;
            this.heroesPick.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.heroesPick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.heroesPick.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.heroesPick.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.heroesPick.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.heroesPick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.heroesPick.Location = new System.Drawing.Point(113, 163);
            this.heroesPick.Name = "heroesPick";
            this.heroesPick.Size = new System.Drawing.Size(48, 48);
            this.heroesPick.TabIndex = 8;
            this.heroesPick.Tag = "on";
            this.heroesPick.UseVisualStyleBackColor = true;
            this.heroesPick.Click += new System.EventHandler(this.player_bot);
            // 
            // btnBackMulti1
            // 
            this.btnBackMulti1.BackColor = System.Drawing.Color.Transparent;
            this.btnBackMulti1.BackgroundImage = global::SpaceGame.Properties.Resources.back;
            this.btnBackMulti1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackMulti1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackMulti1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBackMulti1.FlatAppearance.BorderSize = 0;
            this.btnBackMulti1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBackMulti1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBackMulti1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackMulti1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBackMulti1.Location = new System.Drawing.Point(52, 402);
            this.btnBackMulti1.Name = "btnBackMulti1";
            this.btnBackMulti1.Size = new System.Drawing.Size(48, 48);
            this.btnBackMulti1.TabIndex = 6;
            this.btnBackMulti1.UseVisualStyleBackColor = false;
            this.btnBackMulti1.Click += new System.EventHandler(this.btnBackMulti1_Click);
            // 
            // btnNextMulti1
            // 
            this.btnNextMulti1.BackgroundImage = global::SpaceGame.Properties.Resources.back;
            this.btnNextMulti1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextMulti1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextMulti1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNextMulti1.FlatAppearance.BorderSize = 0;
            this.btnNextMulti1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNextMulti1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNextMulti1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextMulti1.Location = new System.Drawing.Point(311, 402);
            this.btnNextMulti1.Name = "btnNextMulti1";
            this.btnNextMulti1.Size = new System.Drawing.Size(48, 48);
            this.btnNextMulti1.TabIndex = 5;
            this.btnNextMulti1.UseVisualStyleBackColor = true;
            this.btnNextMulti1.Click += new System.EventHandler(this.btnNextMulti1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(91, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "HEROES";
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox2.Location = new System.Drawing.Point(277, 227);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(31, 24);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Teal;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(120, 227);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(31, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // plMulti2
            // 
            this.plMulti2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(112)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.plMulti2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plMulti2.Controls.Add(this.btnBackMulti2);
            this.plMulti2.Controls.Add(this.btnNextMulti2);
            this.plMulti2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.plMulti2.Location = new System.Drawing.Point(1189, 12);
            this.plMulti2.Name = "plMulti2";
            this.plMulti2.Size = new System.Drawing.Size(232, 128);
            this.plMulti2.TabIndex = 2;
            this.plMulti2.Visible = false;
            // 
            // btnBackMulti2
            // 
            this.btnBackMulti2.BackColor = System.Drawing.Color.Transparent;
            this.btnBackMulti2.BackgroundImage = global::SpaceGame.Properties.Resources.back;
            this.btnBackMulti2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackMulti2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackMulti2.FlatAppearance.BorderSize = 0;
            this.btnBackMulti2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBackMulti2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBackMulti2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackMulti2.Location = new System.Drawing.Point(18, 50);
            this.btnBackMulti2.Name = "btnBackMulti2";
            this.btnBackMulti2.Size = new System.Drawing.Size(48, 48);
            this.btnBackMulti2.TabIndex = 2;
            this.btnBackMulti2.Tag = "";
            this.btnBackMulti2.UseVisualStyleBackColor = false;
            this.btnBackMulti2.Click += new System.EventHandler(this.btnBackMulti2_Click);
            // 
            // btnNextMulti2
            // 
            this.btnNextMulti2.BackColor = System.Drawing.Color.Transparent;
            this.btnNextMulti2.BackgroundImage = global::SpaceGame.Properties.Resources.back;
            this.btnNextMulti2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextMulti2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextMulti2.FlatAppearance.BorderSize = 0;
            this.btnNextMulti2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNextMulti2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNextMulti2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextMulti2.Location = new System.Drawing.Point(175, 50);
            this.btnNextMulti2.Name = "btnNextMulti2";
            this.btnNextMulti2.Size = new System.Drawing.Size(48, 48);
            this.btnNextMulti2.TabIndex = 1;
            this.btnNextMulti2.UseVisualStyleBackColor = false;
            this.btnNextMulti2.Click += new System.EventHandler(this.btnNextMulti2_Click);
            // 
            // plMulti3
            // 
            this.plMulti3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(112)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.plMulti3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plMulti3.Controls.Add(this.textBox1);
            this.plMulti3.Controls.Add(this.label3);
            this.plMulti3.Controls.Add(this.btnMulti3Start);
            this.plMulti3.Controls.Add(this.btnBackMulti3);
            this.plMulti3.ForeColor = System.Drawing.SystemColors.Control;
            this.plMulti3.Location = new System.Drawing.Point(1189, 253);
            this.plMulti3.Name = "plMulti3";
            this.plMulti3.Size = new System.Drawing.Size(412, 203);
            this.plMulti3.TabIndex = 6;
            this.plMulti3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(190, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 49);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Agency FB", 72F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(73, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 116);
            this.label3.TabIndex = 2;
            this.label3.Text = "FIRST TO";
            // 
            // btnMulti3Start
            // 
            this.btnMulti3Start.BackColor = System.Drawing.Color.Transparent;
            this.btnMulti3Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMulti3Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMulti3Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMulti3Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMulti3Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMulti3Start.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulti3Start.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMulti3Start.Location = new System.Drawing.Point(284, 133);
            this.btnMulti3Start.Name = "btnMulti3Start";
            this.btnMulti3Start.Size = new System.Drawing.Size(76, 48);
            this.btnMulti3Start.TabIndex = 1;
            this.btnMulti3Start.Text = "START";
            this.btnMulti3Start.UseVisualStyleBackColor = false;
            this.btnMulti3Start.Click += new System.EventHandler(this.btnMulti3Start_Click);
            // 
            // btnBackMulti3
            // 
            this.btnBackMulti3.BackColor = System.Drawing.Color.Transparent;
            this.btnBackMulti3.BackgroundImage = global::SpaceGame.Properties.Resources.back;
            this.btnBackMulti3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackMulti3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackMulti3.FlatAppearance.BorderSize = 0;
            this.btnBackMulti3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBackMulti3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBackMulti3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackMulti3.Location = new System.Drawing.Point(31, 130);
            this.btnBackMulti3.Name = "btnBackMulti3";
            this.btnBackMulti3.Size = new System.Drawing.Size(48, 48);
            this.btnBackMulti3.TabIndex = 0;
            this.btnBackMulti3.UseVisualStyleBackColor = false;
            this.btnBackMulti3.Click += new System.EventHandler(this.btnBackMulti3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 5;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.Color.Transparent;
            this.plMain.BackgroundImage = global::SpaceGame.Properties.Resources.plmainbackground;
            this.plMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plMain.Controls.Add(this.btnOptions);
            this.plMain.Controls.Add(this.btnQuit);
            this.plMain.Controls.Add(this.btnMultiplayer);
            this.plMain.Controls.Add(this.superHotbtn);
            this.plMain.Location = new System.Drawing.Point(2, 3);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(385, 496);
            this.plMain.TabIndex = 0;
            // 
            // btnOptions
            // 
            this.btnOptions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOptions.BackgroundImage")));
            this.btnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Location = new System.Drawing.Point(78, 250);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(257, 92);
            this.btnOptions.TabIndex = 2;
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.BackgroundImage = global::SpaceGame.Properties.Resources.exitgamebtn;
            this.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Location = new System.Drawing.Point(78, 350);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(257, 92);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnMultiplayer
            // 
            this.btnMultiplayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMultiplayer.BackgroundImage")));
            this.btnMultiplayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMultiplayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiplayer.FlatAppearance.BorderSize = 0;
            this.btnMultiplayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMultiplayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMultiplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplayer.Location = new System.Drawing.Point(78, 56);
            this.btnMultiplayer.Name = "btnMultiplayer";
            this.btnMultiplayer.Size = new System.Drawing.Size(257, 92);
            this.btnMultiplayer.TabIndex = 1;
            this.btnMultiplayer.UseVisualStyleBackColor = true;
            this.btnMultiplayer.Click += new System.EventHandler(this.btnMultiplayer_Click);
            // 
            // superHotbtn
            // 
            this.superHotbtn.BackgroundImage = global::SpaceGame.Properties.Resources.supehotbtn;
            this.superHotbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.superHotbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.superHotbtn.FlatAppearance.BorderSize = 0;
            this.superHotbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.superHotbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.superHotbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.superHotbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.superHotbtn.Location = new System.Drawing.Point(78, 152);
            this.superHotbtn.Name = "superHotbtn";
            this.superHotbtn.Size = new System.Drawing.Size(257, 92);
            this.superHotbtn.TabIndex = 0;
            this.superHotbtn.UseVisualStyleBackColor = true;
            this.superHotbtn.Click += new System.EventHandler(this.superHotbtn_Click);
            // 
            // gameName
            // 
            this.gameName.BackColor = System.Drawing.Color.Transparent;
            this.gameName.BackgroundImage = global::SpaceGame.Properties.Resources.spaceshooter;
            this.gameName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameName.Location = new System.Drawing.Point(-19, 531);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(466, 171);
            this.gameName.TabIndex = 7;
            this.gameName.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SpaceGame.Properties.Resources.ship2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 509);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 215);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::SpaceGame.Properties.Resources.ship1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(80, 557);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(187, 118);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::SpaceGame.Properties.Resources.ship0;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(213, 539);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(186, 185);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::SpaceGame.Properties.Resources.ship4;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(170, 539);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(192, 163);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::SpaceGame.Properties.Resources.ship3;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(127, 539);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(177, 138);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // teamScore
            // 
            this.teamScore.AutoSize = true;
            this.teamScore.Font = new System.Drawing.Font("Agency FB", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamScore.ForeColor = System.Drawing.Color.White;
            this.teamScore.Location = new System.Drawing.Point(1221, 176);
            this.teamScore.Name = "teamScore";
            this.teamScore.Size = new System.Drawing.Size(71, 55);
            this.teamScore.TabIndex = 14;
            this.teamScore.Text = "0:0";
            this.teamScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.teamScore.Visible = false;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // plEnd
            // 
            this.plEnd.BackColor = System.Drawing.Color.Transparent;
            this.plEnd.Controls.Add(this.button3);
            this.plEnd.Controls.Add(this.btnPlayAgain);
            this.plEnd.Controls.Add(this.labelWin);
            this.plEnd.Location = new System.Drawing.Point(453, 528);
            this.plEnd.Name = "plEnd";
            this.plEnd.Size = new System.Drawing.Size(457, 200);
            this.plEnd.TabIndex = 15;
            this.plEnd.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(264, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "EXIT GAME";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayAgain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlayAgain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.White;
            this.btnPlayAgain.Location = new System.Drawing.Point(65, 124);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(129, 40);
            this.btnPlayAgain.TabIndex = 1;
            this.btnPlayAgain.Text = "PLAY AGAIN";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.Font = new System.Drawing.Font("Agency FB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWin.ForeColor = System.Drawing.Color.Teal;
            this.labelWin.Location = new System.Drawing.Point(3, 4);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(454, 116);
            this.labelWin.TabIndex = 0;
            this.labelWin.Text = "HEROES WON";
            // 
            // plPause
            // 
            this.plPause.BackColor = System.Drawing.Color.Transparent;
            this.plPause.BackgroundImage = global::SpaceGame.Properties.Resources.pauseBackground;
            this.plPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plPause.Controls.Add(this.btnResume);
            this.plPause.Controls.Add(this.playAgainbtn);
            this.plPause.Controls.Add(this.btnPauseQuit);
            this.plPause.Location = new System.Drawing.Point(784, 3);
            this.plPause.Name = "plPause";
            this.plPause.Size = new System.Drawing.Size(385, 496);
            this.plPause.TabIndex = 17;
            this.plPause.Visible = false;
            // 
            // btnResume
            // 
            this.btnResume.BackgroundImage = global::SpaceGame.Properties.Resources.resumebtn;
            this.btnResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResume.FlatAppearance.BorderSize = 0;
            this.btnResume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResume.Location = new System.Drawing.Point(78, 136);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(257, 92);
            this.btnResume.TabIndex = 4;
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // playAgainbtn
            // 
            this.playAgainbtn.BackgroundImage = global::SpaceGame.Properties.Resources.playagainbtn;
            this.playAgainbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playAgainbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playAgainbtn.FlatAppearance.BorderSize = 0;
            this.playAgainbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playAgainbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playAgainbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playAgainbtn.Location = new System.Drawing.Point(79, 239);
            this.playAgainbtn.Name = "playAgainbtn";
            this.playAgainbtn.Size = new System.Drawing.Size(257, 92);
            this.playAgainbtn.TabIndex = 3;
            this.playAgainbtn.UseVisualStyleBackColor = true;
            this.playAgainbtn.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnPauseQuit
            // 
            this.btnPauseQuit.BackgroundImage = global::SpaceGame.Properties.Resources.exitgamebtn;
            this.btnPauseQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPauseQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPauseQuit.FlatAppearance.BorderSize = 0;
            this.btnPauseQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPauseQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPauseQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPauseQuit.Location = new System.Drawing.Point(78, 343);
            this.btnPauseQuit.Name = "btnPauseQuit";
            this.btnPauseQuit.Size = new System.Drawing.Size(257, 92);
            this.btnPauseQuit.TabIndex = 2;
            this.btnPauseQuit.UseVisualStyleBackColor = true;
            this.btnPauseQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // plSuperHot
            // 
            this.plSuperHot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(112)))), ((int)(((byte)(227)))), ((int)(((byte)(254)))));
            this.plSuperHot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plSuperHot.Controls.Add(this.comboBox3);
            this.plSuperHot.Controls.Add(this.label4);
            this.plSuperHot.Controls.Add(this.btnSuperHotStart);
            this.plSuperHot.Controls.Add(this.btnBackSuperHot);
            this.plSuperHot.ForeColor = System.Drawing.SystemColors.Control;
            this.plSuperHot.Location = new System.Drawing.Point(933, 521);
            this.plSuperHot.Name = "plSuperHot";
            this.plSuperHot.Size = new System.Drawing.Size(412, 203);
            this.plSuperHot.TabIndex = 18;
            this.plSuperHot.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.Color.DarkRed;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "EASY",
            "MEDIUM",
            "HARD",
            "EXTREME"});
            this.comboBox3.Location = new System.Drawing.Point(99, 134);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(126, 24);
            this.comboBox3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Agency FB", 72F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(27, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(380, 116);
            this.label4.TabIndex = 2;
            this.label4.Text = "DIFFICULTY";
            // 
            // btnSuperHotStart
            // 
            this.btnSuperHotStart.BackColor = System.Drawing.Color.Transparent;
            this.btnSuperHotStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuperHotStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuperHotStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSuperHotStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSuperHotStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuperHotStart.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuperHotStart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSuperHotStart.Location = new System.Drawing.Point(291, 134);
            this.btnSuperHotStart.Name = "btnSuperHotStart";
            this.btnSuperHotStart.Size = new System.Drawing.Size(76, 48);
            this.btnSuperHotStart.TabIndex = 1;
            this.btnSuperHotStart.Text = "START";
            this.btnSuperHotStart.UseVisualStyleBackColor = false;
            this.btnSuperHotStart.Click += new System.EventHandler(this.btnSuperHotStart_Click);
            // 
            // btnBackSuperHot
            // 
            this.btnBackSuperHot.BackColor = System.Drawing.Color.Transparent;
            this.btnBackSuperHot.BackgroundImage = global::SpaceGame.Properties.Resources.back;
            this.btnBackSuperHot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackSuperHot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackSuperHot.FlatAppearance.BorderSize = 0;
            this.btnBackSuperHot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBackSuperHot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBackSuperHot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackSuperHot.Location = new System.Drawing.Point(13, 134);
            this.btnBackSuperHot.Name = "btnBackSuperHot";
            this.btnBackSuperHot.Size = new System.Drawing.Size(48, 48);
            this.btnBackSuperHot.TabIndex = 0;
            this.btnBackSuperHot.UseVisualStyleBackColor = false;
            this.btnBackSuperHot.Click += new System.EventHandler(this.btnBackSuperHot_Click);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::SpaceGame.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.plSuperHot);
            this.Controls.Add(this.plPause);
            this.Controls.Add(this.plMulti3);
            this.Controls.Add(this.plEnd);
            this.Controls.Add(this.teamScore);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.plMulti2);
            this.Controls.Add(this.plMulti1);
            this.Controls.Add(this.plMain);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.plMulti1.ResumeLayout(false);
            this.plMulti1.PerformLayout();
            this.plMulti2.ResumeLayout(false);
            this.plMulti3.ResumeLayout(false);
            this.plMulti3.PerformLayout();
            this.plMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.plEnd.ResumeLayout(false);
            this.plEnd.PerformLayout();
            this.plPause.ResumeLayout(false);
            this.plSuperHot.ResumeLayout(false);
            this.plSuperHot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnMultiplayer;
        private System.Windows.Forms.Button superHotbtn;
        private System.Windows.Forms.Panel plMulti1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel plMulti2;
        private System.Windows.Forms.Button btnNextMulti2;
        private System.Windows.Forms.Button btnNextMulti1;
        private System.Windows.Forms.Button btnBackMulti1;
        private System.Windows.Forms.Button btnBackMulti2;
        private System.Windows.Forms.Panel plMulti3;
        private System.Windows.Forms.Button btnMulti3Start;
        private System.Windows.Forms.Button btnBackMulti3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.PictureBox gameName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button vilansPick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label teamScore;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Panel plEnd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Panel plPause;
        private System.Windows.Forms.Button btnPauseQuit;
        private System.Windows.Forms.Button playAgainbtn;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Panel plSuperHot;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSuperHotStart;
        private System.Windows.Forms.Button btnBackSuperHot;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Button heroesPick;
    }
}

