using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyRoguelike
{
    public class Hero
    {
        private float _health;
        private readonly float _maxHealth;
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

        public MaxHealth
        {
            get => _maxHealth = 100 + (Level - 1) * 20;
        }
}
}