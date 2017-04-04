/*
 * Chris Lund Schober
 * IES San Vicente
 * Programing 2
 */
namespace Centipede
{
    /**
     * This class will store all the information and instructions for the main character
     */
class Obstacle : Image
    { 
        public const string OBSTACLE_IMAGE = "imgs/obstacle.png";
        public const int OBSTACLE_IMAGE_WIDTH = 25;
        public const int OBSTACLE_IMAGE_HEIGHT = 25;

        bool visible = true;

        public Obstacle() : base(OBSTACLE_IMAGE, OBSTACLE_IMAGE_WIDTH, OBSTACLE_IMAGE_HEIGHT)
        {
        }

        public bool IsVisible()
        {
            return visible;
        }

        public void SetVisible(bool visible)
        {
            this.visible = visible;
        }
    }
}
