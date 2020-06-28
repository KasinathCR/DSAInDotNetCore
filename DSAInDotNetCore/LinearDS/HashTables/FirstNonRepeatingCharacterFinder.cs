using System.Linq;

namespace LinearDS.HashTables
{
    public static class FirstNonRepeatingCharacterFinder
    {
        public static char FindFirstNonRepeatingCharacter(string str)
        {
            var count = 1;

            var resultDictionary = str.ToDictionary(item => count++);

            return (from item in str
                let charCount = resultDictionary.Count(x => x.Value == item)
                where charCount == 1
                select item).FirstOrDefault();
        }
    }
}