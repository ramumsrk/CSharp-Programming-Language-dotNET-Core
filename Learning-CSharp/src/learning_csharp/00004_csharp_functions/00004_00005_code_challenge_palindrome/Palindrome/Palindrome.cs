using System.Text;

namespace Palindrome
{
  class Palindrome
  {
    static void Main()
    {
      Palindrome palindrome = new Palindrome();
      foreach (string aSampleInputString in new string[]
                 { "Hello World!", "Race car!", "Rotor", "More cowbell!", "Madam, I'm Adam." })
      {
        System.Console.WriteLine("{0}Is '{1}' a palindrome? '{2}'",System.Environment.NewLine,aSampleInputString,Palindrome.IsPalindrome(aSampleInputString));
      }
      return;
    }
    /// <summary>
    /// Check if a sample input-string is palindrome or not
    /// Ignore punctuation characters like '!', ' ', '.', ',', and '\''
    /// Example of palindrome strings are:
    /// Race car!
    /// Rotor
    /// </summary>
    /// <param name="sampleInputString">Input string literal</param>
    /// <returns>Either true or false indicating if the <param name="sampleInputString">sampleInputString</param>is a palidrome or not</returns>
    static bool IsPalindrome(string sampleInputString)
    { 
        bool isPalindrome = false;
        // Convert all characters in sampleInputString to lower-case 
        string? lowerCasedSampleInputString = sampleInputString.ToLower();
        // Buffer to hold sampleInputString after removing all punctuations
        System.Text.StringBuilder replacedSampleInputString = new StringBuilder();
        foreach (char character in lowerCasedSampleInputString)
        {
          // Only append characters that are NOT punctuations and whitespace
          // to the buffer
          if (!System.Char.IsPunctuation(character) && !System.Char.IsWhiteSpace(character))
          {
            replacedSampleInputString.Append(character);
          }
        }
        for (int beginIndex = 0, endIndex = replacedSampleInputString.Length - 1;
             beginIndex <= endIndex;
             beginIndex += 1, endIndex -= 1)
        {
          if (replacedSampleInputString[beginIndex] == replacedSampleInputString[endIndex])
          {
            isPalindrome = true;
          }
          else
          {
            isPalindrome = false;
            break;
          }
        }
        return isPalindrome;
    }
  }
}