module CheckersGame
 
open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics
 
type CheckersGame() as this =
    inherit Game()

    do this.Window.Title <- "Checkers Game"

    let graphics = new GraphicsDeviceManager(this)
    do graphics.PreferredBackBufferWidth <- 800
    do graphics.PreferredBackBufferHeight <- 600

    //Unchecked.defaultOf is considered bad practice in F#.
    let mutable redRectangle = Unchecked.defaultof<Texture2D> 
    let mutable blackRectangle = Unchecked.defaultof<Texture2D> 
    let mutable spriteBatch = Unchecked.defaultof<SpriteBatch> 

    override this.LoadContent() =
        base.LoadContent()

        spriteBatch <- new SpriteBatch(this.GraphicsDevice)
        redRectangle <- new Texture2D(this.GraphicsDevice, 1, 1)
        blackRectangle <- new Texture2D(this.GraphicsDevice, 1, 1)

        redRectangle.SetData([| Color.Red |])
        blackRectangle.SetData([| Color.Black |])
        ()

    override this.UnloadContent() = 
        base.UnloadContent()
        spriteBatch.Dispose()
        redRectangle.Dispose()
        ()

    override this.Update(gameTime) =
        ()

    override this.Draw(gameTime) =
        this.GraphicsDevice.Clear Color.White

        spriteBatch.Begin()
        spriteBatch.Draw(blackRectangle, new Rectangle(10, 20, 80, 30), Color.Chocolate) 
        spriteBatch.End()