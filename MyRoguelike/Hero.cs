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
        private float _damage;

        public float Health
        {
            get => _health;
            set
            {
                if (0 < value < MaxHealth)
                {
                    _health = value;
                }
                else if (value > MaxHealth)
                {
                    _health = MaxHealth;
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

        public float MaxHealth
        {
            get => _maxHealth = 100 + (Level - 1) * 20;
        }

        public float TakeDamage(float damage)
        {
            if (damage > 0)
            {
                Health -= damage;
                SetXp += (damage / 20);
                return Health;
            }
            else
            {
                return Health;
            }
        }
    }
}