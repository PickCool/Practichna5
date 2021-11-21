using System;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.Unicode;

                Console.WriteLine("Cone or Conoid:");
                Console.WriteLine("Press 1 for cone");
                Console.WriteLine("Press 2 for conoid");
                Console.WriteLine();
                Console.Write("Your choice is ");

                int answer = int.Parse(Console.ReadLine());

                Cone cone = null;
                if (answer == 1)
                    cone = new Cone();
                else if (answer == 2)
                    cone = new Conoid();
                else
                    throw new Exception("Error. Unknown choice");

                Console.WriteLine();
                Console.WriteLine("Write parameters of your figure");
                cone.ReadParamsFromConsole();
                Console.WriteLine();
                Console.WriteLine("Your parameters are: ");
                cone.PrintParamsToConsole();
                Console.WriteLine();
                Console.WriteLine($"Figure space: {cone.CalculateVolume()}");
                Console.WriteLine($"The area of the lower base: {cone.CalculateLowerBaseSquare()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
