using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTE
{
    public enum Bullet_Type
    {
        sniper,rifle,gun,bazooka
    }
    public class Bullet
    {
        //FIELDS
        private int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        private int bullet_damage;
        public int Bullet_damage
        {
            get { return bullet_damage; }
            set { bullet_damage = value; }
        }

        private Bullet_Type type;
        public Bullet_Type Type
        {
            get { return type; }
            set { type = value; }
        }
        //CONSTRUCTORS
        public Bullet(Bullet_Type type,int speed, int bullet_damage)
        {
            this.speed = speed;
            this.bullet_damage = bullet_damage;
            this.type = type;
        }


        //METHODS
    }
}
