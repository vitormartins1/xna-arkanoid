using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Arkanoid
{
    class Level03 : BaseLevel
    {
        private List<Rect> listRect = new List<Rect>();
        private const int NUM_RECT = 13;
        private const int NUM_LINE = 3;
        private const int NUM_IMG = 3;
        private Texture2D[] textureRect = new Texture2D[NUM_IMG];

        private Background background { get; set; }

        public Level03(Game game)
            : base(game)
        {
            this.background = new Background(Vector2.Zero, Game.Content.Load<Texture2D>(@"Images/background"));

            this.textureRect[0] = Game.Content.Load<Texture2D>(@"Images/azul");
            this.textureRect[1] = Game.Content.Load<Texture2D>(@"Images/amarelo");
            this.textureRect[2] = Game.Content.Load<Texture2D>(@"Images/vermelho");

            for (int j = 0; j < NUM_LINE; j++)
            {
                for (int i = 0; i < NUM_RECT; i++)
                {
                    Rect rect = new Rect(new Vector2(20 + i * this.textureRect[0].Width + i, j + 100 + (j * (this.textureRect[0].Height))),
                                         ref this.textureRect[j % NUM_IMG],
                                         Vector2.Zero,
                                         j * NUM_RECT + i);
                    this.listRect.Add(rect);
                }
            }
        }

        public override void Update(GameTime gameTime)
        {
            if (listRect.Count <= 0)
            {
                SceneManager.ChangeScene(Game);
            }

            foreach (Rect r in listRect)
            {
                if (r.Collision(this.Ball))
                {
                    listRect.Remove(r);
                    this.Ball.Speed = new Vector2(this.Ball.Speed.X, -this.Ball.Speed.Y);
                    break;
                }
            }

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();

            this.background.Draw(spriteBatch, Game.Window.ClientBounds);

            foreach (Rect r in listRect)
            {
                spriteBatch.Draw(r.Texture, r.Rectangle, Color.White);
            }

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
