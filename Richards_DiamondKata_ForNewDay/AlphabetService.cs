using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richards_DiamondKata_ForNewDay
{
    internal class AlphabetService
    {

        public AlphabetService() { }

        internal List<char> GetAlphabet() 
        {
            return Enumerable.Range('A', 'Z'-'A' + 1).Select(i => (Char)i).ToList(); 
        }

        public List<char> GetPrecedingLettersInAlphabet(char letter) 
        {
            return GetAlphabet().Where(l => l <= letter).ToList();
        }
    }

    internal interface IAlphabetService 
    {        
        List<char> GetPrecedingLettersInAlphabet(char letter); 
    }
}
