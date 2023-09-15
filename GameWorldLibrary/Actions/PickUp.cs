using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLibrary
{
    public static class PickUp
    {
        #region Properties
        public static string Name { get; } = "Pick Up";         // Action Name
        public static string[] Keywords { get; } = { "take" };  // Action Keywords
        public static string[] Options { get; } = { };          // Action Choices
        #endregion
        #region Methods
        public static void Do(Player user, string[] input)
        {
            // Check how many tokens a user has inputted
            switch (input.Length)
            {
                // User entered 3 words
                case 3:
                    // No command for 3 words

                // User entered 2 words
                case 2:
                    // No command for 2 words
                    break;

                // User entered 1 word
                default:
                    // No command for 1 word
                    break;
            }
        }
        #endregion
    }
}
