using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceGameBeta
{
    class Player:Form1
    {
        PictureBox player;
        public bool up, down, right, left;
        public Keys[] controls = new Keys[] { Keys.W, Keys.S, Keys.D, Keys.A, Keys.Space };
        public PictureBox[] bulets = new PictureBox[50];
        public int buletsCount = 0, hits = 0, formWidth, formHeight;

        public Player(Form1 go, PictureBox ko)
        {
            up = down = right = left = false;
            player = ko;

        }
        public void chageControls(char[]val)
        {
            for(int i = 0; i < 4; i++)
            {
                controls[i]= (Keys)char.ToUpper(val[i]);
            }
        }
        public void move()
        {
            if (up == true) { player.Top -= 3; }
            if (down == true) { player.Top += 3; }
            if (left == true) { player.Left -= 3; }
            if (right == true) { player.Left += 3; }
           
        }
        public void range()
        {
            if (player.Top <= 0) { up = false; }
            if (player.Bottom >= formHeight) { down = false; }
            if (player.Left <= 0) { left = false; }
            if (player.Right >= formWidth) { right = false; }
        }
        public PictureBox shoot()
        {
            PictureBox ok = new PictureBox();
            ok.BackColor = Color.Black;
            ok.Width = 30;
            ok.Height = 10;
            ok.Name = "bulet";
            ok.Top = player.Top;
            ok.Left = player.Left + 50;
            bulets[buletsCount] = ok;
            buletsCount++;
            return ok;
        }
        public void buletDetection(PictureBox[] objekts)
        {
            foreach (PictureBox bulet in this.bulets)
            {
                if (bulet != null && !bulet.IsDisposed)
                {
                    bulet.Left = bulet.Left + 10;
                    if (bulet.Left >= formWidth)
                    {
                        bulet.Dispose();
                    }
                    foreach (PictureBox objekt in objekts)
                    {
                        if (bulet.Right >= objekt.Left && bulet.Bottom + 1 >= objekt.Top && bulet.Top <= objekt.Bottom && bulet.Right <= objekt.Right)
                        {
                            hits++;
                            bulet.Dispose();
                        }
                    }


                }

            }
        }
        public void keydown(Keys val)
        {  
            if (val == controls[0]) { this.up = true; }
            if (val == controls[1]) { this.down = true; }
            if (val == controls[2]) { this.right = true; }
            if (val == controls[3]) { this.left = true; }
        }
        public void keyup(Keys val)
        {
            if (val == controls[0]) { this.up = false; }
            if (val == controls[1]) { this.down = false; }
            if (val == controls[2]) { this.right = false; }
            if (val == controls[3]) { this.left = false; }
        }



    }
}
