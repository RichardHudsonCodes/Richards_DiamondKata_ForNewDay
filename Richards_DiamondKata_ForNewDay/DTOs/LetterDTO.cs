using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Richards_DiamondKata_ForNewDay.DTOs
{

    public class LetterDTO
    {
        public LetterDTO(char letter) 
        {
            ConstructDto(Letter);
        }
        public char Letter { get; set; }

        private void ConstructDto(char letter) 
        {
            if (letter == default) 
            {
                throw new InvalidDataException("You must enter a Letter between A and Z"); 
            }

            if (!Regex.IsMatch(letter.ToString(), "/^[A-z]+$/")) 
            {
                throw new InvalidDataException("Invalid Character, Please use a character between A and Z");
            }

            Letter = letter;            
        }
    }
}
