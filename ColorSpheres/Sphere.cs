using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorSpheres
{
    public class Sphere
    {
        private Color _color;
        private float _radius;
        private int _ThrowCounter;

        public Sphere(Color color, float radius)
        {
            _color = color;
            _radius = radius;
            _ThrowCounter = 0;
        }

        private void Pop()
        {

        }
    }
}