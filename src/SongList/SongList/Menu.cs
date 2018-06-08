using System;

namespace SongList
{
    /// <summary>
    /// Represents the application menu
    /// </summary>
    internal class Menu
    {
        static string[] _options = new string[]
        {
            "Add song",
            "View list",
            "Quit"
        };

        /// <summary>
        /// Display the menu options.
        /// </summary>
        static void Display()
        {
            for (int i = 0; i < _options.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {_options[i]}");
            }
        }

        /// <summary>
        /// Displays the application menu and prompts the user for selection.
        /// </summary>
        /// <returns></returns>
        internal static int Prompt()
        {
            bool valid = false;
            int parsedOption = 0;
            string option = string.Empty;

            Display();
            do
            {
                option = CLI.Prompt($"Please select an option (1-{_options.Length}): ");
                bool canParse = int.TryParse(option, out parsedOption);
                valid = canParse && parsedOption > 0 && parsedOption <= 3;

                if (!valid)
                {
                    Console.WriteLine("'" + option + "' is not a valid option. Please provide a number 1-3");
                }

            }
            while (!valid);

            return parsedOption;
        }
    }
}
