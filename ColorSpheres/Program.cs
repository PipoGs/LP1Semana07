﻿using System;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color color = new Color(255, 50, 125);
            Sphere sphere = new Sphere(color, 5.0f);
            sphere.Throw();
            sphere.Pop();
            sphere.Throw();
            sphere.Throw();

            System.Console.Write( {color1.GetGrey()});
            System.Console.Write({sphere.GetTimesThrown()});
        }
    }
}
