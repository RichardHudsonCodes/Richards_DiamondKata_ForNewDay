using FluentAssertions;
using Richards_DiamondKata_ForNewDay;
using Richards_DiamondKata_ForNewDay.DTOs;

namespace DiamondKata.Test
{
    public class DiamondKataServiceTests
    {
        private DiamondKataService _diamondKataService;         
        public DiamondKataServiceTests() 
        {            
            _diamondKataService = new DiamondKataService();  
        } 

        [Fact]
        public void GetDiamond_Positive_ReturnsArraysWithCorrectLengthAndWidth()
        {
            var letter = new Letter("B");
            var result = _diamondKataService.GetDiamond(letter);

            result.GetLength(0).Should().Be(3);
            result.GetLength(1).Should().Be(3);
        }
    }
}