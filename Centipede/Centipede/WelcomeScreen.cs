/*
 * Chris Lund Schober
 * IES San Vicente
 * Programing 2
 */
namespace Centipede
{
    /**
     * This class is the welcome screen
     */
class WelcomeScreen : Screen
    {
        const string WELCOME_IMAGE = "imgs/title.png";
        const int WELCOME_IMAGE_WIDTH = 600;
        const int WELCOME_IMAGE_HEIGHT = 162;

        bool exit;

        public WelcomeScreen(Hardware hardware): base(hardware)
        {
            exit = false;
        }

        public override void Show()
        {
            bool escPressed = false, spacePressed = false;

            Image imgTitle = new Image(WELCOME_IMAGE, WELCOME_IMAGE_WIDTH, WELCOME_IMAGE_HEIGHT);
            Font myFont = new Font(Hardware.GAME_FONT, 20);
            imgTitle.MoveTo(Hardware.DEFAULT_WIDTH/2 - WELCOME_IMAGE_WIDTH/2, Hardware.DEFAULT_HEIGHT/3 - WELCOME_IMAGE_HEIGHT/2);
            hardware.DrawImage(imgTitle);
            hardware.WriteText("Press SpaceBar to go on or Escape to exit", Hardware.DEFAULT_WIDTH / 2 - 250, Hardware.DEFAULT_HEIGHT * 2 / 3, 255, 255, 0, myFont);
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
