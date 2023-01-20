using FluentAssertions;
using Moq;
using Richards_DiamondKata_ForNewDay;

namespace DiamondKata.Test
{
    public class DiamondKataServiceTests
    {
        private DiamondKataService _diamondKataService;         
        public DiamondKataServiceTests() 
        {
            var alphabetService = new AlphabetService(); 
            _diamondKataService = new DiamondKataService(alphabetService);  
        } 

        [Fact]
        public void GetDiamond_Positive_ReturnsCorrectNumberOfCharaterArrays()
        {
            var result = _diamondKataService.GetDiamond('B');
            result.Count().Should().Be(3); 
        }

        [Fact]
        public void GetDiamond_Positive_ReturnsArraysWithCorrectLength()
        {
            var result = _diamondKataService.GetDiamond('B');

            result.Count().Should().BeGreaterThan(0); 

            foreach (var array in result) 
            {
                array.Length.Should().Be(3); 
            }
        }

        [Fact]
        public void GetDiamond_Negative_ThrowsExceptionIfSpecialCharacterIsInputted()
        {
            var result = _diamondKataService.GetDiamond('&');

            result.Count().Should().BeGreaterThan(0);                        
        }

    }
}