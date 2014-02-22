using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GTE
{
   public class Player
    {
        //FIELDS

       int _screenheight, _screenwidth;
       private float Rotationangle;
       private Vector2 origin;
       private Vector2 distance;

        private Rectangle rec_player;
        public Rectangle Rec_Player
        {
            get { return rec_player; }
            set { rec_player = value; }
        }
        private Rectangle rec_pointer;
        public Rectangle Rec_Pointer
        {
            get { return rec_pointer; }
            set { rec_pointer = value; }
        }

        private Game1 game;
        public Game1 Game
        {
            get { return game; }
            set { game = value; }
        }
        private int pv;
        public int Pv
        {
            get { return pv; }
            set { pv = value; }
        }

        private int pv_max;
        public int Pv_Max
        {
            get { return pv_max; }
            set { pv = value; }
        }
        
         private Weapon_Type weapon;
         public Weapon_Type Weapon
         {
             get { return weapon; }
             set { weapon = value; }
         }

        //CONSTRUCTORS
        public Player (Game1 game,int pv_max, int pv, Weapon_Type weapon)
        {
            this.game = game;
            this.pv_max = pv_max;
            this.pv = pv;
            this.weapon = weapon;
            _screenwidth = game.screenwidth;
            _screenheight = game.screenheight;
        }

        //METHODS
        public void Orienter(MouseState mouse)
        {

            if (mouse.X > 0 && mouse.X < _screenwidth - rec_pointer.Width)
            {
                rec_pointer.X = mouse.X;
            }
            if (mouse.Y > 0 && mouse.Y < _screenheight - rec_pointer.Height)
            {
                rec_pointer.Y = mouse.Y;
            }
            distance.X = mouse.X - rec_player.X;
            distance.Y = mouse.Y - rec_player.Y;
            Rotationangle = (float)Math.Atan2(distance.Y, distance.X);
            origin = new Vector2((rec_player.Width / 2), (rec_player.Height / 2));

        }

        public void Tirer(MouseState mouse)
        {
            if (Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                //new Bullet(BulletOf(weapon), 
                //Weapons.SoundOf(this.weapon).Play();
            }

        }


        public void Initialize()
        {
            rec_pointer = new Rectangle(_screenwidth / 2, (_screenheight / 2) - 200, 46, 46);
                
        }

        public void Update()
        {
            Orienter(Mouse.GetState());
            Tirer(Mouse.GetState(), Weapon);
        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(Resources.texture_pointer,rec_pointer,new Rectangle(0,0,23,24),Color.White);
        }

    }
}
