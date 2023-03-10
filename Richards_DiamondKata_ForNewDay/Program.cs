// See https://aka.ms/new-console-template for more information
using Richards_DiamondKata_ForNewDay;
using Richards_DiamondKata_ForNewDay.DTOs;

Start:
var initialText = "Input letter then press Enter:";
Console.WriteLine(initialText);

try
{
    var letter = Console.ReadLine();
       
    var letterDto = new Letter(letter);
    var alphabet = new Alphabet();
    var alphabetArray = alphabet.GetPrecedingLettersInAlphabet(letterDto.Character);
    var diamond = new Diamond<char>(alphabetArray);

    diamond.PrintDiamond(); 
}
catch (Exception ex)     
{
    Console.WriteLine(ex.Message + "\n");   
}

goto Start; 
