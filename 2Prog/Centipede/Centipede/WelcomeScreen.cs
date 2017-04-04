
namespace Centipede
{
    /**
     * This class will show the welcome screen of the game, and wait for the user to press a given key to go on or exit
     */
    class WelcomeScreen: Screen
    {
        bool exit;

        public WelcomeScreen(Hardware hardware): base(hardware)
        {
            exit = false;
        }

        public override void Show()
        {
            bool escPressed = false, spacePressed = false;
            Font myFont = new Font("Fonts/DAYPBL__.ttf", 20);

            Image imgTitle = new Image("imgs/title.png", 600, 162);
            imgTitle.MoveTo(100, 100);
            hardware.DrawImage(imgTitle);
            hardware.WriteText("PRESS SPACEBAR TO GO ON OR ESCAPE TO EXIT", 110, 400, 255, 255, 0, myFont);
            hardware.UpdateScreen();

            do
            {
                int keyPressed = hardware.KeyPressed();
                if (keyPressed == Hardware.KEY_ESC)
                {
                    escPressed = true;
                    exit = true;
                }
                else if (keyPressed == Hardware.KEY_SPACE)
                {
                    spacePressed = true;
                    exit = false;
                }
            }
            while (!escPressed && !spacePressed);
        }

        public bool GetExit()
        {
            return exit;
        }
    }
}
