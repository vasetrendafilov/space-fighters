using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace SpaceGame
{
    class Player
    {
        //bulet prom
        Image bulet;
        int buletWitdth, buletHeight, buletLeft, buletTop, buletSpeed;
        public List<PictureBox> bulets = new List<PictureBox>();

        //ship prom && hits
        public PictureBox player;
        public  int speed, buletsCount = 0, hits = 0, reload;
        public int formWidth, formHeight;
        bool up, down, right, left;
        public bool reloaded = true;
        public Keys[] controls = new Keys[] { Keys.W, Keys.S, Keys.D, Keys.A, Keys.Space };

        //interfejs
        public Label Hits;
        //bot 
        public bool bot;
        int random, br1, br2;
        Random rnd = new Random();

        public void addShip(PictureBox Ship, int Speed, int Reload, Image Bulet,int BuletWidth, int BuletHeight, int BuletSpeed, int BuletTop, int BuletLeft)
        { 
            player = Ship;
            speed = Speed;
            reload = Reload;
            bulet = Bulet;
            buletSpeed = BuletSpeed;
            buletTop = BuletTop;
            buletLeft = BuletLeft;
            buletWitdth = BuletWidth;
            buletHeight = BuletHeight; 
        }

        public void move()
        {  
                if (up == true) { player.Top -= speed; }
                if (down == true) { player.Top += speed; }
                if (left == true) { player.Left -= speed; }
                if (right == true) { player.Left += speed; }
        }

        public void range()
        {
            if (player.Top <= 60) { up = false; br1 = 0; }
            if (player.Bottom >= formHeight-65) { down = false; br1 = 0; }
            if (player.Left <= 0) { left = false; br2 = 0; }
            if (player.Right >= formWidth) { right = false; br2 = 0; }
        }

        public void botMove()
        {
            //bot move up down
            if (br1 == 0)
            {
                random = rnd.Next(1, 3);
                switch (random)
                {
                    case 1:
                        down = true; up = false; br1 = 20;
                        break;
                    case 2:
                        up = true; down = false; br1 = 20;
                        break;
                }
            }
            br1--;
            //bot move left right
            if (br2 == 0)
            {
                random = rnd.Next(1, 3);
                switch (random)
                {
                    case 1:
                        left = true; right = false; br2 = 20;
                        break;
                    case 2:
                        right = true; left = false; br2 = 20;
                        break;
                }
            }
            br2--;          
        }      

        public PictureBox fire()
        {
            if (reloaded == true)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.BackgroundImage = bulet;
                pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox.Width = buletWitdth;
                pictureBox.Height = buletHeight;
                pictureBox.Top = player.Top + buletTop;
                pictureBox.Left = player.Left + buletLeft;
                bulets.Add(pictureBox);
                buletsCount++;
                reloaded = false;
                return pictureBox;             
            }
            return null;
        }

        public void buletMove(bool left = false)
        {
            if (left == true)
            {
                for (int i = 0; i < bulets.Count; i++)
                {
                    bulets[i].Left += buletSpeed;
                    if (bulets[i].Left >= formWidth)
                    {
                        bulets[i].Dispose();
                        bulets.RemoveAt(i);
                    }             
                }
            }
            else
            {
                for (int i = 0; i < bulets.Count; i++)
                {
                    bulets[i].Left -= buletSpeed;
                    if (bulets[i].Left <= 0)
                    {
                        bulets[i].Dispose();
                        bulets.RemoveAt(i);
                    }
                }
            }
                
        }

        public PictureBox buletHit(List<PictureBox> objekts, bool left = false)
        {
            if (left == true)
            {
                for (int i = 0; i < bulets.Count; i++)
                {
                    foreach (PictureBox objekt in objekts)
                    {
                        if (bulets[i].Right >= objekt.Left && bulets[i].Bottom + 1 >= objekt.Top && bulets[i].Top <= objekt.Bottom && bulets[i].Right <= objekt.Right)
                        {
                            if(Hits != null)
                            {
                                hits++;
                                bulets[i].Dispose();
                                bulets.RemoveAt(i);
                                Hits.Text = hits.ToString();
                            }
                            else
                            {
                                bulets[i].Dispose();
                                bulets.RemoveAt(i);
                                objekt.Left = -2000;
                                objekt.Dispose();                              
                            }
                            return objekt;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < bulets.Count; i++)
                {
                    foreach (PictureBox objekt in objekts)
                    {
                        if (bulets[i].Left <= objekt.Right && bulets[i].Bottom + 1 >= objekt.Top && bulets[i].Top <= objekt.Bottom && bulets[i].Left >= objekt.Left)
                        {
                            if(Hits != null)
                            {
                                hits++;
                                bulets[i].Dispose();
                                bulets.RemoveAt(i);
                                Hits.Text = hits.ToString();
                            }
                            else
                            {
                                bulets[i].Dispose();
                                bulets.RemoveAt(i);
                                objekt.Left = 2000;
                                objekt.Dispose();
                            }
                            return objekt;
                        }
                    }
                }
            }
            return null;
            
        }

        public void keyDown(Keys val)
        {
            if (val == controls[0]) { up = true; }
            if (val == controls[1]) { down = true; }
            if (val == controls[2]) { right = true; }
            if (val == controls[3]) { left = true; }
        }
        public void keyUp(Keys val)
        {
            if (val == controls[0]) { up = false; }
            if (val == controls[1]) { down = false; }
            if (val == controls[2]) { right = false; }
            if (val == controls[3]) { left = false; }
        }
    }
}
