
namespace Centipede
{
    /**
     * This class will show the credits screen of the game, and wait for the user to press any key to go back to the welcome screen
     */
    class CreditsScreen: Screen
    {
        public CreditsScreen(Hardware hardware): base(hardware)
        {
        }

        public override void Show()
        {
            Image imgCredits = new Image("imgs/credits.png", 318, 192);
            imgCredits.MoveTo(241, 200);
            hardware.DrawImage(imgCredits);
            hardware.UpdateScreen();

            while (hardware.KeyPressed() != Hardware.KEY_SPACE);
        }
    }
}
