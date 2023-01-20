using FluentAssertions;
using Richards_DiamondKata_ForNewDay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondKata.Test
{
    public class AlphabetServiceTest
    {
        private AlphabetService _alphabetService = new AlphabetService();   

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
