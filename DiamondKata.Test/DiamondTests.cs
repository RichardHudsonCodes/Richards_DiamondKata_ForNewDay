using FluentAssertions;
using Richards_DiamondKata_ForNewDay;
using Richards_DiamondKata_ForNewDay.DTOs;
using Richards_DiamondKata_ForNewDay.ErrorMessages;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DiamondKata.Test
{
    public class DiamondTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(11)]
        public void DiamondShape_Positive_ReturnsArraysWithCorrectLengthAndWidthAndPositions(int arrayLength)
        {
            var list = Enumerable.Range(0, arrayLength).ToList();
            var length = 2 * arrayLength - 1;
            var midPoint = arrayLength - 1;

            var result = new Diamond<int>(list); 

            result.DiamondShape.GetLength(0).Should().Be(length);
            result.DiamondShape.GetLength(1).Should().Be(length);

            for (int i = 0; i < arrayLength; i++)
            {
                result.DiamondShape[i, midPoint + i].Should().Be(list[i]);
                result.DiamondShape[i, midPoint - i].Should().Be(list[i]);
                result.DiamondShape[length - i - 1, midPoint + i].Should().Be(list[i]);
                result.DiamondShape[length - i - 1, midPoint - i].Should().Be(list[i]);
            }
        }

        [Fact]
        public void DiamondShape_Negatove_ThrowsDiamondDimensionExceptionWhen_InputIsLessThanOne()
        {
            var result = () => new Diamond<int>(new List<int>());

            result.Should().Throw<DiamondDimensionsException>(); 
        }
    }
}