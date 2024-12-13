using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Tut;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    Texture2D derf;
    ScaledSprite sprite;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        derf = Content.Load<Texture2D>("derf");

        sprite = new ScaledSprite(derf, new Vector2(100, 100), new Vector2(100, 200));

        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        sprite.position.X += 1;

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Red);

        // TODO: Add your drawing code here
        _spriteBatch.Begin(SpriteSortMode.Deferred, samplerState: SamplerState.AnisotropicWrap, blendState: BlendState.AlphaBlend);
        // _spriteBatch.Draw(derf, new Rectangle(100, 100, 200, 200), new Color(255, 255, 255, 255));
        _spriteBatch.Draw(sprite.texture, sprite.rectangle, Color.White);
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
