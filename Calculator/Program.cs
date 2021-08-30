using System;
using ClassLibrary;

namespace ConsoleCore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarations
            int intTarget = 0;
            int n = 0;

            Console.WriteLine("Calculateur Eco + made by OwO ton KJ de poche");
            Console.WriteLine("------------------------------------------------- \r");
            Console.WriteLine("\r");

            // Description
            Console.WriteLine("Ceci est un petit calculateur arythmétique à deux valeurs, appuie sur [ENTRÉE] pour commencer desu~ ");
            Console.ReadKey();
            Console.WriteLine("\r");


            // Première valeur (intTarget)
            Console.WriteLine("Choisis ta première valeur onii-chan~ : ");
            intTarget = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\r");

            // Seconde valeur (n)
            Console.WriteLine("Choisis aussi ta seconde valeur bakaa~ : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\r");

            // Choix de la méthode du dll 
            Console.WriteLine("Options disponibles");
            Console.WriteLine("\r");
            Console.WriteLine("\t[1] - Addition");
            Console.WriteLine("\t[2] - Soustraction");
            Console.WriteLine("\t[3] - Multiplication");
            Console.WriteLine("\t[4] - Division");
            Console.WriteLine("\r");
            Console.Write("Qu-Qu-Qu-Que v-v-voulez-vous que je fasse *blushing* (1 à 4) : ");
            Console.WriteLine("\r");


            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("\r");
                    Console.WriteLine("Onii-chan nyaaah~ le résultat est : ");
                    int resultAddition = ClassLib.Addition(intTarget, n);
                    Convert.ToInt32(resultAddition);
                    Console.WriteLine(resultAddition);
                    Console.WriteLine("\r");
                    break;

                case "2":
                    Console.WriteLine("\r");
                    Console.WriteLine("Onii-chan nyaaah~ le résultat est : ");
                    int resultSquare = ClassLib.Square(intTarget, n);
                    Convert.ToInt32(resultSquare);
                    Console.WriteLine(resultSquare);
                    Console.WriteLine("\r");
                    break;

                case "3":
                    Console.WriteLine("\r");
                    Console.WriteLine("Onii-chan nyaaah~ le résultat est : ");
                    int resultMultiplication = ClassLib.Multiplication(intTarget, n);
                    Convert.ToInt32(resultMultiplication);
                    Console.WriteLine(resultMultiplication);
                    Console.WriteLine("\r");
                    break;

                case "4":
                    Console.WriteLine("\r");
                    Console.WriteLine("Onii-chan nyaaah~ le résultat est : ");
                    int resultDivision = ClassLib.Addition(intTarget, n);
                    Convert.ToInt32(resultDivision);
                    Console.WriteLine(resultDivision);
                    Console.WriteLine("\r");
                    break;
            }

            Console.WriteLine(" *breathing heavily* desu~, je veux faire un second round ! ");
            Console.WriteLine("\r");
            Console.WriteLine("\t[1] - Faire plaisir à Onee-sama [Reset]");
            Console.WriteLine("\t[2] - Sayonara [QuitConsole]");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Uh ?  Pas codé ?! Roo~ feignant!");
                    break;

                case "2":
                    Console.WriteLine("D'acc-D'accord onii-chan, la prochaine fois je ferai de mon mieux pour que tu restes! ~");
                    Environment.Exit(0);
                    break;

            }

        }
    }
}
