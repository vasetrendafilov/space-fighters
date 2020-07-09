using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceGame
{
    public partial class Form1 : Form
    {
        Player[] player = new Player[3];
        Player[] enemy = new Player[9];
        Ship[] ship = new Ship[5];
        Ship[] shipEnemy = new Ship[5];
        Label[] controls1 = new Label[25];
        Label[] controls2 = new Label[25];
        int[] reloadHero = new int[3];
        Label[] plReloadHero= new Label[3];
        int[] reloadVilian = new int[3];
        Label[] plReloadVilian = new Label[3];
        public List<PictureBox> objekts = new List<PictureBox>();
        public List<PictureBox> objekts1 = new List<PictureBox>();
        public List<PictureBox> shipHero = new List<PictureBox>();
        public List<PictureBox> shipVilian = new List<PictureBox>();
        bool[] def = new bool[] { false,false,false};
        bool[] def2 = new bool[] { false, false, false };
        SoundPlayer simpleSound;

        public int Top = 0, Left = 0, heroHits = 0, vilianHits = 0;
        public int multiScore, heroesCount, enemyCount, formWidth;     
        bool botHero = false, botVilian = false, enable = false, superHot;

        public Form1()
        {
            InitializeComponent();
            //dezin
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.KeyPreview = false;
            formWidth = this.Width;
            plMain.Top = 240;
            plMain.Left = formWidth / 2 - plMain.Width / 2 - 10;
            plPause.Top = 160;
            plPause.Left = formWidth / 2 - plMain.Width / 2 - 10;
            gameName.Top = 25;
            gameName.Left = formWidth / 2 - gameName.Width / 2;
            pictureBox1.Top = 50;
            pictureBox1.Left = 100;
            pictureBox2.Top = 400;
            pictureBox2.Left = 200;
            pictureBox5.Top = 600;
            pictureBox5.Left = 70;
            pictureBox3.Top = 200;
            pictureBox3.Left = formWidth - 300;
            pictureBox3.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox4.Top = 500;
            pictureBox4.Left = formWidth - 450;
            pictureBox4.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            //butons
            btnNextMulti1.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            btnNextMulti2.BackgroundImage.RotateFlip(RotateFlipType.RotateNoneFlipX);
            //heroes ships
            ship[0] = new Ship(SpaceGame.Properties.Resources.ship0, 120, 110, 3, 4, SpaceGame.Properties.Resources.light, 110, 42, 30, 25, 10);
            ship[1] = new Ship(SpaceGame.Properties.Resources.ship1, 120, 75, 3, 4, SpaceGame.Properties.Resources.purple, 75, 25, 23, 23, 5);
            ship[2] = new Ship(SpaceGame.Properties.Resources.ship2, 150, 120, 2, 4, SpaceGame.Properties.Resources.yellow, 140, 49, 50, 20, 10);
            ship[3] = new Ship(SpaceGame.Properties.Resources.ship3, 130, 100, 3, 4, SpaceGame.Properties.Resources.red, 125, 42, 50, 20, 10);
            ship[4] = new Ship(SpaceGame.Properties.Resources.ship4, 130, 110, 3, 4, SpaceGame.Properties.Resources.blue, 100, 45, 50, 20, 10);
          
            //vilans ships 
            Image imageShip = SpaceGame.Properties.Resources.ship0;
            Image imageBulet = SpaceGame.Properties.Resources.light;
            imageShip.RotateFlip(RotateFlipType.RotateNoneFlipX);
            imageBulet.RotateFlip(RotateFlipType.RotateNoneFlipX);
            shipEnemy[0] = new Ship(imageShip, 120, 110, 3, 4, imageBulet, -5, 42, 30, 25, 10);

            imageShip = SpaceGame.Properties.Resources.ship1;
            imageBulet = SpaceGame.Properties.Resources.purple;
            imageShip.RotateFlip(RotateFlipType.RotateNoneFlipX);       
            shipEnemy[1] = new Ship(imageShip, 120, 75, 4, 4, imageBulet, 15, 25, 23, 23, 5);

            imageShip = SpaceGame.Properties.Resources.ship2;
            imageBulet = SpaceGame.Properties.Resources.yellow;
            imageShip.RotateFlip(RotateFlipType.RotateNoneFlipX);
            shipEnemy[2] = new Ship(imageShip, 150, 120, 4, 4, imageBulet, -38, 49, 50, 20, 10);

            imageShip = SpaceGame.Properties.Resources.ship3;
            imageBulet = SpaceGame.Properties.Resources.red;
            imageShip.RotateFlip(RotateFlipType.RotateNoneFlipX);
            shipEnemy[3] = new Ship(imageShip, 130, 100, 4, 4, imageBulet, -42, 42, 50, 20, 10);

            imageShip = SpaceGame.Properties.Resources.ship4;
            imageBulet = SpaceGame.Properties.Resources.blue;
            imageShip.RotateFlip(RotateFlipType.RotateNoneFlipX);
            imageBulet.RotateFlip(RotateFlipType.RotateNoneFlipX);
            shipEnemy[4] = new Ship(imageShip, 130, 110, 4, 4, imageBulet, -30, 45, 50, 20, 10);
        }

        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            plMain.Visible = false;
            plMulti1.Top = 240;
            plMulti1.Left = formWidth / 2 - plMain.Width / 2 - 10;                  
            plMulti1.Visible = true;        
        }

        private void btnNextMulti1_Click(object sender, EventArgs e)
        {
            heroesCount = comboBox1.SelectedIndex + 1;
            enemyCount = comboBox2.SelectedIndex + 1;
            Top = Left = 0;
            plMulti1.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            plMulti2.Top = 220;
            plMulti2.Left = 25;
            plMulti2.Width = formWidth - 55;
            plMulti2.Height = this.Height - 230;
            Button back = btnBackMulti2;
            Button next = btnNextMulti2;
            back.Left = 0;
            back.Top = plMulti2.Height - 48;
            next.Left = plMulti2.Width - 48;
            next.Top = plMulti2.Height - 48;
            plMulti2.Controls.Add(back);
            plMulti2.Controls.Add(next);
            
            for (int i = 0; i < heroesCount; i++)
            {
                player[i] = new Player();
                player[i].formHeight = Height;
                player[i].formWidth = Width;
                player[i].bot = botHero;
                plMulti2.Controls.Add(Label("PLAYER" + (i + 1).ToString() + ":",Color.Teal, new Font("Agency FB", 18)));
                Top += 30;
                for (int j = 0; j < 5; j++)
                {
                    PictureBox pictureBox = makeShip(ship[j].image, 120, 120, i, j);                  
                    pictureBox.MouseClick += new MouseEventHandler(ChooseShip);            
                    shipHero.Add(pictureBox);
                    plMulti2.Controls.Add(pictureBox);
                    Left += 125;        
                }
                Top += 130;
                Left = 0;
            }
            Left = 690;
            Top = 0;
            for (int i = 0; i < enemyCount; i++)
            {
                enemy[i] = new Player();
                enemy[i].formHeight = Height;
                enemy[i].formWidth = Width;
                enemy[i].bot = botVilian;
                plMulti2.Controls.Add(Label("PLAYER" + (i + 1).ToString() + ":",Color.DarkRed, new Font("Agency FB", 18)));
                Top += 30;
                for (int j = 0; j < 5; j++)
                {
                    PictureBox pictureBox = makeShip(shipEnemy[j].image, 120, 120, i, j);
                    pictureBox.MouseClick += new MouseEventHandler(ChooseEnemy);
                    shipVilian.Add(pictureBox);
                    plMulti2.Controls.Add(pictureBox);
                    Left += 125;
                }
                Top += 130;
                Left = 690;
            }
            plMulti2.Visible = true;
        }
        private void btnBackMulti1_Click(object sender, EventArgs e)
        {
            plMain.Visible = true;           
            plMulti1.Visible = false;
        }

        private void btnNextMulti2_Click(object sender, EventArgs e)
        {
            Top = Left = 0;
            int n = 0;
            this.KeyPreview = true;
            plMulti2.Visible = false;
            plMulti3.Top = 220;
            plMulti3.Left = 25;
            plMulti3.Width = formWidth - 55;
            plMulti3.Height = this.Height - 230;         
            Button back = btnBackMulti3;
            Button start = btnMulti3Start;
            back.Left = 0;
            back.Top = plMulti2.Height - 48;
            start.Left = plMulti2.Width - 79;
            start.Top = plMulti2.Height - 51;
            plMulti3.Controls.Add(back);
            plMulti3.Controls.Add(start);
            if (botHero == false)
            {
                for (int i = 0; i < heroesCount; i++)
                {
                    plMulti3.Controls.Add(Label("PLAYER" + (i + 1).ToString() + " CONTROLS:", Color.Teal, new Font("Agency FB", 18), 200));
                    Top += 40;

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.BackgroundImage = SpaceGame.Properties.Resources.keys;
                    pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox.BackColor = Color.Transparent;
                    pictureBox.Width = 180;
                    pictureBox.Height = 100;
                    pictureBox.Top = Top;
                    pictureBox.Left = Left + 10;
                    plMulti3.Controls.Add(pictureBox);

                    for (int j = 0; j < 5; j++)
                    {
                        Label lab = new Label();
                        lab.Tag = i.ToString() + j.ToString();
                        lab.Width = 30;
                        lab.Height = 30;
                        lab.Cursor = Cursors.Hand;
                        lab.ForeColor = Color.White;
                        lab.BackColor = Color.Transparent;
                        lab.Font = new Font("Agency FB", 20, FontStyle.Bold);
                        lab.MouseClick += new MouseEventHandler(Mouse);
                        switch (j)
                        {
                            case 0:
                                lab.Top = 8; lab.Left = 60; lab.Text = "W";
                                break;
                            case 1:
                                lab.Top = 60; lab.Left = 77; lab.Text = "S";
                                break;
                            case 2:
                                lab.Top = 60; lab.Left = 139; lab.Text = "D";
                                break;
                            case 3:
                                lab.Top = 59; lab.Left = 16; lab.Text = "A";
                                break;
                            case 4:
                                lab.Top = 8; lab.Left = 122; lab.Text = "E";
                                break;
                        }
                        pictureBox.Controls.Add(lab);
                        controls1[n] = lab;
                        n++;
                    }
                    Top += 120;
                }
            }
                Left = plMulti3.Width - 200;
                Top = n = 0;
            if (botVilian == false)
            {
                for (int i = 0; i < enemyCount; i++)
                {
                    Label label = new Label();
                    label.Top = Top;
                    label.Left = Left;
                    label.Text = "PLAYER" + (i + 1).ToString() + " CONTROLS:";
                    label.ForeColor = Color.DarkRed;
                    label.Width = 200;
                    label.BackColor = Color.Transparent;
                    label.Font = new Font("Agency FB", 18);
                    plMulti3.Controls.Add(label);
                    Top += 40;

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.BackgroundImage = SpaceGame.Properties.Resources.keys;
                    pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                    pictureBox.BackColor = Color.Transparent;
                    pictureBox.Width = 180;
                    pictureBox.Height = 100;
                    pictureBox.Top = Top;
                    pictureBox.Left = Left + 10;
                    plMulti3.Controls.Add(pictureBox);

                    for (int j = 0; j < 5; j++)
                    {
                        Label lab = new Label();
                        lab.Tag = i.ToString() + j.ToString();
                        lab.Width = 30;
                        lab.Height = 30;
                        lab.Cursor = Cursors.Hand;
                        lab.ForeColor = Color.White;
                        lab.BackColor = Color.Transparent;
                        lab.Font = new Font("Agency FB", 20, FontStyle.Bold);
                        lab.MouseClick += new MouseEventHandler(Mouse);
                        switch (j)
                        {
                            case 0:
                                lab.Top = 8; lab.Left = 60; lab.Text = "W";
                                break;
                            case 1:
                                lab.Top = 60; lab.Left = 77; lab.Text = "S";
                                break;
                            case 2:
                                lab.Top = 60; lab.Left = 139; lab.Text = "D";
                                break;
                            case 3:
                                lab.Top = 59; lab.Left = 16; lab.Text = "A";
                                break;
                            case 4:
                                lab.Top = 8; lab.Left = 122; lab.Text = "E";
                                break;
                        }
                        pictureBox.Controls.Add(lab);
                        controls2[n] = lab;
                        n++;
                    }
                    Top += 120;
                }
            }
            label3.Left = plMulti3.Width / 2 - label3.Width / 2;
            label3.Top = 100;
            textBox1.Left = plMulti3.Width / 2 - textBox1.Width / 2;
            textBox1.Top = 230;
            plMulti3.Visible = true;
        }
        private void btnBackMulti2_Click(object sender, EventArgs e)
        {
            plMulti2.Visible = false;
            Top = 0;
            Left = 0;
            shipHero.Clear();
            shipVilian.Clear();
            plMulti2.Controls.Clear();
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            plMulti1.Visible = true;
        }

        private void btnMulti3Start_Click(object sender, EventArgs e)
        {
            multiScore = Convert.ToInt32(textBox1.Text);
            Left = Top = 0;
            for (int i = 0; i < heroesCount; i++)
            {             
                //hits            
                this.Controls.Add(Label("PL" + (i + 1).ToString() + ":", Color.Teal, new Font("Agency FB", 18),45));
                Top += 30;              
                player[i].Hits = Label("0", Color.Teal, new Font("Agency FB", 18), 40,true); 
                this.Controls.Add(player[i].Hits);
                Top = this.Height - 60;
                //reload     
                this.Controls.Add(Label("PL" + (i + 1).ToString() + ":", Color.Teal, new Font("Agency FB", 18), 45));
                Top += 30;
                plReloadHero[i] = Label(player[i].reload.ToString() + ".0", Color.Teal, new Font("Agency FB", 18), 40, true);
                this.Controls.Add(plReloadHero[i]);
                reloadHero[i] = player[i].reload*10;
                this.Controls.Add(player[i].player);
                objekts1.Add(player[i].player);
                Left += 50;
                Top = 0;
            }
            Left = formWidth - 45;
            for (int i = 0; i < enemyCount; i++)
            {             
                this.Controls.Add(Label("PL" + (i + 1).ToString() + ":", Color.DarkRed, new Font("Agency FB", 18), 45));
                Top += 30;
                enemy[i].Hits = Label("0", Color.DarkRed, new Font("Agency FB", 18), 40,true); 
                this.Controls.Add(enemy[i].Hits);
                Top = this.Height - 60;            
                this.Controls.Add(Label("PL" + (i + 1).ToString() + ":", Color.DarkRed, new Font("Agency FB", 18), 45));
                Top += 30;            
                plReloadVilian[i] = Label(enemy[i].reload.ToString() + ".0", Color.DarkRed, new Font("Agency FB", 18), 40);
                this.Controls.Add(plReloadVilian[i]);
                reloadVilian[i] = enemy[i].reload * 10;
                this.Controls.Add(enemy[i].player);
                objekts.Add(enemy[i].player);
                Left -= 50;
                Top = 0;
            }         
            teamScore.Top = 0;
            teamScore.Left = formWidth / 2 - teamScore.Width / 2;
            teamScore.Visible = true;
            Label label = Label("SPACE", Color.Teal, new Font("Agency FB", 36), 200);
            label.Left = formWidth / 2 - 170;
            label.Height = 50;
            this.Controls.Add(label);
            Label label1 = Label("SHOOTER", Color.DarkRed, new Font("Agency FB", 36), 200);
            label1.Left = formWidth / 2 + 50;
            label1.Height = 50;
            this.Controls.Add(label1);
            PictureBox picture = new PictureBox();
            picture.Top = 57;
            picture.Left = 0;
            picture.Width = formWidth/2;
            picture.Height = 2;
            picture.BackColor = Color.Teal;
            this.Controls.Add(picture);
            PictureBox picture1 = new PictureBox();
            picture1.Left = formWidth / 2;
            picture1.Top = 57;
            picture1.Width = formWidth/2;
            picture1.Height = 2;
            picture1.BackColor = Color.DarkRed;
            this.Controls.Add(picture1);
            PictureBox picture2 = new PictureBox();
            picture2.Top = this.Height - 63;
            picture2.Left = 0;
            picture2.Width = formWidth / 2;
            picture2.Height = 2;
            picture2.BackColor = Color.Teal;
            this.Controls.Add(picture2);
            PictureBox picture3 = new PictureBox();
            picture3.Left = formWidth / 2;
            picture3.Top = this.Height - 63;
            picture3.Width = formWidth / 2;
            picture3.Height = 2;
            picture3.BackColor = Color.DarkRed;
            this.Controls.Add(picture3);
            plMain.Dispose();
            plMulti1.Dispose();
            plMulti2.Dispose();
            plMulti3.Dispose();
            gameName.Visible = false;
            this.BackgroundImage = null;
            enable = true;
            this.start_pause(true);          
        }
        private void btnBackMulti3_Click(object sender, EventArgs e)
        {
            enable = false;
            this.KeyPreview = false;
            plMulti3.Visible = false;
            Top = 0;
            Left = 0;
            foreach (PictureBox ship in shipVilian) { ship.Controls.Clear(); }
            foreach (PictureBox ship in shipHero) { ship.Controls.Clear(); }
            plMulti2.Visible = true;
        }

        public void ChooseShip(object sender, MouseEventArgs e)
        {
            PictureBox go = ((PictureBox)sender);
            int n = Convert.ToInt32(go.Name);
            def[Convert.ToInt32(go.Tag)] = true;
            int j = 0, a = 0;
            foreach (PictureBox ship in shipHero)
            {
                if(def[j] == true)
                {
                    ship.Refresh();
                    ship.Controls.Clear();
                }
                if (a == 4)
                {
                    j++;
                    a = -1;
                }
                a++;
            }
            Graphics g = go.CreateGraphics();           
            Pen pen = new Pen(Color.Teal,3);
            SolidBrush brush = new SolidBrush(Color.FromArgb(128, 128, 255, 255));
            g.FillRectangle(brush, 0,0, go.Width, go.Height);
            g.DrawRectangle(pen, 0, 0, go.Width, go.Height);
            Top = go.Height / 7; 
            for (int i = 0; i < 3; i++)
            {
                Label label = new Label();
                label.Top = Top;
                label.Left = 5;
                switch (i)
                {
                     case 0: label.Text = "SPEED: " + ship[n].speed.ToString();
                        break;
                    case 1: label.Text = "RELOAD: " + ship[n].reload.ToString();
                        break;
                    case 2: label.Text = "BULLET SPEED: " + (ship[n].buletSpeed/5).ToString();
                        break;
                }
                label.ForeColor = Color.Teal;
                label.Font = new Font("Agency FB", 14,FontStyle.Bold);
                label.BackColor = Color.FromArgb(128, 128, 255, 255);
                label.Width = go.Width - 10;
                go.Controls.Add(label);
                Top += 25;
            }                 
            PictureBox pictureBox = ship[n].make();
            if (Convert.ToInt32(go.Tag) == 0) { pictureBox.Top = 200; }
            if (Convert.ToInt32(go.Tag) == 1) { pictureBox.Top = 400; }
            if (Convert.ToInt32(go.Tag) == 2) { pictureBox.Top = 600; }
            player[Convert.ToInt32(go.Tag)].addShip(pictureBox, ship[n].speed, ship[n].reload,ship[n].buletImage, ship[n].buletWidth, ship[n].buletHeight, ship[n].buletSpeed, ship[n].buletTop, ship[n].buletLeft);
            def[Convert.ToInt32(go.Tag)] = false;
        }
        public void ChooseEnemy(object sender, MouseEventArgs e)
        {
            PictureBox go = ((PictureBox)sender);
            int n = Convert.ToInt32(go.Name);
            def2[Convert.ToInt32(go.Tag)] = true;
            int j = 0, a = 0;
            foreach (PictureBox ship in shipVilian)
            {
                if (def2[j] == true)
                {
                    ship.Refresh();
                    ship.Controls.Clear();
                }
                if (a == 4)
                {
                    j++;
                    a = -1;
                }
                a++;
            }
            Graphics g = go.CreateGraphics();
            Pen pen = new Pen(Color.DarkRed, 3);
            SolidBrush brush = new SolidBrush(Color.FromArgb(128, 233, 181, 195));
            g.FillRectangle(brush, 0, 0, go.Width, go.Height);
            g.DrawRectangle(pen, 0, 0, go.Width, go.Height);
            Top = go.Height / 7;
            for (int i = 0; i < 3; i++)
            {
                Label label = new Label();
                label.Top = Top;
                label.Left = 5;
                switch (i)
                {
                    case 0:
                        label.Text = "SPEED: " + shipEnemy[n].speed.ToString();
                        break;
                    case 1:
                        label.Text = "RELOAD: " + shipEnemy[n].reload.ToString();
                        break;
                    case 2:
                        label.Text = "BULLET SPEED: " + (shipEnemy[n].buletSpeed / 5).ToString();
                        break;
                }
                label.ForeColor = Color.DarkRed;
                label.Font = new Font("Agency FB", 14, FontStyle.Bold);
                label.BackColor = Color.FromArgb(128, 233, 181, 195);
                label.Width = go.Width - 10;
                go.Controls.Add(label);
                Top += 25;
            }
            PictureBox pictureBox = shipEnemy[n].make();
            pictureBox.Left = formWidth - 200;
            if (Convert.ToInt32(go.Tag) == 0) { pictureBox.Top = 200; }
            if (Convert.ToInt32(go.Tag) == 1) { pictureBox.Top = 400; }
            if (Convert.ToInt32(go.Tag) == 2) { pictureBox.Top = 600; }
            enemy[Convert.ToInt32(go.Tag)].addShip(pictureBox, shipEnemy[n].speed, shipEnemy[n].reload, shipEnemy[n].buletImage, shipEnemy[n].buletWidth, shipEnemy[n].buletHeight, shipEnemy[n].buletSpeed, shipEnemy[n].buletTop, shipEnemy[n].buletLeft);
            def2[Convert.ToInt32(go.Tag)] = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < heroesCount; i++)
            {
                player[i].range();
                player[i].move();                        
                heroHits += player[i].hits;
                if(player[i].bot == true)
                {
                    player[i].botMove();
                    if (enemy[0].player.Top - 30 < player[i].player.Bottom && enemy[0].player.Bottom + 30 > player[i].player.Top)
                    {
                        FireGun(i);
                        this.addBulets(player[i].fire());       
                    }
                }
            }          
            for (int i = 0; i < enemyCount; i++)
            {
                enemy[i].range();
                enemy[i].move();
                vilianHits += enemy[i].hits;
                if (enemy[i].bot == true)
                {
                    enemy[i].botMove();
                    //bot fire
                    if(player[0].player.Top - 30 < enemy[i].player.Bottom && player[0].player.Bottom + 30 > enemy[i].player.Top)
                    {
                        FireGun(i);
                        this.addBulets(enemy[i].fire());
                    }                   
                }
            }
            if (teamScore.Visible == true)
            {
                string a = ":";
                if (heroHits < vilianHits)
                {
                    a = "<";
                    teamScore.ForeColor = Color.DarkRed;
                }
                else if (heroHits > vilianHits)
                {
                    a = ">";
                    teamScore.ForeColor = Color.Teal;
                }
                else
                {
                    a = ":";
                    teamScore.ForeColor = Color.White;
                }
                teamScore.Left = formWidth / 2 - teamScore.Width / 2;
                teamScore.Text = heroHits.ToString() + a + vilianHits.ToString();
                if (multiScore == heroHits)
                {
                    this.start_pause(false);
                    plEnd.Top = this.Height / 2 - plEnd.Height / 2;
                    plEnd.Left = formWidth / 2 - plEnd.Width / 2;
                    plEnd.Visible = true;
                }
                else if (multiScore == vilianHits)
                {
                    this.start_pause(false);
                    plEnd.Top = this.Height / 2 - plEnd.Height / 2;
                    plEnd.Left = formWidth / 2 - plEnd.Width / 2;
                    labelWin.Text = "VILLAINS WON";
                    labelWin.ForeColor = Color.DarkRed;
                    labelWin.Left -= 5;
                    plEnd.Visible = true;
                }

                heroHits = vilianHits = 0;
            }
            else
            {
                if (objekts1[0].IsDisposed == true)
                {
                    this.start_pause(false);
                    plEnd.Top = this.Height / 2 - plEnd.Height / 2;
                    plEnd.Left = formWidth / 2 - plEnd.Width / 2;
                    labelWin.Text = "VILLAINS WON";
                    labelWin.ForeColor = Color.DarkRed;
                    labelWin.Left -= 5;
                    plEnd.Visible = true;
                }
                else
                {
                    int a = 0; 
                    foreach (PictureBox objekt in objekts)
                    {
                        if(objekt.IsDisposed == true) { a++; }
                    }
                    if (a == enemyCount)
                    {
                        this.start_pause(false);
                        plEnd.Top = this.Height / 2 - plEnd.Height / 2;
                        plEnd.Left = formWidth / 2 - plEnd.Width / 2;
                        plEnd.Visible = true;
                    }
                }

            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < heroesCount; i++)
            {
                player[i].buletMove(true);
                PictureBox box = player[i].buletHit(objekts, true);
                if (box != null)
                {
                    explodeAsync(box.Top, box.Left);
                }
            }
            for (int i = 0; i < enemyCount; i++)
            {
                enemy[i].buletMove();
                PictureBox picture= enemy[i].buletHit(objekts1);
                if (picture != null)
                {
                    explodeAsync(picture.Top, picture.Left);
                }
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < heroesCount; i++)
            {
                if(player[i].reloaded == false)
                {
                    if(reloadHero[i] <= 0)
                    {
                        player[i].reloaded = true;
                        reloadHero[i] = player[i].reload * 10;
                        plReloadHero[i].Text = (reloadHero[i] / 10).ToString() + "." + (reloadHero[i] % 10).ToString();
                        plReloadHero[i].ForeColor = Color.Teal;
                        break;
                    }
                    reloadHero[i]--;
                    plReloadHero[i].Text = (reloadHero[i]/10).ToString() + "." + (reloadHero[i] % 10).ToString();
                    plReloadHero[i].ForeColor = Color.White;
                } 
            }
            for (int i = 0; i < enemyCount; i++)
            {
                if (enemy[i].reloaded == false)
                {
                    if (reloadVilian[i] <= 0)
                    {
                        enemy[i].reloaded = true;
                        reloadVilian[i] = enemy[i].reload * 10;
                        plReloadVilian[i].Text = (reloadVilian[i] / 10).ToString() + "." + (reloadVilian[i] % 10).ToString();
                        plReloadVilian[i].ForeColor = Color.DarkRed;
                        if(enemy[i].player.IsDisposed == true)
                        {
                            enemy[i].bot = false;
                            enemy[i].controls = new Keys[]{ Keys.Apps, Keys.Alt, Keys.BrowserBack, Keys.BrowserFavorites, Keys.BrowserHome };
                            plReloadVilian[i].Text = "XXX";
                            plReloadVilian[i].ForeColor = Color.White;
                        }
                        break;
                    }
                    reloadVilian[i]--;
                    plReloadVilian[i].Text = (reloadVilian[i] / 10).ToString() + "." + (reloadVilian[i] % 10).ToString();
                    plReloadVilian[i].ForeColor = Color.White;
                }
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (!superHot)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;           
            }
            else
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
                timer3.Enabled = true;
            }
        }

        public PictureBox makeShip(Image image, int width, int height, int i, int j)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.BackgroundImage = image;
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox.Width = width;
            pictureBox.Height = height;
            pictureBox.Top = Top;
            pictureBox.Left = Left;
            pictureBox.Tag = i;
            pictureBox.Name = j.ToString();
            pictureBox.Cursor = Cursors.Hand;
            pictureBox.BackColor = Color.Transparent;
            if (j == 1)
            {
                pictureBox.Top += 15;
                pictureBox.Height -= 30;
            }
            return pictureBox;
        }
        public Label Label(string text, Color color, Font font, int width = 0, bool pomestuvanje = false)
        {
            Label label = new Label();
            label.Top = Top;
            label.Left = Left;
            label.Text = text;
            label.ForeColor = color;
            label.Font = font;
            label.BackColor = Color.Transparent;
            if (width != 0) { label.Width = width; }
            if (pomestuvanje == true) { label.TextAlign = ContentAlignment.MiddleCenter; }
            return label;
        }

        private void superHotbtn_Click(object sender, EventArgs e)
        {
            int n = 0;
            plMain.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            Top = Left = 0;
            this.KeyPreview = true;
            plSuperHot.Top = 220;
            plSuperHot.Left = 300;
            plSuperHot.Width = formWidth - 600;
            plSuperHot.Height = this.Height - 230;
            Button back = btnBackSuperHot;
            Button start = btnSuperHotStart;
            back.Left = 0;
            back.Top = plSuperHot.Height - 48;
            start.Left = plSuperHot.Width - 79;
            start.Top = plSuperHot.Height - 51;
            plSuperHot.Controls.Add(back);
            plSuperHot.Controls.Add(start);
            heroesCount = 1;
              
            player[0] = new Player();
            player[0].formHeight = Height;
            player[0].formWidth = Width;
            plSuperHot.Controls.Add(Label("CHOOSE SHIP:", Color.DarkRed, new Font("Agency FB", 18), 200));
            Left += 70;
            Top += 40;
           
            for (int j = 0; j < 5; j++)
            {
                PictureBox box = makeShip(ship[j].image, 120, 120, 0, j);
                box.MouseClick += new MouseEventHandler(ChooseShip);
                shipHero.Add(box);
                plSuperHot.Controls.Add(box);
                Left += 125;
            }
            Left = 0;
            Top += 170;
            plSuperHot.Controls.Add(Label("CONTROLS:", Color.DarkRed, new Font("Agency FB", 18), 200));
       
            label4.Left = plSuperHot.Width /2 - 60;
            label4.Top = Top;
            comboBox3.Left = plSuperHot.Width / 2 - 40;
            comboBox3.Top = Top + label4.Height - 7; 
            Top += 50;
            Left += 20;
            PictureBox pictureBox = new PictureBox();
            pictureBox.BackgroundImage = SpaceGame.Properties.Resources.keys;
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Width = 180;
            pictureBox.Height = 100;
            pictureBox.Top = Top;
            pictureBox.Left = Left + 10;
            plSuperHot.Controls.Add(pictureBox);
            for (int j = 0; j < 5; j++)
            {
                Label lab = new Label();
                lab.Tag = "0" + j.ToString();
                lab.Width = 30;
                lab.Height = 30;
                lab.Cursor = Cursors.Hand;
                lab.ForeColor = Color.White;
                lab.BackColor = Color.Transparent;
                lab.Font = new Font("Agency FB", 20, FontStyle.Bold);
                lab.MouseClick += new MouseEventHandler(Mouse);
                switch (j)
                {
                    case 0:
                        lab.Top = 8; lab.Left = 60; lab.Text = "W";
                        break;
                    case 1:
                        lab.Top = 60; lab.Left = 77; lab.Text = "S";
                        break;
                    case 2:
                        lab.Top = 60; lab.Left = 139; lab.Text = "D";
                        break;
                    case 3:
                        lab.Top = 59; lab.Left = 16; lab.Text = "A";
                        break;
                    case 4:
                        lab.Top = 8; lab.Left = 122; lab.Text = "E";
                        break;
                }
                pictureBox.Controls.Add(lab);
                controls1[n] = lab;
                n++;
            }
           
            plSuperHot.Visible = true;
        }     
        private void btnSuperHotStart_Click(object sender, EventArgs e)
        {       
            Random rnd = new Random();
            Left = Top = 0;
            int n;
            switch (comboBox3.SelectedIndex)
            {
                case 0:enemyCount = 3;
                    break;
                case 1: enemyCount = 5;
                    break;
                case 2: enemyCount = 7;
                    break;
                case 3: enemyCount = 9;
                    break;
            }

            for (int i = 0; i < heroesCount; i++)
            {
                Top = this.Height - 60;
                //reload     
                this.Controls.Add(Label("PL" + (i + 1).ToString() + ":", Color.Teal, new Font("Agency FB", 18), 45));
                Top += 30;
                plReloadHero[i] = Label(player[i].reload.ToString() + ".0", Color.Teal, new Font("Agency FB", 18), 40, true);
                this.Controls.Add(plReloadHero[i]);
                reloadHero[i] = player[i].reload * 10;
                this.Controls.Add(player[i].player);
                objekts1.Add(player[i].player);
                Left += 50;
                Top = 0;
            }
            Left = formWidth - 45;
            for (int i = 0; i < enemyCount; i++)
            {
                n = rnd.Next(1, 5);
                enemy[i] = new Player();
                enemy[i].formHeight = Height;
                enemy[i].formWidth = Width;
                enemy[i].bot = true;
                PictureBox pictureBox = shipEnemy[n].make();
                pictureBox.Left = formWidth - 200;
                pictureBox.Top = (i+1) * 120;
                enemy[i].addShip(pictureBox, shipEnemy[n].speed, shipEnemy[n].reload, shipEnemy[n].buletImage, shipEnemy[n].buletWidth, shipEnemy[n].buletHeight, shipEnemy[n].buletSpeed, shipEnemy[n].buletTop, shipEnemy[n].buletLeft);

                Top = this.Height - 60;
                this.Controls.Add(Label("PL" + (i + 1).ToString() + ":", Color.DarkRed, new Font("Agency FB", 18), 45));
                Top += 30;
                plReloadVilian[i] = Label(enemy[i].reload.ToString() + ".0", Color.DarkRed, new Font("Agency FB", 18), 40);
                this.Controls.Add(plReloadVilian[i]);
                reloadVilian[i] = enemy[i].reload * 10;
                this.Controls.Add(enemy[i].player);
                objekts.Add(enemy[i].player);
                Left -= 50;
                Top = 0;
            }


            Label label = Label("SPACE", Color.Teal, new Font("Agency FB", 36), 120);
            label.Left = formWidth / 2 - 110;
            label.Height = 50;
            this.Controls.Add(label);
            Label label1 = Label("SHOOTER", Color.DarkRed, new Font("Agency FB", 36), 200);
            label1.Left = formWidth / 2 - 3 ;
            label1.Height = 50;
            this.Controls.Add(label1);
            Left = formWidth - 45;
            Top = Height - 60;
            Label label2 = Label("SUPER", Color.Teal, new Font("Agency FB", 36), 130);
            label2.Left = formWidth / 2 - 120;
            label2.Height = 50;
            this.Controls.Add(label2);
            Label label3 = Label("HOT!!", Color.DarkRed, new Font("Agency FB", 36), 120);
            label3.Left = formWidth / 2;
            label3.Height = 50;
            this.Controls.Add(label3);
            PictureBox picture = new PictureBox();
            picture.Top = 57;
            picture.Left = 0;
            picture.Width = formWidth / 2;
            picture.Height = 2;
            picture.BackColor = Color.Teal;
            this.Controls.Add(picture);
            PictureBox picture1 = new PictureBox();
            picture1.Left = formWidth / 2;
            picture1.Top = 57;
            picture1.Width = formWidth / 2;
            picture1.Height = 2;
            picture1.BackColor = Color.DarkRed;
            this.Controls.Add(picture1);
            PictureBox picture2 = new PictureBox();
            picture2.Top = this.Height - 63;
            picture2.Left = 0;
            picture2.Width = formWidth / 2;
            picture2.Height = 2;
            picture2.BackColor = Color.Teal;
            this.Controls.Add(picture2);
            PictureBox picture3 = new PictureBox();
            picture3.Left = formWidth / 2;
            picture3.Top = this.Height - 63;
            picture3.Width = formWidth / 2;
            picture3.Height = 2;
            picture3.BackColor = Color.DarkRed;
            this.Controls.Add(picture3);
            plSuperHot.Dispose();
            gameName.Visible = false;
            this.BackgroundImage = null;
            enable = true;
            this.start_pause(true);
            timer4.Enabled = true;         
        }
        private void btnBackSuperHot_Click(object sender, EventArgs e)
        {
            plMain.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            plSuperHot.Visible = false;
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            plPause.Controls.Clear();
            plPause.Visible = false;
            start_pause(true);            
        }
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void btnQuit_Click(object sender, EventArgs e) { this.Close(); }

        public void Mouse(object sender, MouseEventArgs e)
        {
            Label label = ((Label)sender);
            label.Text = "?";
            label.Name = "on";
        }
        private void player_bot(object sender, EventArgs e)
        {
            Button box = ((Button)sender);
            if (box.Tag == "on")
            {
                box.BackgroundImage = SpaceGame.Properties.Resources.computer_white;
                box.Tag = "";
                if (box.Name == "heroesPick") { botHero = true; }
                else { botVilian = true; }
            }
            else
            {
                box.BackgroundImage = SpaceGame.Properties.Resources.person_white;
                box.Tag = "on";
                if (box.Name == "heroesPick") { botHero = false; }
                else { botVilian = false; }
            }
        }

        public void start_pause(bool val)
        {
            timer1.Enabled = val;
            timer2.Enabled = val;
            timer3.Enabled = val;          
            this.KeyPreview = val;
            if (val == true)
            { Cursor.Hide(); }
            else { Cursor.Show(); }
        }
        public void addBulets(PictureBox val)
        {
            if (timer1.Enabled == true)
            {
                if (val != null)
                {
                    this.Controls.Add(val);
                    val.BringToFront();
                }
            }
        }
        public async Task explodeAsync(int top, int left)
        {
            PictureBox box = new PictureBox();
            box.BackgroundImage = SpaceGame.Properties.Resources.explosion;
            box.BackgroundImageLayout = ImageLayout.Stretch;
            box.BackColor = Color.Transparent;
            box.Width = 150;
            box.Height = 150;
            box.Top = top;
            box.Left = left;
            this.Controls.Add(box);
            box.BringToFront();
            start_pause(false);
            await Task.Delay(1000);
            box.Dispose();
            start_pause(true);
        }
       
        private void FireGun(int val)
        {    
            switch (val)
            {
                case 0:
                simpleSound = new SoundPlayer(Properties.Resources.sound1);
                    break;
                case 1:
              simpleSound = new SoundPlayer(Properties.Resources.sound2);
                    break;
                case 2:
              simpleSound = new SoundPlayer(Properties.Resources.sound3);
                    break;
                case 3:
                  simpleSound = new SoundPlayer(Properties.Resources.sound4);
                    break;
                case 4:
                 simpleSound = new SoundPlayer(Properties.Resources.sound5);
                    break;
            }
            simpleSound.Play();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (teamScore.Visible == false && !(e.KeyCode == player[0].controls[4]))
            {
                superHot = true;
            }
            for (int i = 0; i < heroesCount; i++)
            {
                if (player[i].bot == false)
                {
                    if (e.KeyCode == player[i].controls[4] && superHot == true ) {this.addBulets(player[i].fire()); FireGun(i); }
                    if (e.KeyCode == player[i].controls[4] && teamScore.Visible == true) { this.addBulets(player[i].fire()); FireGun(i); }
                    player[i].keyDown(e.KeyCode);
                }
            }
            for (int i = 0; i < enemyCount; i++)
            {
                if (enemy[i].bot == false)
                {
                    if (e.KeyCode == enemy[i].controls[4]) { this.addBulets(enemy[i].fire()); FireGun(i); }
                    enemy[i].keyDown(e.KeyCode);
                }
            }

            if (e.KeyCode == Keys.Escape)
            {             
                start_pause(false);
                Button resume = btnResume;
                Button playAgain = playAgainbtn;
                Button quit = btnPauseQuit;
                resume.Left = 78;
                resume.Top = 136;
                playAgain.Left = 78;
                playAgain.Top = 239;
                quit.Left = 78;
                quit.Top = 343;
                plPause.Controls.Add(resume);
                plPause.Controls.Add(playAgain);
                plPause.Controls.Add(quit);
                plPause.Visible = true;             
            }
              
            if (enable == false)
            {
                if (botHero == false)
                {
                    for (int i = 0; i < heroesCount; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {

                            if (controls1[j + i * 5].Name == "on")
                            {
                                string a = controls1[j + i * 5].Tag.ToString();
                                int b = Convert.ToInt32(a[0].ToString()), c = Convert.ToInt32(a[1].ToString());
                                controls1[j + i * 5].Text = e.KeyCode.ToString();
                                player[b].controls[c] = e.KeyCode;
                                controls1[j + i * 5].Name = "off";
                            }
                        }
                    }
                }
                if (botVilian == false)
                {
                    for (int i = 0; i < enemyCount; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {

                            if (controls2[j + i * 5].Name == "on")
                            {
                                string a = controls2[j + i * 5].Tag.ToString();
                                int b = Convert.ToInt32(a[0].ToString()), c = Convert.ToInt32(a[1].ToString());
                                controls2[j + i * 5].Text = e.KeyCode.ToString();
                                enemy[b].controls[c] = e.KeyCode;
                                controls2[j + i * 5].Name = "off";
                            }
                        }
                    }
                }
            }     
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < heroesCount; i++){ player[i].keyUp(e.KeyCode); }
            for (int i = 0; i < enemyCount; i++){ enemy[i].keyUp(e.KeyCode); }
            if (teamScore.Visible == false && !(e.KeyCode == player[0].controls[4]) ) { superHot = false; }
        }      
    }
}
