using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Arkanoid
{
    public class Opening : Scene
    {
        private int count = 0;
        private const int MAX = 200;

        Background background { get; set; }

        public Opening(Game game) : base(game)
        {
            this.background = new Background(Vector2.Zero, Game.Content.Load<Texture2D>(@"Images/bgOpening"));
        }

        public override void Update(GameTime gameTime)
        {
            if (count++ >= MAX)
                SceneManager.ChangeScene(Game);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin(SpriteSortMode.FrontToBack, BlendState.AlphaBlend);

            this.background.Draw(spriteBatch, Game.Window.ClientBounds);

            spriteBatch.End();
        }
    }
}
