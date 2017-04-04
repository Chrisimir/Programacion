/*
 * Chris Lund Schober
 * IES San Vicente
 * Programing 2
 */
namespace Centipede
{
    /**
     * This class shows the credits screen
     */
class CreditsScreen : Screen
    {
        const string CREDITS_IMAGE = "imgs/credits.png";
        const int CREDITS_IMAGE_WIDTH = 318;
        const int CREDITS_IMAGE_HEIGHT = 192;

        public CreditsScreen(Hardware hardware): base(hardware)
        {
        }

        public override void Show()
        {
            Image imgCredits = new Image(CREDITS_IMAGE, CREDITS_IMAGE_WIDTH, CREDITS_IMAGE_HEIGHT);
            // Place image in the middle of the screen
            imgCredits.MoveTo(Hardware.DEFAULT_WIDTH/2 - CREDITS_IMAGE_WIDTH/2, Hardware.DEFAULT_HEIGHT/2 - CREDITS_IMAGE_HEIGHT/2);
            hardware.DrawImage(imgCredits);
            hardware.UpdateScreen();

            while (hardware.KeyPressed() != Hardware.KEY_SPACE);
        }
    }
}
