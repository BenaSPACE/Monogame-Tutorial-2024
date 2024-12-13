using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Tut;

public class Spritesheet{
    Texture2D texture;
    int width, height, spritewidth, spriteheight;

//VERY BAD USECASE, use only if you're creating a new spritesheet b
    Spritesheet(Texture2D texture){
        texture = null;
        width = 0;
        height = 0;
        spritewidth = 0;
        spriteheight = 0;
    }
    Spritesheet(Texture2D texture, int spritewidth, int spriteheight){
        this.texture = texture; 
        this.spritewidth = spritewidth;
        this.spriteheight = spriteheight;
        this.width = texture.Width;
        this.height = texture.Height;
    }

    // public Sprite[] createSpritesheetByDivision(int columns, int rows){
    //     Sprite sprite[] = new Sprite[columns*rows];
    //     return sprite;
    // }
}