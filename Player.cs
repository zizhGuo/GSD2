using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevationMaster
{
    class Player
    {
        private int hp;
        private int strength;
        private Player enemy;
        public int HP
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
            }
        }
        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }
        public Player(int hp, int strength)
        {
            this.hp = hp;
            this.strength = strength;
        }
        public void fight(Player enemy)
        {
            this.enemy = enemy;
            enemy.enemy = this;
        }
    }
}
