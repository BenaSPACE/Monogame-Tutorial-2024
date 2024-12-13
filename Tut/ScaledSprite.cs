using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tut;

internal class ScaledSprite : Sprite
{
    public Vector2 size;
    public Rectangle rectangle
    {
        get
        {
            return new Rectangle((int)position.X, (int)position.Y, (int)size.X, (int)size.Y);
        }
    }

    public ScaledSprite(Texture2D texture, Vector2 position, Vector2 size) : base(texture, position)
    {
        this.size = size;
    }
}