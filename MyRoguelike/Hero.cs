using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRoguelike
{
    public class Hero
    {
        private float _health;
        private int _xp;
        private readonly string _name;
        private readonly string _level;

        public float Health
        {
            get => _health;
            set
            {
                if (value > 0)
                {
                    _health = value;
                }
                else
                {
                    _health = 0;
                }
            }
        }

        public int Xp
        {
            get => _xp;
            set
            {
                if (value > 0)
                {
                    _xp = value;
                }

            }
        }

        public int Level
        {
            get => 1 + GetXp() / 1000;
        }
    }