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
    public partial class Form1 : Form
    {
        public static Form1 form;
        public PictureBox[] objekts = new PictureBox[2];
        Player[] player = new Player[10];
        PictureBox[] ships = new PictureBox[10];
        public int n = 2;
        public Form1()
        {

            form = this;           
            InitializeComponent();
           
            pictureBox1.Left = 600;
            pictureBox2.Left = 600;
            objekts[0] = pictureBox1;
            objekts[1] = pictureBox2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.fiters();
            for (int i = 0; i < n; i++)
            {
            
                player[i] = new Player(form,ships[i]);
                player[i].formHeight = Height;
                player[i].formWidth = Width;                    
            }
            player[1].controls[0] = Keys.I;
            player[1].controls[1] = Keys.K;
            player[1].controls[2] = Keys.L;
            player[1].controls[3] = Keys.J;
            player[1].controls[4] = Keys.M;
           

            button1.Dispose();
            textBox4.Dispose();
            textBox3.Dispose();
            textBox2.Dispose();
            textBox1.Dispose();
            timer1.Enabled = true;
           
          
        }
        public void fiters()
        {
            for (int i = 0; i < n; i++)
            {
                PictureBox ko = new PictureBox();
                ko.BackgroundImage = SpaceGameBeta.Properties.Resources.fiter;
                ko.BackgroundImageLayout = ImageLayout.Stretch;
                ko.BackColor = Color.Transparent;
                ko.Width = 80;
                ko.Height = 50;
                this.Controls.Add(ko);
                ships[i] = ko;
            }
        }
        public void addBulets(PictureBox val)
        {
            this.Controls.Add(val);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            for(int i = 0; i < n; i++)
            {
                player[i].keydown(e.KeyCode);
                if(e.KeyCode == player[i].controls[4]) { this.addBulets(player[i].shoot()); }
            }         
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                player[i].keyup(e.KeyCode);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            for (int i = 0; i < n; i++)
            {
                player[i].range();
                player[i].move();
                player[i].buletDetection(objekts);
            }
            label1.Text = player[0].hits.ToString();
            label2.Text = player[1].hits.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }

}
