using System;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color color = new Color(255, 0, 0);
            Sphere sphere = new Sphere(color, 5.0f);
            Console.WriteLine($"{color.GetRed()}, {color.GetGreen()}, {color.GetBlue()}");
            Console.WriteLine($"{sphere.GetRadius()}");
            Console.WriteLine($"{sphere.GetTimesThrown()}");
        }
    }
}
