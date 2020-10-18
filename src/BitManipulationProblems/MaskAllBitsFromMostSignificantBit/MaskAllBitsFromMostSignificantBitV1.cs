using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulationProblems.ToggleAllBitsFromMostSignificantBit
{
    /// <summary>
    /// https://www.geeksforgeeks.org/bit-tricks-competitive-programming/
    /// </summary>
    public class MaskAllBitsFromMostSignificantBitV1
    {
        public int MaskAllBitsFromMostSignificantBit(int number, int index)
        {
            var mask = (1 << index) - 1;
            return number = number & mask;
        }
    }
}
