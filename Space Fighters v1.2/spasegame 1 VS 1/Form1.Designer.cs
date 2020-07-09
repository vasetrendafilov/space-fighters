namespace spasegame_1_VS_1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelpl1 = new System.Windows.Forms.Label();
            this.labelpl2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ls = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reloadpl1 = new System.Windows.Forms.Label();
            this.reloadpl2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button_singlepl = new System.Windows.Forms.Button();
            this.button_multipl = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.boom = new System.Windows.Forms.PictureBox();
            this.fire2 = new System.Windows.Forms.PictureBox();
            this.fire = new System.Windows.Forms.PictureBox();
            this.bulet2 = new System.Windows.Forms.PictureBox();
            this.bulet1 = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelpl1
            // 
            this.labelpl1.AutoSize = true;
            this.labelpl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpl1.Location = new System.Drawing.Point(3, 9);
            this.labelpl1.Name = "labelpl1";
            this.labelpl1.Size = new System.Drawing.Size(68, 73);
            this.labelpl1.TabIndex = 2;
            this.labelpl1.Text = "4";
            this.labelpl1.Visible = false;
            // 
            // labelpl2
            // 
            this.labelpl2.AutoSize = true;
            this.labelpl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpl2.Location = new System.Drawing.Point(894, 9);
            this.labelpl2.Name = "labelpl2";
            this.labelpl2.Size = new System.Drawing.Size(68, 73);
            this.labelpl2.TabIndex = 3;
            this.labelpl2.Text = "3";
            this.labelpl2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.ls);
            this.panel1.Controls.Add(this.labelpl1);
            this.panel1.Controls.Add(this.labelpl2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(985, 95);
            this.panel1.TabIndex = 5;
            // 
            // ls
            // 
            this.ls.AutoSize = true;
            this.ls.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ls.Location = new System.Drawing.Point(92, 24);
            this.ls.Name = "ls";
            this.ls.Size = new System.Drawing.Size(806, 55);
            this.ls.TabIndex = 7;
            this.ls.Text = "_________SPACE WAR__________";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.reloadpl1);
            this.panel2.Controls.Add(this.reloadpl2);
            this.panel2.Location = new System.Drawing.Point(0, 566);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 95);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(515, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "QUIT>>Q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(476, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "RESET SCORE>>R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "STOP>>ESC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "START>>ENTER";
            // 
            // reloadpl1
            // 
            this.reloadpl1.AutoSize = true;
            this.reloadpl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadpl1.Location = new System.Drawing.Point(18, 26);
            this.reloadpl1.Name = "reloadpl1";
            this.reloadpl1.Size = new System.Drawing.Size(0, 42);
            this.reloadpl1.TabIndex = 7;
            this.reloadpl1.Visible = false;
            // 
            // reloadpl2
            // 
            this.reloadpl2.AutoSize = true;
            this.reloadpl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadpl2.Location = new System.Drawing.Point(710, 26);
            this.reloadpl2.Name = "reloadpl2";
            this.reloadpl2.Size = new System.Drawing.Size(0, 42);
            this.reloadpl2.TabIndex = 6;
            this.reloadpl2.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button_singlepl
            // 
            this.button_singlepl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_singlepl.Location = new System.Drawing.Point(421, 213);
            this.button_singlepl.Name = "button_singlepl";
            this.button_singlepl.Size = new System.Drawing.Size(130, 40);
            this.button_singlepl.TabIndex = 12;
            this.button_singlepl.Text = "SinglePalyer";
            this.button_singlepl.UseVisualStyleBackColor = true;
            this.button_singlepl.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_multipl
            // 
            this.button_multipl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_multipl.Location = new System.Drawing.Point(421, 281);
            this.button_multipl.Name = "button_multipl";
            this.button_multipl.Size = new System.Drawing.Size(130, 40);
            this.button_multipl.TabIndex = 15;
            this.button_multipl.Text = "MultiPlayer";
            this.button_multipl.UseVisualStyleBackColor = true;
            this.button_multipl.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(421, 353);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 40);
            this.button5.TabIndex = 16;
            this.button5.Text = "QUIT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // boom
            // 
            this.boom.BackgroundImage = global::spasegame_1_VS_1.Properties.Resources.explosion2;
            this.boom.Location = new System.Drawing.Point(605, 445);
            this.boom.Name = "boom";
            this.boom.Size = new System.Drawing.Size(131, 115);
            this.boom.TabIndex = 11;
            this.boom.TabStop = false;
            this.boom.Visible = false;
            // 
            // fire2
            // 
            this.fire2.BackgroundImage = global::spasegame_1_VS_1.Properties.Resources.sf2;
            this.fire2.Location = new System.Drawing.Point(787, 420);
            this.fire2.Name = "fire2";
            this.fire2.Size = new System.Drawing.Size(26, 30);
            this.fire2.TabIndex = 10;
            this.fire2.TabStop = false;
            this.fire2.Visible = false;
            // 
            // fire
            // 
            this.fire.BackgroundImage = global::spasegame_1_VS_1.Properties.Resources.sf;
            this.fire.Location = new System.Drawing.Point(194, 405);
            this.fire.Name = "fire";
            this.fire.Size = new System.Drawing.Size(27, 26);
            this.fire.TabIndex = 9;
            this.fire.TabStop = false;
            this.fire.Visible = false;
            // 
            // bulet2
            // 
            this.bulet2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bulet2.Location = new System.Drawing.Point(546, 156);
            this.bulet2.Name = "bulet2";
            this.bulet2.Size = new System.Drawing.Size(40, 5);
            this.bulet2.TabIndex = 8;
            this.bulet2.TabStop = false;
            this.bulet2.Visible = false;
            // 
            // bulet1
            // 
            this.bulet1.BackColor = System.Drawing.Color.Red;
            this.bulet1.Location = new System.Drawing.Point(94, 195);
            this.bulet1.Name = "bulet1";
            this.bulet1.Size = new System.Drawing.Size(40, 5);
            this.bulet1.TabIndex = 7;
            this.bulet1.TabStop = false;
            this.bulet1.Visible = false;
            // 
            // player2
            // 
            this.player2.BackgroundImage = global::spasegame_1_VS_1.Properties.Resources.fighter2;
            this.player2.Location = new System.Drawing.Point(772, 281);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(100, 101);
            this.player2.TabIndex = 1;
            this.player2.TabStop = false;
            this.player2.Visible = false;
            // 
            // player1
            // 
            this.player1.BackgroundImage = global::spasegame_1_VS_1.Properties.Resources.fighter;
            this.player1.Location = new System.Drawing.Point(85, 281);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(100, 101);
            this.player1.TabIndex = 0;
            this.player1.TabStop = false;
            this.player1.Visible = false;
            this.player1.Click += new System.EventHandler(this.player1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.ControlBox = false;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button_multipl);
            this.Controls.Add(this.button_singlepl);
            this.Controls.Add(this.boom);
            this.Controls.Add(this.fire2);
            this.Controls.Add(this.fire);
            this.Controls.Add(this.bulet2);
            this.Controls.Add(this.bulet1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox player1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Label labelpl1;
        private System.Windows.Forms.Label labelpl2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox bulet1;
        private System.Windows.Forms.PictureBox bulet2;
   
        private System.Windows.Forms.Label reloadpl2;
        private System.Windows.Forms.PictureBox fire;
        private System.Windows.Forms.PictureBox fire2;
        private System.Windows.Forms.PictureBox boom;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button_singlepl;
        private System.Windows.Forms.Button button_multipl;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label reloadpl1;
        private System.Windows.Forms.Label ls;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

