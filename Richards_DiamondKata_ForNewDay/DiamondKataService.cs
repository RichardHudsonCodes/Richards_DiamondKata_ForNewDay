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
        private AlphabetService _alphabetService = new AlphabetService();

        internal DiamondKataService() 
        {            
        }

        public char[,] GetDiamond(Letter letterDto) 
        {
            var letter = letterDto.Character;
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
                var letterToPlace = letters[i];

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
        char[,] GetDiamond(Letter letterDto);
        void PrintDiamond(char[,] diamond); 
    }
}
