using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceFiters
{
    class Player : Form1
    {
        PictureBox player;
        Form1 form;
        public bool up, down, right, left;
        public Keys[] controls = new Keys[] { Keys.W, Keys.S, Keys.D, Keys.A, Keys.Space };
        public PictureBox[] bulets = new PictureBox[50];
        public int buletsCount = 0, hits = 0, formWidth, formHeight;

        public Player(Form1 go)
        {
            up = down = right = left = false;
            form = go;

        }
        public void fiter()
        {
            PictureBox fiter = new PictureBox();
            fiter.BackgroundImage = SpaceFiters.Properties.Resources.background1;
            fiter.BackgroundImageLayout = ImageLayout.Stretch;
            fiter.BackColor = Color.Transparent;
            fiter.Width = 120;
            fiter.Height = 70;
            form.Controls.Add(fiter);
            player = fiter;
        }
        public void chageControls(char[] val)
        {
            for (int i = 0; i < 3; i++)
            {
                controls[i] = (Keys)char.ToUpper(val[i]);
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
        public void shoot()
        {
            PictureBox ok = new PictureBox();
            ok.BackColor = Color.Black;
            ok.Width = 30;
            ok.Height = 10;
            ok.Name = "bulet";
            ok.Top = player.Top;
            ok.Left = player.Left + 50;
            form.Controls.Add(ok);
            bulets[buletsCount] = ok;
            buletsCount++;
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
        public void keydown(KeyEventArgs val)
        {
            if (val.KeyCode == controls[0]) { this.up = true; }
            if (val.KeyCode == controls[1]) { this.down = true; }
            if (val.KeyCode == controls[2]) { this.right = true; }
            if (val.KeyCode == controls[3]) { this.left = true; }
            if (val.KeyCode == controls[4]) { this.shoot(); }
        }
        public void keyup(KeyEventArgs val)
        {
            if (val.KeyCode == controls[0]) { this.up = false; }
            if (val.KeyCode == controls[1]) { this.down = false; }
            if (val.KeyCode == controls[2]) { this.right = false; }
            if (val.KeyCode == controls[3]) { this.left = false; }
        }



    }
}
