/*
 * Chris Lund Schober
 * IES San Vicente
 * Programing 2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centipede
{
    /**
      * Class with array of all the blocks of the centipede
      */
class FullCentipede
    {
        CentipedeBlock[] blocks;
        int size;

        public FullCentipede(int size)
        {
            this.size = size;
            blocks = new CentipedeBlock[size];
            blocks[0] = new CentipedeHead();
            for (int i = 1; i < size; i++)
                blocks[i] = new CentipedeBlock();

            for (int i = size - 1; i >= 0; i--)
            {
                blocks[i].MoveTo((short)((size - 1 - i) * CentipedeBlock.CENTIPEDE_BLOCK_SPRITE_WIDTH), CentipedeBlock.CENTIPEDE_BLOCK_IMAGE_HEIGHT);
            }
        }

        public void Move()
        {
            for (int i = size - 1; i >= 0; i--)
            {
                blocks[i].Move();
            }
        }

        public void Draw(Hardware hardware)
        {
            hardware.DrawImage(blocks[0]);
            for (int i = 1; i < size; i++)
            {
                blocks[i].Draw(hardware);
            }
        }

        public CentipedeBlock[] GetBlocks()
        {
            return blocks;
        }

        // Method that reduces size of centipede by one
        public void RemoveLastCentipedeBlock()
        {
            this.size--;
        }
        // Method that returns the size value
        public int getSize()
        {
            return this.size;
        }
    }
}
