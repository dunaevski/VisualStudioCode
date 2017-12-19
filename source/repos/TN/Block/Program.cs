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
            if (length == objBlock.length && width == objBlock.width && height == objBlock.height)
                return true;
            return false;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
