using System.Drawing;
using System.Windows.Forms;
namespace SpaceGame
{
    class Ship
    {
        public Image image, buletImage;
        public int width, height, speed, reload;
        public int buletTop, buletLeft, buletSpeed, buletWidth, buletHeight;
 
        public Ship(Image Image, int Width, int Height, int Speed,int Reload, Image ImageBulet, int BuletLeft, int BuletTop, int BuletWidth, int BuletHeight, int BuletSpeed)
        {          
            image = Image;          
            width = Width;
            height = Height;
            speed = Speed;
            reload = Reload;
            buletTop = BuletTop;
            buletLeft = BuletLeft;
            buletImage = ImageBulet;
            buletSpeed = BuletSpeed;
            buletHeight = BuletHeight;
            buletWidth = BuletWidth;
        }
        public PictureBox make()
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.BackgroundImage = image;
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox.Width = width;
            pictureBox.Height = height;
            return pictureBox;
        }

    }
}
