/*
 * Chris Lund Schober
 * IES San Vicente
 * Programing 2
 */
namespace Centipede
{
    /**
     * This class will manage the screen flow during the game
     */
class GameController
    {
        public void Start()
        {
            Hardware hardware = new Hardware(Hardware.DEFAULT_WIDTH, Hardware.DEFAULT_HEIGHT, 24, false);

            WelcomeScreen welcome = new WelcomeScreen(hardware);
            CreditsScreen credits = new CreditsScreen(hardware);
            GameScreen game = new GameScreen(hardware);

            do
            {
                hardware.ClearScreen();
                welcome.Show();
                if (!welcome.GetExit())
                {
                    hardware.ClearScreen();
                    game.Show();
                    hardware.ClearScreen();
                    credits.Show();
                }
            } while (!welcome.GetExit());
        }
    }
}
