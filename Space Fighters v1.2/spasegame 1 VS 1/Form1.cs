using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spasegame_1_VS_1
{
    public partial class Form1 : Form
    {
        //multiplauer promenlivi
        bool left1, right1, up1, down1;
        bool left2, right2, up2, down2;
        int reloading1 = 0, reloading2 = 0;
        bool reloaded1 = true, reloaded2 = true;
        bool multipl,singlepl;
        int scorepl1 = 0, scorepl2 = 0, boomtime = 0;
        int ref1 = 5, ref2 = 5, f1 = 0, f2 = 0;

        private void player1_Click(object sender, EventArgs e)
        {

        }

        //singlplayer promenlivi
        int random, brojac = 0, start = 0, finsh = 3,timebulet=0,buletspeedpl=10,buletspeedbot=10,botspeed=4;
        bool time,time2;
        int brojac2 = 0, start2 = 0,finish2=3,rundom2;
        Random rnd = new Random();
        Random rnd2 = new Random();
        private void button4_Click(object sender, EventArgs e)
        {
            multipl = true;
            button_singlepl.Dispose();
            button_multipl.Dispose();
            button5.Dispose();
            //bloks for use
            labelpl1.Visible = true;
            labelpl2.Visible = true;
            reloadpl1.Visible = true;
            reloadpl2.Visible = true;
            player1.Visible = true;
            player2.Visible = true;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            singlepl = true;
            button_singlepl.Dispose();
            button_multipl.Dispose();
            button5.Dispose();
            //bloks for use
            labelpl1.Visible = true;
            labelpl2.Visible = true;
            reloadpl1.Visible = true;
            reloadpl2.Visible = true;
            player1.Visible = true;
            player2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (boomtime == 100)
            {
                boom.Visible = false;
                boomtime = 0;
                timer1.Start();
                timer2.Stop();

            }
            boomtime++;
            fire.Visible = false;
            fire2.Visible = false;
            fire.Top = 0;
            fire.Left = 1050;
            fire2.Top = 0;
            fire2.Left = 1050;
   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (multipl == true)
            {
                //bulet player2 hit
                if (bulet1.Right >= player2.Left && bulet1.Bottom + 1 >= player2.Top && bulet1.Top <= player2.Bottom && bulet1.Right <= player2.Right)
                {
                    scorepl1++;
                    bulet1.Visible = false;
                    bulet1.Top = 0;
                    bulet1.Left = 0;
                    reloaded1 = true;
                    reloading1 = 0;
                    boom.Top = player2.Top - 5;
                    boom.Left = player2.Left - 5;
                    boom.Visible = true;
                    timer1.Stop();
                    timer2.Start();
                }
                //bulet player 1 hit
                if (bulet2.Left <= player1.Right && bulet2.Bottom + 1 >= player1.Top && bulet2.Top <= player1.Bottom && bulet2.Left >= player1.Left)
                {
                    scorepl2++;
                    bulet2.Visible = false;
                    bulet2.Top = 0;
                    bulet2.Left = 1000;
                    reloaded2 = true;
                    reloading2 = 0;
                    boom.Top = player1.Top - 5;
                    boom.Left = player1.Left - 5;
                    boom.Visible = true;
                    timer1.Stop();
                    timer2.Start();
                }
                //bulet player 1
                if (bulet1.Visible == true)
                {
                    bulet1.Left += 10;
                    if (reloading1 == 100)
                    {
                        bulet1.Top = 0;
                        bulet1.Left = 0;
                        bulet1.Visible = false;
                        reloaded1 = true;
                        reloading1 = 0;

                    }
                    reloading1++;
                }
                //bulet player2
                if (bulet2.Visible == true)
                {
                    bulet2.Left -= 10;
                    if (reloading2 == 100)
                    {
                        bulet2.Top = 0;
                        bulet2.Left = 0;
                        bulet2.Visible = false;
                        reloaded2 = true;
                        reloading2 = 0;

                    }
                    reloading2++;
                }
                //player1 range screen
                if (player1.Top <= 0) { up1 = false; }
                if (player1.Bottom >= Height) { down1 = false; }
                if (player1.Left <= 0) { left1 = false; }
                if (player1.Right >= Width - 30 ) { right1 = false; }
                //player2 range screen
                if (player2.Top <= 0) { up2 = false; }
                if (player2.Bottom >= Height) { down2 = false; }
                if (player2.Left <= 0) { left2 = false; }
                if (player2.Right >= Width - 30) { right2 = false; }
                //player1 move
                if (left1 == true) { player1.Left -= 5; }
                if (right1 == true) { player1.Left += 5; }
                if (up1 == true) { player1.Top -= 5; }
                if (down1 == true) { player1.Top += 5; }
                //player2 move
                if (left2 == true) { player2.Left -= 5; }
                if (right2 == true) { player2.Left += 5; }
                if (up2 == true) { player2.Top -= 5; }
                if (down2 == true) { player2.Top += 5; }
                //score
                labelpl1.Text = scorepl1.ToString();
                labelpl2.Text = scorepl2.ToString();
                //reload player 1
                if (reloaded1 == true)
                {
                    reloadpl1.Text = "RELOADED :)";
                    f1 = 0;
                    ref1 = 5;
                }
                else
                {
                    reloadpl1.Text = "RELOADING[" + ref1.ToString() + "]";
                    if (f1 == 20)
                    {
                        ref1--;
                        f1 = 0;
                    }
                    f1++;
                }
                //reload player 2
                if (reloaded2 == true)
                {
                    reloadpl2.Text = "RELOADED :)";
                    f2 = 0;
                    ref2 = 5;
                }
                else
                {
                    reloadpl2.Text = "RELOADING[" + ref2.ToString() + "]";
                    if (f2 == 20)
                    {
                        ref2--;
                        f2 = 0;
                    }
                    f2++;
                }
                //engine fire player1
                if (right1 == true)
                {
                    fire.Left = player1.Left - 23;
                    fire.Top = player1.Top + 38;
                    fire.Visible = true;
                }
                else
                {
                    fire.Visible = false;
                }
                //engine fire player2
                if (left2 == true)
                {
                    fire2.Left = player2.Right;
                    fire2.Top = player2.Top + 36;
                    fire2.Visible = true;
                }
                else
                {
                    fire2.Visible = false;
                }
            }
            if (singlepl == true)
            {
                //bulet player2 hit
                if (bulet1.Right >= player2.Left && bulet1.Bottom + 1 >= player2.Top && bulet1.Top <= player2.Bottom && bulet1.Right <= player2.Right)
                {
                    scorepl1++;
                    bulet1.Visible = false;
                    bulet1.Top = 0;
                    bulet1.Left = 0;
                    bulet1.Top = 0;
                    bulet1.Left = 0;
                    reloaded1 = true;
                    reloading1 = 0;
                    boom.Top = player2.Top - 5;
                    boom.Left = player2.Left - 5;
                    boom.Visible = true;
                    timer1.Stop();
                    timer2.Start();
                }
                //bulet player 1 hit
                if (bulet2.Left <= player1.Right && bulet2.Bottom + 1 >= player1.Top && bulet2.Top <= player1.Bottom && bulet2.Left >= player1.Left)
                {

                    scorepl2++;
                    bulet1.Visible = false;
                    bulet2.Visible = false;
                    bulet2.Top = 0;
                    bulet2.Left = 0;
                    bulet1.Top = 0;
                    bulet1.Left = 0;
                    reloaded2 = true;
                    reloading2 = 0;
                    boom.Top = player1.Top - 5;
                    boom.Left = player1.Left - 5;
                    boom.Visible = true;
                    timer1.Stop();
                    timer2.Start();
                }
                //bulet player 1
                if (bulet1.Visible == true)
                {
                    bulet1.Left += buletspeedpl;
                    if (reloading1 == 100)
                    {
                        bulet1.Top = 0;
                        bulet1.Left = 0;
                        bulet1.Visible = false;
                        reloaded1 = true;
                        reloading1 = 0;

                    }
                    reloading1++;
                }
                //bulet player2
                if (bulet2.Visible == true)
                {
                    bulet2.Left -= buletspeedbot;
                    if (reloading2 == 100)
                    {
                        bulet2.Top = 0;
                        bulet2.Left = 0;
                        bulet2.Visible = false;
                        reloaded2 = true;
                        reloading2 = 0;

                    }
                    reloading2++;
                }
                //player1 range screen
                if (player1.Top <= 97) { up1 = false; }
                if (player1.Bottom >= 564) { down1 = false; }
                if (player1.Left <= 0) { left1 = false; }
                if (player1.Right >= 985) { right1 = false; }
                //player move
                if (left1 == true) { player1.Left -= 5; }
                if (right1 == true) { player1.Left += 5; }
                if (up1 == true) { player1.Top -= 5; }
                if (down1 == true) { player1.Top += 5; }
                //bot move up down
                if (time == true)
                {
                    brojac++;
                
                }
                if (brojac == 40)
                {
                    time = false;
                    brojac = 0;
                }
                if (time == false)
                {
                    random = rnd.Next(start, finsh);
                }
                if (player2.Bottom >= 550)
                {
                    time = false;
                    start = 1;
                    random = 2;
                }
                if (player2.Top <= 110)
                {
                    time = false;
                    random = 1;
                    brojac = 0;
                }
                if (random == 1)
                {
                    player2.Top +=botspeed;
                    time = true;
                }
                if (random == 2)
                {
                    player2.Top -= botspeed;
                    time = true;
                }
                //bot move left right
                if (time2 == true)
                {
                    brojac2++;

                }
                if (brojac2 == 30)
                {
                    time2 = false;
                    brojac2 = 0;
                }
                if (time2 == false)
                {
                    rundom2 = rnd2.Next(start2, finish2);
                }
                if (player2.Right >= 985)
                {
                    time2 = false;
                    start2 = 1;
                    rundom2 = 2;
                }
                if (player2.Left <= 700)
                {
                    time2= false;
                    rundom2 = 1;
                    brojac2 = 0;
                }
                if (rundom2 == 1)
                {
                    player2.Left += 3;
                    time2 = true;
                    fire2.Visible = false;
                }
                if (rundom2 == 2)
                {
                    player2.Left -= 3;
                    time2 = true;
                    fire2.Left = player2.Right;
                    fire2.Top = player2.Top + 36;
                    fire2.Visible = true;
                }
                //engine fire
                if (right1 == true)
                {
                    fire.Left = player1.Left - 23;
                    fire.Top = player1.Top + 38;
                    fire.Visible = true;
                }
                else
                {
                    fire.Visible = false;
                }
                //reload player 
                if (reloaded1 == true)
                {
                    reloadpl1.Text = "RELOADED :)";
                    f1 = 0;
                    ref1 = 5;
                }
                else
                {
                    reloadpl1.Text = "RELOADING[" + ref1.ToString() + "]";
                    if (f1 == 20)
                    {
                        ref1--;
                        f1 = 0;
                    }
                    f1++;
                    if (ref1 == 0)
                    {
                        reloaded1 = true;
                    }
                }
                //reload player bot
                if (reloaded2 == true)
                {
                    reloadpl2.Text = "RELOADED :)";
                    f2 = 0;
                    ref2 = 5;
                }
                else
                {
                    reloadpl2.Text = "RELOADING[" + ref2.ToString() + "]";
                    if (f2 == 20)
                    {
                        ref2--;
                        f2 = 0;
                    }
                    f2++;
                }
                //fire bulet bot delay
                if (reloaded2 == true)
                {
                    if (timebulet == 25)
                    {
                        bulet2.Top = player2.Top + 48;
                        bulet2.Left = player2.Left - 30;
                        bulet2.Visible = true;
                        reloaded2 = false;
                        timebulet = 0;
                    }
                    timebulet++;
            }

                if (scorepl1 == 5)
                {
                    buletspeedbot=12;
                    buletspeedpl=9;
                    
                }
                if (scorepl1 == 10)
                {
                    buletspeedbot = 14;
                    buletspeedpl = 8;
                    botspeed = 5;
                }
                if (scorepl1 == 15)
                {
                    buletspeedbot = 16;
                    buletspeedpl = 6;
                }




                labelpl1.Text = scorepl1.ToString();
                labelpl2.Text = scorepl2.ToString();

            }

        }
        public Form1()
        {
            InitializeComponent();
           
        }
        
            private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
                //player1 move keys
                if (e.KeyCode == Keys.W) { up1 = true; }
                if (e.KeyCode == Keys.S) { down1 = true; }
                if (e.KeyCode == Keys.D) { right1 = true; }
                if (e.KeyCode == Keys.A) { left1 = true; }
                if (e.KeyCode == Keys.Space)
                {
                    if (reloaded1 == true && timer1.Enabled == true)
                    {
                        bulet1.Top = player1.Top + 48;
                        bulet1.Left = player1.Right - 3;
                        bulet1.Visible = true;
                        reloaded1 = false;
                    }

                }
                
                //player2 move keys
                if (e.KeyCode == Keys.Up) { up2 = true; }
                if (e.KeyCode == Keys.Down) { down2 = true; }
                if (e.KeyCode == Keys.Right) { right2 = true; }
                if (e.KeyCode == Keys.Left) { left2 = true; }
                if (e.KeyCode == Keys.M)
                {
                    if (reloaded2 == true && timer1.Enabled == true)
                    {
                        bulet2.Top = player2.Top + 48;
                        bulet2.Left = player2.Left - 30;
                        bulet2.Visible = true;
                        reloaded2 = false;
                    }
                }
             
            //menu
            if (e.KeyCode == Keys.Escape) { timer1.Stop(); }
            if (e.KeyCode == Keys.Enter) { timer1.Start(); }
            if(e.KeyCode == Keys.R) { scorepl1 = 0;scorepl2 = 0;}
            if(e.KeyCode == Keys.Q) {  }
        }

            private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           
               
                    if (e.KeyCode == Keys.W) { up1 = false; }
                    if (e.KeyCode == Keys.S) { down1 = false; }
                    if (e.KeyCode == Keys.D) { right1 = false; }
                    if (e.KeyCode == Keys.A) { left1 = false; }
                    if (e.KeyCode == Keys.Up) { up2 = false; }
                    if (e.KeyCode == Keys.Down) { down2 = false; }
                    if (e.KeyCode == Keys.Right) { right2 = false; }
                    if (e.KeyCode == Keys.Left) { left2 = false; }
                    
             
        }
    }
}
