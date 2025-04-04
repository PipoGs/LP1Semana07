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

        public string Name
        {
            get => _name;
        }
        public float Health
        {
            get => _health;
            set
            {
                if (value > 0 && value < MaxHealth)
                {
                    _health = value;
                }
                else if (value <= 0)
                {
                    _health = 0;
                }
                else if (value >= MaxHealth)
                {
                    _health = MaxHealth;
                }
            }
        }

        public int XP
        {
            get => _xp;
            set
            {
                _xp += value;
            }
        }

        public int Level
        {
            get => 1 + XP / 1000;
        }

        public float MaxHealth
        {
            get => 100 + (Level - 1) * 20;
        }

        public float TakeDamage(float damage)
        {
            if (damage > 0)
            {
                Health -= damage;
                _xp += (int)damage / 20;
                return Health;
            }
            else
            {
                return Health;
            }
        }

        public Hero(string name)
        {
            _name = name;
            _health = MaxHealth;
            _xp = 0;
        }
    }
}