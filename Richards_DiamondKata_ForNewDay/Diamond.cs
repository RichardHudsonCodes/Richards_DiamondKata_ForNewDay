using Richards_DiamondKata_ForNewDay.DTOs;
using Richards_DiamondKata_ForNewDay.ErrorMessages;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DiamondKata.Test")]
namespace Richards_DiamondKata_ForNewDay
{
    internal class Diamond<T> : IDiamond
    {
        private int DiamondLength {get;}
        private int DiamondMidPoint { get; }

        internal T[,] DiamondShape { get; set; }        

        internal Diamond(List<T> array) 
        {
            ValidateInputList(array);
            DiamondLength = array.Count * 2 - 1;
            DiamondMidPoint = array.Count - 1;
            DiamondShape = GenerateDiamond<T>(array);
        }     

        public void PrintDiamond() 
        {
            for (int i = 0; i < DiamondShape.GetLength(0); i++)
            {
                for (int j = 0; j < DiamondShape.GetLength(1); j++)
                {
                    Console.Write(DiamondShape[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }       

        private T[,] GenerateDiamond<T>(List<T> letters)
        {           
            var diamond = new T[DiamondLength, DiamondLength]; 
            
            for (int i = 0; i < letters.Count; i++) 
            {              
                var valueToPlace = letters[i];

                diamond[i, DiamondMidPoint + i] = valueToPlace;
                diamond[i, DiamondMidPoint - i] = valueToPlace;
                diamond[DiamondLength - i - 1, DiamondMidPoint - i] = valueToPlace;
                diamond[DiamondLength - i -1, DiamondMidPoint + i] = valueToPlace; 
            }
     
            return diamond;         
        }

        private void ValidateInputList(List<T> input) 
        {
            if (input.Count < 1) 
            {
                throw new DiamondDimensionsException();
            }
        }
    }

    internal interface IDiamond 
    {
        void PrintDiamond(); 
    }
}
