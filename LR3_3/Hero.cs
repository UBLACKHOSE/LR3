using System;
using System.Collections.Generic;
using System.Text;

namespace LR3_3
{
    public class Hero
    {
        private string nickname;
        private int hp,x,y;
        private int damage { get; set; }

        Hero(int _x = 0,int _y = 0, int _damage = 10, int _hp = 100)
        {
            x = _x;
            y = _y;
            damage = _damage;
            hp = _hp;
        }
        
        public Location Moving(Location location)
        {
            return location;
        }

        //public void Hit()
        //{

        //}

        public void Taking_damage(int _damage)
        {
            if (hp >= damage)
            {
                hp -= _damage;
            }
            else
            {
                throw new Exception("ТЫ СДОХ") ;/* Исправить */
            }

        }



        
    }
}
