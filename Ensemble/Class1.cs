using System.Collections;
using System.Collections.Specialized;

namespace Ensemble;

public class Class1
{
    public static string ToRomanNumerals(int number)
    {
        var result = "";
        var numberToRomanMapping = new Dictionary<int, string>
        {
            [100] = "C",
            [90] = "XC",
            [50] = "L",
            [40] = "XL",
            [10] = "X",
            [9] = "IX",
            [5] = "V",
            [4] = "IV",
            [1] = "I"
        };
        
        foreach (var dictionaryEntry in numberToRomanMapping)
        {
            number = ExtractSequencesForCharacter(number, ref result, dictionaryEntry.Key, dictionaryEntry.Value);
        }
        
        return result;
    }

    private static int ExtractSequencesForCharacter(int number, ref string result, int divisor, string romanCharacter)
    {
        var numberOfTens = number / divisor;
        result += string.Join("",Enumerable.Repeat(romanCharacter, numberOfTens));
        number -= numberOfTens * divisor;
        return number;
    }
}