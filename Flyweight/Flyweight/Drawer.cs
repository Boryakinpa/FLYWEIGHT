using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal static class Drawer
    {
        public static void Draw(string path)
        {
            System.Drawing.Image Picture = System.Drawing.Image.FromFile(path);
            int dsfdfsfd = 7;
            int newWidth = Picture.Width / dsfdfsfd;
            int newHeight = Picture.Height / dsfdfsfd;

            int currentWidth = Console.WindowWidth;
            int currentHeight = Console.WindowHeight;

            Console.SetBufferSize(Math.Max(newWidth * 2, currentWidth), Math.Max(newHeight * 2, currentHeight));

            FrameDimension Dimension = new FrameDimension(Picture.FrameDimensionsList[0]);
            int FrameCount = Picture.GetFrameCount(Dimension);

            int Left = Console.WindowLeft, Top = Console.WindowTop;
            char[] Chars = { '#', '#', '@', '%', '=', '+', '*', ':', '-', '.', ' ', '_' };

            Picture.SelectActiveFrame(Dimension, 0);

            for (int i = 0; i < newHeight; i++)
            {
                for (int x = 0; x < newWidth; x++)
                {
                    Color Color = ((Bitmap)Picture).GetPixel(x * dsfdfsfd, i * dsfdfsfd);

                    int Gray = (Color.R + Color.G + Color.B) / 3;
                    int Index = (Gray * (Chars.Length - 1)) / 255;

                    Console.Write(Chars[Index]);
                }
                Console.Write('\n');
            }

            Console.Read();
        }
    }
}
