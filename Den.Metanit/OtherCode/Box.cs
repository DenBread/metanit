using System;
using System.Collections.Generic;
using System.Text;

namespace OtherCode
{
    class Box
    {
        public int Height { get; set; }
        public int Wight { get; set; }
        public Box(int h, int w)
        {
            Height = h;
            Wight = w;
        }

        public void BoxInfo()
        {
            Console.WriteLine($"Height * Wight = {Height * Wight}");
        }
    }
}
