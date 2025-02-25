using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetPrint
{
    internal class Printer
    {
        public void Print(string message, int delay = 10, int rounds = 10, bool newLine = false, string symbols = "!§$%&/?*+#-><^.:,;°[]{}##++")
        {
            // All symbols that will be used
            Random ran = new Random();

            // Get current console buffer and window sizes
            // Needed to avoid system.OutOfArgumentsException when
            // the string is wider than the consoles width
            int bufferWidth = Console.BufferWidth;
            int windowWidth = Console.WindowWidth;

            // Get current cursor position
            int cursorTop = Console.GetCursorPosition().Top;
            int cursorLeft = 0;

            // Foreach letter in the message
            for (int i = 0; i < message.Length; i++)
            {
                // Check if cursor position is equal to console width
                if (cursorLeft >= windowWidth)
                {
                    // Enter next line
                    Console.WriteLine();

                    // Reset cursor position to zero
                    cursorLeft = 0;

                    // Increment cursor top value (one line down)
                    cursorTop++;
                }

                // go through the rounds to "obfuscate" the letters
                for (int ii = 0; ii < rounds; ii++)
                {
                    // Set desired cursor position
                    Console.SetCursorPosition(cursorLeft, cursorTop);

                    // Get random symbol
                    var random_symbol = symbols[ran.Next(symbols.Length)];
                    Console.Write(random_symbol);

                    // Sleep so the effect can be seen
                    Thread.Sleep(delay);
                }

                // Set desired cursor position
                Console.SetCursorPosition(cursorLeft, cursorTop);

                // Write actual symbol
                Console.Write(message[i]);

                // Increase left padding
                cursorLeft++;
            }

            if (newLine)
            {
                Console.WriteLine();
            }
        }
    }
}
