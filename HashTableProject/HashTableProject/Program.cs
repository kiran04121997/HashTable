using System;
using System.Collections.Generic;
using HashTableProject;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table Program\n");

            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            FrequencyOfWords.GetFrequencyOfWords(paragraph);

            Console.ReadLine();
        }
    }
}
