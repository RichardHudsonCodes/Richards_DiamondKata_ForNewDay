using Richards_DiamondKata_ForNewDay.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("DiamondKata.Test")]
namespace Richards_DiamondKata_ForNewDay
{
    internal class DiamondKataService : IDiamondKataService
    {
        private AlphabetService _alphabetService;

        internal DiamondKataService(AlphabetService alphabetService) 
        {
            _alphabetService = alphabetService;
        }

        public char[,] GetDiamond(LetterDTO letterDto) 
        {
            //ensure that special characters cannot be inputed
            //ensure that Chars are converter to uppercase Modelbinding input object perhaps
            var letter = letterDto.Letter;
            var letters = GetListOfPreceedingCharacters(letter);
            var diamondArray = GenerateDiamond(letters);

            return diamondArray; 
        }

        public void PrintDiamond(char[,] diamond) 
        {
            for (int i = 0; i < diamond.GetLength(0); i++)
            {
                for (int j = 0; j < diamond.GetLength(1); j++)
                {
                    Console.Write(diamond[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        private List<char> GetListOfPreceedingCharacters(char letter) 
        {
            return _alphabetService.GetPrecedingLettersInAlphabet(letter); 
        }

        private char[,] GenerateDiamond(List<char> letters)
        {
            var arrayLength = letters.Count*2 - 1;
            var midPoint = letters.Count-1;

            var diamond = new char[arrayLength, arrayLength]; 
            
            for (int i = 0; i < letters.Count; i++) 
            {              
                var letterToPlace = letters[letters.Count - i-1];

                diamond[i, midPoint + i] = letterToPlace;
                diamond[i, midPoint - i] = letterToPlace;
                diamond[arrayLength - i - 1, midPoint - i] = letterToPlace;
                diamond[arrayLength - i -1, midPoint + i] = letterToPlace; 
            }

            return diamond;         
        }
    }

    internal interface IDiamondKataService 
    {
        char[,] GetDiamond(LetterDTO letterDto);
        void PrintDiamond(char[,] diamond); 
    }
}
