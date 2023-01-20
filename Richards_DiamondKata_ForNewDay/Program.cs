// See https://aka.ms/new-console-template for more information
using Richards_DiamondKata_ForNewDay;
using Richards_DiamondKata_ForNewDay.DTOs;

Start:
Console.WriteLine("Input letter then press Enter:");

Letter letterDto;
try
{
    var letter = Console.ReadLine();
       
    letterDto = new Letter(letter);

    var diamondService = new DiamondKataService();

    var diamond = diamondService.GetDiamond(letterDto);
    diamondService.PrintDiamond(diamond); 
}
catch (Exception ex)     
{
    Console.WriteLine(ex.Message);
    Console.WriteLine();
}

goto Start; 
