/*
 * Chris Lund Schober
 * IES San Vicente
 * Programing 2
 */
namespace Centipede
{
    /**
     * Parent of all screens
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
