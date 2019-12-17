using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace PRR1_19_Visning
{
    class Xwing
    {
        Texture2D xwing;
        Vector2 xwingVec = new Vector2(100, 300);

        KeyboardState kNewState;
        KeyboardState kOldState;
        public Xwing(Texture2D xwingTex)
        {
            xwing = xwingTex;
        }

        public Xwing( Texture2D xwingTex, Vector2 xwingPos)
        {
            xwingVec = xwingPos;
            xwing = xwingTex;
        }

        public void Update()
        {
            kNewState = Keyboard.GetState();

            if (kNewState.IsKeyDown(Keys.Right))
                xwingVec.X += 10;
            if (kNewState.IsKeyDown(Keys.Left))
                xwingVec.X -= 10;

            
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(xwing, xwingVec, Color.White);
        }
    }
}
