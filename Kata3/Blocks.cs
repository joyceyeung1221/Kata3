using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata3
{
    public class Blocks
    {
        static readonly string blockLetters = "BOXKDQCPNAGTRETGQDFSJWHUVIANOBERFSLYPCZM";
        private static List<Block> matchedBlocks = new List<Block>();
        private static List<Block> blockContainer;

        public static bool CanMakeWord(string input)
        {
            blockContainer = Generate();

            for (int i = 0; i <= input.Length; i++)
            {
                matchedBlocks.Clear();
                foreach (Block block in blockContainer)
                {
                    if (block.FirstChar == input[i] || block.SecondChar == input[i])
                    {
                        matchedBlocks.Add(block);
                    }
                }
                if (matchedBlocks.Count == 0) return false;
                if ((i + 1) == input.Length) return true;
                Block chosenBlock = matchedBlocks.Count > 1 ? chooseBetweenBlocks(i,input) : matchedBlocks.First();
                blockContainer.Remove(chosenBlock);
            }
            return true;
        }

        private static List<Block> Generate()
        {
            var _blockContainer = new List<Block>();
            for (int i = 0; i < blockLetters.Length; i += 2)
            {
                Block block = new Block(blockLetters[i], blockLetters[i + 1]);
                _blockContainer.Add(block);
            }
            return _blockContainer;
        }

        private static Block chooseBetweenBlocks(int i, string input)
        {
            foreach (Block block in matchedBlocks)
            {
                string remaininginput = input.Substring(i + 1);
                if (!(remaininginput.Contains(block.FirstChar) && remaininginput.Contains(block.SecondChar))) return block;
            }
            return matchedBlocks.First();
        }
    }
}
