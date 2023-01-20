// See https://aka.ms/new-console-template for more information
using Richards_DiamondKata_ForNewDay;
using Richards_DiamondKata_ForNewDay.DTOs;

Start:
Console.WriteLine("Input letter then press Enter:");
var letter = Console.ReadLine().ToUpper().ToCharArray();
LetterDTO letterDto;
try
{ 
    letterDto = new LetterDTO(letter[0]);

    var diamondService = new DiamondKataService(new AlphabetService());

    var diamond = diamondService.GetDiamond(letterDto);
    diamondService.PrintDiamond(diamond); 
}
catch (Exception ex)     
{
    Console.WriteLine(ex.Message);  
}

goto Start; 
