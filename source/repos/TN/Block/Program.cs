using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block
{
    class Block
    {
        private int length, width, height;
        private int volume;

        public Block(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
            this.volume = length*width*height;
        }

        public bool SameBlock(Block objBlock)
        {
            return length == objBlock.length && width == objBlock.width && height == objBlock.height;
        }

        public bool SameVolume(Block objBlock)
        {
            return this.volume == objBlock.volume;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Block block = new Block(4, 5, 6);
            Block block1 = new Block(4, 5, 6);
            Block block2 = new Block(10, 2, 6);

            if (block.SameBlock(block1))
            {
                Console.WriteLine("Object is ravnu");
            }
            if (block.SameVolume(block2))
            {
                Console.WriteLine("Volume is ravnu");
            }
            if (!block.SameBlock(block2))
            {
                Console.WriteLine("ne ravnu");
            }
            Console.ReadKey();

        }
    }
}
