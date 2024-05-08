using System.ComponentModel;
using System.Drawing;


   
    namespace _4._1._Условные_выражения_и_конструкции
    {
        internal class Program
        {
            public static void Main(string[] args)


        {
                        int k = 0;
            for (; k < 5;) 
            {
                Console.WriteLine(k);
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                var text = Console.ReadLine();
                                              
                switch (text)
                                        
                    {            
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    default:
                      continue;
                }
                if (text == "stop")
                {
                    Console.WriteLine("Цикл остановлен");
                    break;
                }
                k++;
            }
            
        }
        }
    }
    