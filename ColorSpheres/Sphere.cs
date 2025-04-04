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

        public void Pop()
        {
            _radius = 0;

        }

        public void Throw()
        {
            if (_radius > 0)
            {
                _ThrowCounter++;
            }

        }

        public float GetRadius()
        {
            return _radius;
        }

        public int GetTimesThrown()
        {
            return _ThrowCounter;
        }
    }
}