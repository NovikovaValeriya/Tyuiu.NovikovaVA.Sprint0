using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Tyuiu.NovikovaVA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.NovikovaVA.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Игорь"));
            Console.ReadKey();
            Console.ReadKey();
        }
    }

}

