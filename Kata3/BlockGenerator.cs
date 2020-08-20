using System;
using System.Collections.Generic;

namespace Kata3
{
    public class BlockGenerator
    {
        static readonly string blockLetters = "BOXKDQCPNAGTRETGQDFSJWHUVIANOBERFSLYPCZM";

        public static List<Block> Generate()
        {
            var blockContiner = new List<Block>();
            for (int i = 0; i < blockLetters.Length; i += 2)
            {
                Block block = new Block(blockLetters[i], blockLetters[i + 1]);
                blockContiner.Add(block);
            }
            return blockContiner;
        }
    }
}
