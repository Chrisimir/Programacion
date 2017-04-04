using System;
using Tao.Sdl;

namespace Centipede
{
    /**
      * This class will store all the relevant information about an image: file name, width, height...
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
    }
}
