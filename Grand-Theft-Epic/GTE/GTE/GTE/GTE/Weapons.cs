using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTE
{
    class Weapons
    {
        
    public enum Weapon_Type
    { fist, sniper, rifle, gun, bazooka, shotgun };

    public class Weapons
    {
        private Weapon_Type weapon_type;
        public Weapon_Type Weapon_type 
        { 
            get { return weapon_type; }
        }

        public Bullet_Type bullet;
        public Bullet_Type Bullet 
        {
            get { return bullet; } 
        }


        //Constructor
        public void Weapon(Weapon_Type weapon, Bullet_Type bullet)
        {
            this.weapon_type = weapon;
            this.bullet = bullet;   
        }


        //Methods
        //public SoundEffect SoundOf(Weapons weapon)
        //{
        //    switch (weapon_type)
        //    {
        //        case Weapon_Type.sniper:
        //            return Game1.effect_sniper;
        //            break;
        //        case Weapon_Type.rifle:
        //            //return effect_rifle;
        //            break;
        //        case Weapon_Type.gun:
        //            //return effect_sniper;
        //            break;
        //        case Weapon_Type.bazooka:
        //            //return effect_sniper;
        //            break;
        //        case Weapon_Type.shotgun:
        //            //return effect_sniper;
        //            break;
        //    }
        //}


        public void Initialize()
        {

        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spritebatch)
        {

        }
    }

}
    }
}
