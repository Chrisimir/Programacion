/*
 * Chris Lund Schober
 * IES San Vicente
 * Programing 2
 */
namespace Centipede
{
    /**
     * This class manages the movement of each centipede blick
     */
class CentipedeBlock : Image
    {
        const int MAX_STEPS_VERTICAL = 25;  // Number of steps to go down after finishing each row

        const string CENTIPEDE_BLOCK_IMAGE = "imgs/centipede_spritesheet.png";
        public const int CENTIPEDE_BLOCK_IMAGE_WIDTH = 50;
        public const int CENTIPEDE_BLOCK_IMAGE_HEIGHT = 25;
        public const int CENTIPEDE_BLOCK_SPRITE_WIDTH = 25;
        const int CENTIPEDE_BLOCK_NUMBER_SPRITES = 2;

        const int MAX_ANIMATION_COUNT = 40;

        bool movingRight = true;            // Checks if block is moving right (true) or left (false)
        bool movingDown = true;             // Checks if block is moving down (true) or uo (false)
        int countVertical = 0;              // Checks how many steps (pixels) is the block moving down when changing row. When it gets to 25, it stops
        int animationCount = 0, currentSprite = 0;

        public CentipedeBlock() : base (CENTIPEDE_BLOCK_IMAGE, CENTIPEDE_BLOCK_IMAGE_WIDTH, CENTIPEDE_BLOCK_IMAGE_HEIGHT)
        {
        }

        public CentipedeBlock(string fileName, short width, short height) : base (fileName, width, height)
        {
        }

        public void Move()
        {
            if (animationCount >= MAX_ANIMATION_COUNT)
            {
                currentSprite = (currentSprite + 1) % CENTIPEDE_BLOCK_NUMBER_SPRITES;
                animationCount = 0;
            }
            else
            {
                animationCount++;
            }

            if (movingRight)
            {
                if (GetX() < Hardware.DEFAULT_WIDTH - CENTIPEDE_BLOCK_SPRITE_WIDTH)
                    MoveTo((short)(GetX() + 1), GetY());
                else if (countVertical < MAX_STEPS_VERTICAL)
                {
                    countVertical++;
                    MoveTo(GetX(), (short)(GetY() + (movingDown ? 1 : -1)));
                }
                else
                {
                    countVertical = 0;
                    movingRight = false;
                }
            }
            else
            {
                if (GetX() > 0)
                    MoveTo((short)(GetX() - 1), GetY());
                else if (countVertical < MAX_STEPS_VERTICAL)
                {
                    countVertical++;
                    MoveTo(GetX(), (short)(GetY() + (movingDown ? 1 : -1)));
                }
                else
                {
                    countVertical = 0;
                    movingRight = true;
                }
            }
            if (GetY() >= Hardware.DEFAULT_HEIGHT - CENTIPEDE_BLOCK_IMAGE_HEIGHT && movingDown)
            {
                movingDown = false;
            }
            if (GetY() <= 0 && !movingDown)
            {
                movingDown = true;
            }
        }

        public void Draw(Hardware hardware)
        {
            hardware.DrawImage(this, (short)(CENTIPEDE_BLOCK_SPRITE_WIDTH * currentSprite), 0, CENTIPEDE_BLOCK_SPRITE_WIDTH, CENTIPEDE_BLOCK_IMAGE_HEIGHT);
        }

        // Changes the direction of th centipede
        public void BounceFromObstacle()
        {
            this.movingRight = !movingRight;
            MoveTo((short)(GetX()), (short) (GetY() + (movingDown ? MAX_STEPS_VERTICAL : -MAX_STEPS_VERTICAL)));
        }

    }
}
