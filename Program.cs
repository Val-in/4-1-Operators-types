using System.ComponentModel;
using System.Drawing;


   
    namespace _4._1._Условные_выражения_и_конструкции
    {
        internal class Program
        {
            public static void Main(string[] args)
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
		
		var color = Console.ReadLine();

		if (color == "red")
		{
			Console.BackgroundColor = ConsoleColor.Red;
			Console.ForegroundColor = ConsoleColor.Black;

			Console.WriteLine("Your color is red!");
                Console.ReadKey();
            }

		else if (color == "green")
		{
			Console.BackgroundColor = ConsoleColor.Green;
			Console.ForegroundColor = ConsoleColor.Black;

			Console.WriteLine("Your color is green!");
                Console.ReadKey();
            }

        else
{
    Console.BackgroundColor = ConsoleColor.Cyan;
    Console.ForegroundColor = ConsoleColor.Black;

    Console.WriteLine("Your color is cyan!");
                Console.ReadKey();
            }
        }
        }
}
