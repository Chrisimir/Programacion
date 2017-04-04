/*
 * Chris Lund Schober
 * IES San Vicente
 * Programing 2
 */
using System.Collections.Generic;

namespace Centipede
{
    /**
     * This class will store all the information and instructions for the main character
     */
class Character : Image
    {
        public const string CHARACTER_IMAGE = "imgs/character.png";
        public const int CHARACTER_IMAGE_WIDTH = 25;
        public const int CHARACTER_IMAGE_HEIGHT = 25;

        // Shot list to store all the shots
        List<Shot> shots;

        public Character() : base(CHARACTER_IMAGE, CHARACTER_IMAGE_WIDTH, CHARACTER_IMAGE_HEIGHT)
        {
            shots = new List<Shot>();
        }

        public void Fire()
        {
            shots.Add(new Shot());
            int numShot = shots.Count - 1;
            shots[numShot].SetVisible(true);
            shots[numShot].MoveTo((short)(GetX() + CHARACTER_IMAGE_WIDTH / 2 - Shot.SHOT_IMAGE_WIDTH / 2), (short)(GetY()));
        }

        public List<Shot> GetShot()
        {
            return shots;
        }

    }
}
