/*
 * Chris Lund Schober
 * IES San Vicente
 * Programing 2
 */
namespace Centipede
{
    /**
      * This changes the first block to be a head
      */
class CentipedeHead : CentipedeBlock
    {
        const string CENTIPEDE_HEAD_IMAGE = "imgs/centipede0.png";
        const int CENTIPEDE_HEAD_IMAGE_WIDTH = 25;
        const int CENTIPEDE_HEAD_IMAGE_HEIGHT = 25;

        public CentipedeHead() : base(CENTIPEDE_HEAD_IMAGE, CENTIPEDE_HEAD_IMAGE_WIDTH, CENTIPEDE_HEAD_IMAGE_HEIGHT)
        {
        }
    }
}
