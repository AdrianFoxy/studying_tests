using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    public class Hero
    {
        private int health;

        public int Id { get; set; }
        public string Name { get; set; }

        public delegate void HealthChangedHandler(object sender, int health);

        public event HealthChangedHandler OnHealthChanged;

        public int Health
        {
            get => this.health;
            set
            {
                if (this.health != value)
                {
                    this.health = value;
                    OnHealthChanged?.Invoke(this, this.health);
                }
            }
        }
    }

}
