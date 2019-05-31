using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_Sequences
{
    class Program
    {
        static void Main()
        {
            // Escape sequences are used to express characters that cannot be express or interpreted literally.
            Console.WriteLine("\n");    // New line
            Console.WriteLine("\\");    // Backslash
            Console.WriteLine("\0");    // Null
            Console.WriteLine("\a");    // Alert
            Console.WriteLine("\b");    // Backspace
            Console.WriteLine("\f");    // Form feed
            Console.WriteLine("\r");    // Carriage return
            Console.WriteLine("\t");    // Horizontal tab
            Console.WriteLine("\v");    // Vertical tab
            // '\u' or '\x' can be used to specify any unicode character via its four digit hexadecimal code
            Console.WriteLine("\u00A9");    // Copyright Symbol
        }
    }
}
