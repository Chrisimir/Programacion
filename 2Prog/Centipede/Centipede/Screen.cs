
namespace Centipede
{
    /**
     * This class will be the parent class of every screen of the video game. It will have a Hardware object to deal with the screen and user input (if necessary),
     * and some method(s) to be overriden
     */
    class Screen
    {
        protected Hardware hardware;

        public Screen(Hardware hardware)
        {
            this.hardware = hardware;
        }

        public virtual void Show()
        {
        }
    }
}
