using BitManipulationProblems.ToggleAllBitsFromMostSignificantBit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitManipulationProblems.Tests.MaskAllBitsFromMostSignificantBit
{
    [TestClass]
    public class MaskAllBitsFromMostSignificantBitV1Tests
    {
        [TestMethod]
        public void Given_NumberAndIndexToMaxFromMSB_When_MaskAllBitsFromMostSignificantBit_Then_ShouldMaskAllBitsFromMSBToIndex()
        {
            //Given
            var number = 108;
            var index = 4;
            var problem = new MaskAllBitsFromMostSignificantBitV1();
            var expectedResult = 12;

            //When
            var actualResult = problem.MaskAllBitsFromMostSignificantBit(number, index);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
