/*
 * Chris Lund Schober
 * IES San Vicente
 * Programing 2
 */
using System;
using System.Threading;

namespace Centipede
{
    /**
     * This class is the main game screen
     */
    class GameScreen: Screen
    {
        const string BACKGROUND_SOUND = "resources/background.mid";
        const string FIRE_SOUND = "resources/fire.wav";

        static int points = 0;
        static int timerShot = 0;

        public GameScreen(Hardware hardware): base(hardware)
        {
        }

        public override void Show()
        {
            Character imgCharacter = new Character();
            FullCentipede centipede = new FullCentipede(10);

            Obstacle[] obstacles = CreateObstacles(20);

            Font myFont = new Font(Hardware.GAME_FONT, 20);

            Audio audios = new Audio(44100, 2, 4096);
            audios.AddMusic(BACKGROUND_SOUND);
            audios.AddWAV(FIRE_SOUND);

            imgCharacter.MoveTo(Hardware.DEFAULT_WIDTH/2 - Character.CHARACTER_IMAGE_WIDTH/2, Hardware.DEFAULT_HEIGHT - Character.CHARACTER_IMAGE_HEIGHT*2);

            int key = -1;
            bool gameOver = false;

            audios.PlayMusic(0, -1);

            while (key != Hardware.KEY_ESC && !gameOver)
            {
                // 1. Draw everything

                hardware.ClearScreen();
                DrawPoints();
                hardware.DrawImage(imgCharacter);
                for (int i = 0; i < imgCharacter.GetShot().Count; i++)
                {
                    if (imgCharacter.GetShot()[i].IsVisible())
                        imgCharacter.GetShot()[i].Draw(hardware);
                }

                centipede.Draw(hardware);

                for (int i = 0; i < obstacles.Length; i++)
                {
                    if (obstacles[i].IsVisible())
                        hardware.DrawImage(obstacles[i]);
                }
                hardware.UpdateScreen();

                // 2. Move character from keyboard input

                key = hardware.KeyPressed();
                if (hardware.IsKeyPressed(Hardware.KEY_LEFT) && imgCharacter.GetX() > 0)
                {
                    imgCharacter.MoveTo((short)(imgCharacter.GetX() - 1), imgCharacter.GetY());
                }
                else if (hardware.IsKeyPressed(Hardware.KEY_RIGHT) && imgCharacter.GetX() < Hardware.DEFAULT_WIDTH - Character.CHARACTER_IMAGE_WIDTH)
                {
                    imgCharacter.MoveTo((short)(imgCharacter.GetX() + 1), imgCharacter.GetY());
                }
                else if (hardware.IsKeyPressed(Hardware.KEY_DOWN) && imgCharacter.GetY() < Hardware.DEFAULT_HEIGHT - Character.CHARACTER_IMAGE_HEIGHT)
                {
                    imgCharacter.MoveTo(imgCharacter.GetX(), (short)(imgCharacter.GetY() + 1));
                }
                else if (hardware.IsKeyPressed(Hardware.KEY_UP) && imgCharacter.GetY() > Hardware.DEFAULT_HEIGHT - 4* Character.CHARACTER_IMAGE_HEIGHT)
                {
                    imgCharacter.MoveTo(imgCharacter.GetX(), (short)(imgCharacter.GetY() - 1));
                }

                if (key == Hardware.KEY_SPACE && timerShot == 0)
                {
                    audios.PlayWAV(1, 2, 0);
                    imgCharacter.Fire();
                    timerShot = 100;
                }
                else if (timerShot > 0)
                {
                    timerShot--;
                }

                // 3. Move other elements (automatically)

                centipede.Move();
                for (int i = 0; i < imgCharacter.GetShot().Count; i++)
                {
                    imgCharacter.GetShot()[i].Move();
                }

                // 4. Collision detection and game state

                // Collision fire shot - obstacles
                for (int i = 0; i < obstacles.Length && imgCharacter.GetShot().Count > 0; i++)
                {
                    if (obstacles[i].IsVisible())
                    {
                        for (int j = 0; j < imgCharacter.GetShot().Count; j++)
                        {
                            if (imgCharacter.GetShot()[j].IsVisible() && obstacles[i].CollidesWith(imgCharacter.GetShot()[j], Obstacle.OBSTACLE_IMAGE_WIDTH, Obstacle.OBSTACLE_IMAGE_HEIGHT, Shot.SHOT_SPRITE_WIDTH, Shot.SHOT_IMAGE_HEIGHT))
                            {
                                points += 10;
                                obstacles[i].SetVisible(false);
                                imgCharacter.GetShot()[j].SetVisible(false);
                                imgCharacter.GetShot().RemoveAt(j);
                            }
                        }
                    }
                }

                // Collision centipede - main character
                for (int i = 0; i < centipede.GetBlocks().Length && !gameOver; i++)
                    if (imgCharacter.CollidesWith(centipede.GetBlocks()[i], Character.CHARACTER_IMAGE_WIDTH, Character.CHARACTER_IMAGE_HEIGHT - 10, 
                        CentipedeBlock.CENTIPEDE_BLOCK_SPRITE_WIDTH, CentipedeBlock.CENTIPEDE_BLOCK_IMAGE_HEIGHT - 10))
                    {
                        gameOver = true;
                    }

                // Collision fire shot - centipede
                for (int i = 0; i < centipede.GetBlocks().Length && imgCharacter.GetShot().Count > 0 && !gameOver; i++)
                {
                    for (int j = 0; j < imgCharacter.GetShot().Count; j++)
                    {
                        if (imgCharacter.GetShot()[j].IsVisible() && centipede.GetBlocks()[i].CollidesWith(imgCharacter.GetShot()[j], CentipedeBlock.CENTIPEDE_BLOCK_SPRITE_WIDTH, CentipedeBlock.CENTIPEDE_BLOCK_IMAGE_HEIGHT, Shot.SHOT_SPRITE_WIDTH, Shot.SHOT_IMAGE_HEIGHT))
                        {
                            imgCharacter.GetShot()[j].SetVisible(false);
                            imgCharacter.GetShot().RemoveAt(j);
                            centipede.RemoveLastCentipedeBlock();

                            points += 50;

                            if (centipede.getSize() < 1)
                            {
                                gameOver = true;
                            }
                        }
                    }
                }
                // Collision centipede - shrooms
                for (int i = 0; i < centipede.GetBlocks().Length && !gameOver; i++)
                {
                    for (int j = 0; j < obstacles.Length; j++)
                    {
                        if (obstacles[j].IsVisible())
                        {
                            // I substract 10 from the height so it doesn't proc when the centipede is right above (or beneath) the shroom
                            if (obstacles[j].CollidesWith(centipede.GetBlocks()[i], Obstacle.OBSTACLE_IMAGE_WIDTH, Obstacle.OBSTACLE_IMAGE_HEIGHT - 10, CentipedeBlock.CENTIPEDE_BLOCK_SPRITE_WIDTH, CentipedeBlock.CENTIPEDE_BLOCK_IMAGE_HEIGHT - 10))
                            {
                                centipede.GetBlocks()[i].BounceFromObstacle();
                            }
                        }
                    }
                }

                // Check if centipede head is at end of screen SESSION 6 CONFLICT WITH SESSION 7 "RETURN WHEN BOTTOM IS REACHED"
                /*if (centipede.GetBlocks()[0].GetY() >= Hardware.DEFAULT_HEIGHT - CentipedeBlock.CENTIPEDE_BLOCK_IMAGE_HEIGHT)
                {
                    gameOver = true;
                }*/

                // 5. Pause game
                if (key == Hardware.KEY_P)
                {
                    Font numbers = new Font(Hardware.GAME_FONT, 100);
                    for (int i = 0; i < 5; i++)
                    {
                        hardware.WriteText(i.ToString(), (short)(150 * i), 100, 200, (byte)(40 * i), (byte)(40 * i), numbers);
                        hardware.UpdateScreen();
                        Thread.Sleep(1000);
                    }
                    hardware.WriteText("5", (short)(150 * 5), 100, 200, (byte)(40 * 5), (byte)(40 * 5), numbers);
                    hardware.UpdateScreen();
                    Thread.Sleep(300);
                    hardware.WriteText("START", 200, 200, 200, 0, 200, numbers);
                    hardware.UpdateScreen();
                    Thread.Sleep(400);
                }
            }

            audios.StopMusic();
        }

        private Obstacle[] CreateObstacles(int size)
        {
            Obstacle[] result = new Obstacle[size];
            Random r = new Random();
            int x, y;
            bool repeated;

            for (int i = 0; i < size; i++)
            {
                do
                {
                    repeated = false;
                    x = r.Next(1, (Hardware.DEFAULT_WIDTH - 50) / 25);
                    y = r.Next(2, (Hardware.DEFAULT_HEIGHT - 125) / 25);
                    for (int j = i - 1; j >= 0 && !repeated; j--)
                    {
                        if (Math.Abs(result[j].GetX() / 25 - x) <= 1 && Math.Abs(result[j].GetY() / 25 - y) <= 1)
                            repeated = true;
                    }
                } while (repeated);
                result[i] = new Obstacle();
                result[i].MoveTo((short)(x * 25), (short)(y * 25));
            }

            return result;
        }

        // Draws the score
        public void DrawPoints()
        {
            Font myFont = new Font(Hardware.GAME_FONT, 20);
            hardware.WriteText(points.ToString("000000"), 0, 0, 0, 255, 0, myFont);
        }
    }
}
