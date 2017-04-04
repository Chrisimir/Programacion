
using System;

namespace Centipede
{
    /**
     * This class will show the game screen, where we do play Centipede
     */
    class GameScreen: Screen
    {
        public GameScreen(Hardware hardware): base(hardware)
        {
        }

        public static bool IsValidMoveShip(int x, int y)
        {
            if ((x > 0 && x < 775) && (y > 500 && y < 575))
            {
                return true;
            }
            return false;
        }

        public override void Show()
        {
            Image imgCharacter = new Image("imgs/character.png", 25, 25);
            imgCharacter.MoveTo(388, 550);
            int key = -1;

            CentipedeBlock imgCentipede = new CentipedeBlock("imgs/centipede0.png", 25, 25);
            imgCentipede.MoveTo(0, 25);

            bool fireVisible = false;
            Image imgFire = new Image("imgs/fire.png", 10, 36);
            imgFire.MoveTo(0, 0);

            Font myFont = new Font("Fonts/DAYPBL__.ttf", 20);

            Audio audios = new Audio(44100, 1, 4096);
            audios.AddWAV("Sounds/fire.wav");

            while (key != Hardware.KEY_ESC)
            {
                // 1. Draw everything
                hardware.ClearScreen();
                hardware.DrawImage(imgCharacter);
                hardware.DrawImage(imgCentipede);
                hardware.WriteText("000000", 0, 0, 0, 255, 0, myFont);
                if (fireVisible)
                {
                    hardware.DrawImage(imgFire);
                }
                hardware.UpdateScreen();
                
                // 2. Move character from keyboard input
                key = hardware.KeyPressed();
                if (hardware.IsKeyPressed(Hardware.KEY_LEFT) && IsValidMoveShip((short)(imgCharacter.GetX() - 1), imgCharacter.GetY()))
                {
                    imgCharacter.MoveTo((short)(imgCharacter.GetX() - 1), imgCharacter.GetY());
                }
                if (hardware.IsKeyPressed(Hardware.KEY_RIGHT) && IsValidMoveShip((short)(imgCharacter.GetX() + 1), imgCharacter.GetY()))
                {
                    imgCharacter.MoveTo((short)(imgCharacter.GetX() + 1), imgCharacter.GetY());
                }
                if (hardware.IsKeyPressed(Hardware.KEY_UP) && IsValidMoveShip(imgCharacter.GetX(), (short)(imgCharacter.GetY() - 1)))
                {
                    imgCharacter.MoveTo(imgCharacter.GetX(), (short)(imgCharacter.GetY() - 1));
                }
                if (hardware.IsKeyPressed(Hardware.KEY_DOWN) && IsValidMoveShip(imgCharacter.GetX(), (short)(imgCharacter.GetY() + 1)))
                {
                    imgCharacter.MoveTo(imgCharacter.GetX(), (short)(imgCharacter.GetY() + 1));
                }

                if (key == Hardware.KEY_SPACE && !fireVisible)
                {
                    audios.PlayWAV(0, 1, 0);
                    fireVisible = true;
                    imgFire.MoveTo(imgCharacter.GetX(), imgCharacter.GetY());
                }

                // 3. Move other elements (automatically)
                imgCentipede.Move();

                if (fireVisible)
                {
                    imgFire.MoveTo(imgFire.GetX(), (short)(imgFire.GetY() - 1));
                    if (imgFire.GetY() == 0)
                    {
                        fireVisible = false;
                    }
                }
                

                // 4. Collision detection and game state
                // 5. Pause game
            }
        }

    }
}
