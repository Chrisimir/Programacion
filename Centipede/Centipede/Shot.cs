/*
 * Chris Lund Schober
 * IES San Vicente
 * Programing 2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centipede
{
    /**
      * This class will represent every fire shot from the main character
      */
class Shot : Image
    {
        const string SHOT_IMAGE = "imgs/fire_spritesheet.png";
        public const int SHOT_IMAGE_WIDTH = 21;
        public const int SHOT_IMAGE_HEIGHT = 25;
        public const int SHOT_SPRITE_WIDTH = 7;
        const int SHOT_NUMBER_SPRITES = 3;

        const int MAX_ANIMATION_COUNT = 30;

        bool visible = false;
        int animationCount = 0, currentSprite = 0;

        public Shot() : base (SHOT_IMAGE, SHOT_IMAGE_WIDTH, SHOT_IMAGE_HEIGHT)
        {
        }

        public bool IsVisible()
        {
            return visible;
        }

        public void SetVisible(bool visible)
        {
            this.visible = visible;
        }

        public void Move()
        {
            if (visible)
            {
                if (GetY() > - SHOT_IMAGE_HEIGHT)
                {
                    MoveTo(GetX(), (short)(GetY() - 1));
                    if (animationCount >= MAX_ANIMATION_COUNT)
                    {
                        currentSprite = (currentSprite + 1) % SHOT_NUMBER_SPRITES;
                        animationCount = 0; 
                    }
                    else
                    {
                        animationCount++;
                    }
                }
                else
                    visible = false;
            }
        }

        public void Draw(Hardware hardware)
        {
            hardware.DrawImage(this, (short)(SHOT_SPRITE_WIDTH * currentSprite), 0, SHOT_SPRITE_WIDTH, SHOT_IMAGE_HEIGHT);
        }

    }
}
