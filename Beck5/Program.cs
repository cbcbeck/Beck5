using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beck5
{
    class StringOperations
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string for removal of all '0' characters: "); 
            string phrase = Console.ReadLine(); 
            StringOperations.FindAndRemoveZeroCharacter(phrase); 
            Console.ReadKey();
        }
        
        public static void FindAndRemoveZeroCharacter(string text)
        {
            string result = string.Empty;
            string[] words = text.Split('0');  
            if (words.Length > 1) 
            {
                result = string.Join("", words); 
                Console.WriteLine("The string with all '0' characters removed is: " + result); 
            }
            else 
            {
                Console.WriteLine("This string is okay!"); 
            }
        }
    }
}
