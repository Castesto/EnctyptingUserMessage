using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserMenu menu = new UserMenu();

            for (; ; )
            {
                Console.Clear();
                menu.MenuShow();

                Console.Write("\nВыбор пункта: ");

                try
                {
                    string userInput = Console.ReadLine();

                    if (Int32.TryParse(userInput, out int point))
                    {
                        menu.PerformOperation(point);
                    }
                    else
                    {
                        menu.PerformOperation(userInput);
                    }
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }

                EncryptingMessage encr = new EncryptingMessage();
                Console.ReadKey();
            }
        }
    }
}
