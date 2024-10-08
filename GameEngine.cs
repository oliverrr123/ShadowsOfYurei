using System;

namespace ShadowsOfYurei
{
    public class GameEngine
    {
        // public string text;
        // public string[] options;
        // public string key;

        // public GameEngine(string text, string[] options, string key)
        // {
        //     this.text = text;
        //     this.options = options;
        //     this.key = key;
        // }

        public static int Print(string text, string[] options)
        {
            int currentOption = 0;
            string key = "";

            while (key != "Enter")
            {
                Console.Clear();
                Console.WriteLine();
//                 Console.WriteLine(@"
// ╔═══                                                                                                                ═══╗
// ║                                                                                                 HP   ❤️ ❤️ ❤️ ❤️ ❤️       ║








// ║                                                                                                                      ║
// ╚═══                                                                                                                ═══╝
//                 ");
                Console.WriteLine($"{text}");
                Console.WriteLine();
                for (int i = 0; i < options.Length; i++)
                {
                    if (i == currentOption)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write($"{i + 1}. {options[i]}");
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"{i + 1}. {options[i]}");
                    }
                }

                key = Console.ReadKey().Key.ToString();
                
                if (key == "DownArrow" && currentOption < options.Length - 1)
                {
                    currentOption++;
                }
                else if (key == "UpArrow" && currentOption > 0)
                {
                    currentOption--;
                }
            }
            return currentOption;
        }
    }
}