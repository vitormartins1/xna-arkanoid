using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.GamerServices;

namespace Arkanoid
{
    public abstract class Scene : Microsoft.Xna.Framework.DrawableGameComponent
    {
        static public SpriteBatch spriteBatch { get; set; }

        public Scene(Game game) : base(game)
        {
            spriteBatch =  new SpriteBatch(Game.GraphicsDevice);
            //spriteBatch = (SpriteBatch)Game.Services.GetService(typeof(SpriteBatch)); 
        }
    }
}
