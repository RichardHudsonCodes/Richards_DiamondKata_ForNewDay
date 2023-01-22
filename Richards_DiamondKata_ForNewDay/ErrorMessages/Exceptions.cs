namespace Richards_DiamondKata_ForNewDay.ErrorMessages
{
    internal class InvalidCharacterException : Exception
    {
        internal InvalidCharacterException(string? letter) : base($"You entered an invalid character: {letter}, please enter a letter between A and Z")
        {            
        }       
    }

    internal class TooManyCharactersException : Exception
    {
        internal TooManyCharactersException() : base("Too many characters entered. Please enter only 1 character before pressing ENTER")
        {
        }
    }

    internal class DiamondDimensionsException : Exception
    {
        internal DiamondDimensionsException() : base("Cannont generate a diamond from a list/array with a count of less than 1")
        {
        }
    }
}
