using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace PRR1_19_Visning
{
    class Bullet
    {
        List<Vector2> xwingBulletPos = new List<Vector2>();

        public Bullet(List<Vector2> bulletPos)
        {
            xwingBulletPos = bulletPos;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Vector2 bulletPos in xwingBulletPos)
            {
                Rectangle rec = new Rectangle();
                rec.Location = bulletPos.ToPoint();
                rec.Size = new Point(30, 30);
                spriteBatch.Draw(, rec, Color.Red);
            }
        }
    }
}
