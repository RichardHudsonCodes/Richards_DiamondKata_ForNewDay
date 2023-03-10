using FluentAssertions;
using Richards_DiamondKata_ForNewDay;

namespace DiamondKata.Test
{
    public class AlphabetTests
    {
        private Alphabet _alphabetService = new Alphabet();   

        [Fact]
        public void GetAlphaBet_Positive_ReturnsFullCapitalisedAlphabet() 
        {
            var result = _alphabetService.GetAlphabet();

            result.Count().Should().Be(26);            
        }

        [Fact]
        public void GetDiamond_Positive_ReturnsSequenceOfLettersInOrderThatPreceedInput()
        {
            var result = _alphabetService.GetPrecedingLettersInAlphabet('B');

            result.Count().Should().Be(2);
            result.Should().BeInAscendingOrder();
            result[0].Should().Be('A');
            result[1].Should().Be('B');
        }
    }
}
