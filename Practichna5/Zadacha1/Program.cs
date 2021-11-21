using System;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.Unicode;

                Console.WriteLine("You can move or rotate your square with" +
                    " pressing right or left arrows on the keyboard");
                Console.WriteLine("Press 1 to move");
                Console.WriteLine("Press 2 to rotate");
                Console.Write("Your choice: ");
                int choice = int.Parse(Console.ReadLine());

                SquareTransform transformer = null;

                if (choice == 1)
                    transformer = new SquareTransform();
                else if (choice == 2)
                    transformer = new SquareRotate();
                else
                    throw new Exception("Неизвестный ответ");

                transformer.ReadSquareParamsFromConsole();

                Console.WriteLine();
                transformer.PrintSquareParamsToConsole();

                while (true)
                {
                    var keyInfo = Console.ReadKey();

                    bool exit = false;

                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            transformer.LeftArrowPress();
                            break;
                        case ConsoleKey.RightArrow:
                            transformer.RightArrowPress();
                            break;
                        case ConsoleKey.Escape:
                            exit = true;
                            break;
                    }

                    if (exit)
                        return;

                    Console.WriteLine();
                    transformer.PrintSquareParamsToConsole();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.ReadLine();
            }
        }

    }
}
