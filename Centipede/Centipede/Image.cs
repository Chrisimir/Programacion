/*
 * Chris Lund Schober
 * IES San Vicente
 * Programing 2
 */
using System;
using Tao.Sdl;

namespace Centipede
{
    /**
      * This class will store information about an image
      */
class Image
    {
        short x, y;
        short imageWidth, imageHeight;
        IntPtr image;

        public Image(string fileName, short width, short height)
        {
            image = SdlImage.IMG_Load(fileName);
            if (image == IntPtr.Zero)
            {
                Console.WriteLine("Image not found");
                Environment.Exit(1);
            }

            imageWidth = width;
            imageHeight = height;
        }

        public void MoveTo(short x, short y)
        {
            this.x = x;
            this.y = y;
        }

        public short GetX()
        {
            return x;
        }

        public short GetY()
        {
            return y;
        }

        public short GetImageWidth()
        {
            return imageWidth;
        }

        public short GetImageHeight()
        {
            return imageHeight;
        }

        public IntPtr GetImage()
        {
            return image;
        }

        public bool CollidesWith(Image img, short w1, short h1, short w2, short h2)
        {
            return (x + w1 >= img.x && x <= img.x + w2 &&
                    y + h1 >= img.y && y <= img.y + h2);
        }
    }
}
