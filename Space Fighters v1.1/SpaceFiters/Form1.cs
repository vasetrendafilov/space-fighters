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
    public partial class Form1 : Form
    {
        private static Form1 form = null;
        Player[] player = new Player[10];
        PictureBox[] fiters = new PictureBox[2];
        public int n,m=0,h=0;

        public Form1()
        {
            InitializeComponent();
            form = this;
            fiters[0] = pictureBox1;
            fiters[1] = pictureBox2;

        }
        private void btnMultiplayer_Click(object sender, EventArgs e)
        {
            panelMain.Visible = false;
            panelMyltiplayer1.Left = Width / 2 - 150;
            panelMyltiplayer1.Top = Height / 2 - panelMyltiplayer1.Height;
            panelMyltiplayer1.Visible = true;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelMain.Left = Width / 2 - 150;
            panelMain.Top = Height / 2 - panelMain.Height;
        }

        private void btnCampain_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelMyltiplayer1.Visible = false;
            panelMain.Visible = true;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            panelMyltiplayer1.Visible = false;

            
            for(int i = 0; i < n; i++)
            {
                foreach( PictureBox ship in fiters)
                {
                    
                    PictureBox ok = new PictureBox();
                    ok.BackgroundImage = ship.BackgroundImage;
                    ok.BackgroundImageLayout = ship.BackgroundImageLayout;
                    ok.BackColor = ship.BackColor;
                    ok.Width = ship.Width;
                    ok.Height = ship.Height;
                    ok.Visible = true;
                    ok.Top = h;
                    ok.Left = m;
                    ok.Tag = i;
                    ok.MouseClick += new MouseEventHandler(vase);
                    panelMultiplayer2.Controls.Add(ok);
                    m += 100;
                }
                h += 100;
                m = 0;
               
            }
            panelMultiplayer2.Visible = true;
        }
        public void vase(object sender, MouseEventArgs e)
        {
            PictureBox go = ((PictureBox)sender);
             go.BorderStyle = BorderStyle.FixedSingle;
                MessageBox.Show(go.Tag.ToString());//so tagot moza mda odberam koj fiter za koj e
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            n = comboBox1.SelectedIndex + 1;
        }
    }
}
