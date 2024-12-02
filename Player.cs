using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_4_2
{
    internal class Player
    {
        private string _name;
        private int level;

        public Player(string name, int level)
        {
            this._name = name;
            this.level = level;
        }

        public void Attack()
        {
            Console.WriteLine("攻撃!");
        }
        public void Defence()
        {
            Console.WriteLine("防御!");
        }

        public void LevelUp()
        {
            level++;
        }
        public string GetName()
        {
            return _name;
        }

        public int GetLevel() 
        {
           return level;
        }
    }
}
