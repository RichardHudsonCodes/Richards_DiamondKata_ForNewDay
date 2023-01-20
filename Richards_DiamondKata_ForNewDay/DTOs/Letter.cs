using Richards_DiamondKata_ForNewDay.ErrorMessages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Richards_DiamondKata_ForNewDay.DTOs
{
    public class Letter
    {
        public Letter(string letter) 
        {
            ConstructDto(letter);
        }
        public char Character { get; set; }

        private void ConstructDto(string letter) 
        {
            if (string.IsNullOrEmpty(letter) ||!Regex.IsMatch(letter.ToString(), "[a-zA-Z]")) 
            {
                throw new InvalidCharacterException(letter); 
            }

            if (letter.Count() > 1) 
            {
                throw new TooManyCharactersException();
            }           

            Character = letter.ToUpper().ToCharArray().First();            
        }
    }
}
