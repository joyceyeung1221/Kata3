using System;

namespace Kata3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Please enter a word");
            string input = Console.ReadLine().ToUpper();
            Console.WriteLine(Blocks.CanMakeWord(input));
        }
    }
}

//Something capable of holding two values of the block X
//Create blocks X
//Container to hold all blocks X
//Focus on one char at each time
//Find all blocks contains that one specific char
//Check index number to ensure block has not been used
//Decide which block to be used
//Store which block has been used

