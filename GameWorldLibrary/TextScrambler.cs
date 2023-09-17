using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public static class TextScrambler
    {
        public static char cipher = '?';       
        
        public static Dictionary<char, char> scrambleCode = new Dictionary<char, char>()
        {
            {'A', cipher}, {'a', cipher}, {'B', cipher}, {'b', cipher},
            {'C', cipher}, {'c', cipher}, {'D', cipher}, {'d', cipher},
            {'E', cipher}, {'e', cipher}, {'F', cipher}, {'f', cipher},
            {'G', cipher}, {'g', cipher}, {'H', cipher}, {'h', cipher},
            {'I', cipher}, {'i', cipher}, {'J', cipher}, {'j', cipher},
            {'K', cipher}, {'k', cipher}, {'L', cipher}, {'l', cipher},
            {'M', cipher}, {'m', cipher}, {'N', cipher}, {'n', cipher},
            {'O', cipher}, {'o', cipher}, {'P', cipher}, {'p', cipher},
            {'Q', cipher}, {'q', cipher}, {'R', cipher}, {'r', cipher},
            {'S', cipher}, {'s', cipher}, {'T', cipher}, {'t', cipher},
            {'U', cipher}, {'u', cipher}, {'V', cipher}, {'v', cipher},
            {'W', cipher}, {'w', cipher}, {'X', cipher}, {'x', cipher},
            {'Y', cipher}, {'y', cipher}, {'Z', cipher}, {'z', cipher}
        };
        public static string ScrambleText(string targetString, double scrambleMagnitude)
        {
            // Scramble Magnitude at 1.0 is "100% scrambled", 0.5 is 50% or every other letter etc.
            string scrambledString = ""; // Initialize variable for new string

            int charCount = targetString.Length;
            double scrambleRate = charCount / (charCount * scrambleMagnitude);
            int scrambleIndex = 0;

            for (int i = 0; i < charCount; i++)
            {
                
                if (targetString[i] != ' ')                
                    scrambleIndex++;
                
                
                if (scrambleCode.ContainsKey(targetString[i]) && scrambleIndex >= Math.Floor(scrambleRate)) // Scramble Character
                {                  
                    scrambledString += scrambleCode[targetString[i]];                    
                    scrambleIndex = 0;
                }
                else // Do not Scramble
                {                    
                    scrambledString += targetString[i];                    
                }                
            }

            return scrambledString;
        }
    }
}
