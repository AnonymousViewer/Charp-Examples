using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1_Cycles
{
    class Program
    {

        public interface IAct {
            void Act();
        }

        abstract class Action : IAct
        {
            public abstract void Act();

        }

        static void StartUp()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Cycle tester v0.1");
            Console.WriteLine();
            Menu();
        }
       public static void Pause() {
            Console.Read();            
        }
     
        
        /// <summary>
        /// Метод MenuJump считывает введеное пользователем значение и вызывает метод Case.
        /// Обрабатывает исключения в следствии неверного ввода пользователя.
        /// </summary>
        static void MenuJump()
        {
            Console.WriteLine("Press 4 to back in Menu");
            try
            {
                int key = Convert.ToInt32(Console.ReadLine());
                if (key >= 4 || key != 0)
                    switch (key)
                    {
                        case 1:
                            Console.WriteLine("Твоя мамка будет работать с текстом!");
                            break;
                        case 2:
                            Console.WriteLine("Твоя мамка будет работать с numbers!");
                            break;
                        case 3:
                            Console.WriteLine("Твоя мамка будет работать с @#!!*/@ ");
                            break;
                        case 4:                            
                            Menu();
                            break;
                    }
                else { Console.WriteLine("Shit, there's no such section!"); MenuJump(); }
            }
            catch (Exception e)
            {
                Console.WriteLine("error 001");
                Console.WriteLine("enter the numbers from 1 to 3.");
                Console.Read();
                StartUp();
            }

        }
        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Menu: What do you want to do?");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Enter the number:");
            Console.WriteLine("1 – Work with text");            
            Console.WriteLine("2 – Work with numbers");
            Console.WriteLine("3 – Other");
            MenuJump();
        }
        static void Main(string[] args)
        {
            string tit = "HomeWork";
            Console.Title = tit;            
            StartUp();
        }
    }
}
