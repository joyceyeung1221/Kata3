using System;
namespace Kata3
{
    public class Block
    {
        public char FirstChar { get; private set; }
        public char SecondChar { get; private set; }

        public Block(char a,char b)
        {
            FirstChar = a;
            SecondChar = b;

        }
    }
}
