
namespace Centipede
{
    /**
     * This class will manage the screen flow during the game
     */
    class GameController
    {
        public void Start()
        {
            Hardware hardware = new Hardware(800, 600, 24, false);

            WelcomeScreen welcome = new WelcomeScreen(hardware);
            CreditsScreen credits = new CreditsScreen(hardware);
            GameScreen game = new GameScreen(hardware);
            Audio audios = new Audio(44100, 1, 4096);
            audios.AddMusic("Sounds/background.mid");
            audios.PlayMusic(0, -1);
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
            audios.StopMusic();
        }
    }
}
