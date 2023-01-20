using FluentAssertions;
using Richards_DiamondKata_ForNewDay.DTOs;
using Richards_DiamondKata_ForNewDay.ErrorMessages;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondKata.Test
{
    public class LetterTests
    {
        [Theory]
        [InlineData("&")]
        [InlineData("")]
        public void GetDiamond_Negative_ThrowsExceptionIf_SpecialCharacterIsInputted(string letter)
        {           
            var act = () => new Letter(letter);

            act.Should().Throw<InvalidCharacterException>();
        }
        [Theory]
        [InlineData("tooManyCharacters")]
        public void GetDiamond_Negative_ThrowsExceptionIf_TooManyCharactersAreInputted(string letter)
        {
            var act = () => new Letter(letter);

            act.Should().Throw<TooManyCharactersException>();
        }


    }
}
