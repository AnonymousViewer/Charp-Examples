using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1_Cycles
{
    class Program
    {

        public interface IAct
        {
            void Act();
        }


        //abstract class Action : IAct
        //{
        //    public abstract void Act();
        //}


        class ReverseText : IAct {
            
            public void Act()
            {                
                Console.WriteLine("Enter the text to expand ");
                Console.ForegroundColor = ConsoleColor.Gray;
                string temp = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Lenght = {0}", temp.Length);

                int tl = temp.Length;
                int k;
                char[] ctemp = new char[tl];
                ctemp = temp.ToCharArray(0, tl);
                Array.Reverse(ctemp);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Result: \n \n");
                for (k = 0; k < tl; k++)
                {
                    Console.Write(ctemp[k]);                    
                }
                Console.WriteLine(" \n \n \n \a");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Exit11();
            }
        }


        /// <summary>
        /// Точка перезапуска приложения.
        /// </summary>
        static void StartUp()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Cycle tester v0.1 \n");
            Menu();
        }

        public static void Pause()
        {
            Console.Read();
        }

        static void Exit11()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Menu: What do you want to do?");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
                                To enter a new word, press1.
                                To go back, press 2.
                                To go to the main menu, press.
                                To exit the application press 0.");
            JumpExit11();
        }

        static void JumpExit11()
        {

            //try
            //{
                int key = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                if (key <= 4 && key != 0)
                    switch (key)
                    {
                        case 1:
                            ReverseText r = new ReverseText();
                            r.Act();
                            break;
                        case 2:
                            Menu1();
                            break;
                        case 3:
                            StartUp();
                            break;
                        case 0:
                            Pause();
                            break;
                    }
                else
                {
                    Console.WriteLine("\u0007 Shit, there's no such section!"); MenuJump0();
                }
            //}
            //catch (Exception ej1)
            //{
            //    Console.WriteLine("\u0007 error 001 \n enter the numbers from 1 to 3.");
            //    Console.Read();
            //    StartUp();
            //}

        }


        /// <summary>
        /// Метод MenuJump считывает введеное пользователем значение и вызывает цикл Case, 
        /// для определения типа задачи.
        /// Обрабатывает исключения в следствии неверного ввода пользователя.
        /// </summary>
        static void MenuJump0()
        {
            
            //try
            //{
                int key = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                if (key <= 4 && key != 0)
                    switch (key)
                    {
                        case 1:
                            Console.WriteLine("Your mom be going to work with the text...");
                            Menu1();
                            break;
                        case 2:
                            Console.WriteLine("Your mom be going to work with the numbers!");
                            Menu1();
                            break;
                        case 3:
                            Console.WriteLine("Oh @#!k! That was my bad, bro, but there's nothing here yet ");
                            Pause();
                            break;
                        case 4:
                            Menu();
                            break;
                    }
                else {
                    Console.WriteLine("\u0007 Shit, there's no such section!"); MenuJump0();
                     }
            //}
            //catch (Exception mj0)
            //{
            //    Console.WriteLine("\u0007 error 001 \n enter the numbers from 1 to 3.");
            //    Console.Read();
            //    StartUp();
            //}

        }
        static void MenuJump1()
        {

            //try
            //{
                int key = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                if (key <= 4 && key != 0)
                    switch (key)
                    {
                        case 1:
                            Console.WriteLine("Your mom be going to reverse the text... \n");
                            ReverseText r = new ReverseText();
                            r.Act();
                            break;
                        case 2:
                            Console.WriteLine("Your mom be going to work encrypt the numbers!");
                            Menu1();
                            break;
                        case 3:
                            Console.WriteLine("Your mom be going to work decrypt the numbers!");
                            Pause();
                            break;
                        case 4:
                            Menu();
                            break;
                    }
                else { Console.WriteLine("\u0007 Shit, there's no such section!"); MenuJump1(); }
            //}
            //catch (Exception mj1)
            //{
            //    Console.WriteLine("\u0007 error 001 \n enter the numbers from 1 to 3.");
            //    Console.Read();
            //    StartUp();
            //}

        }

        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Menu: What do you want to do?");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"Enter the number:  
                                1 – Work with text  
                                2 – Work with numbers 
                                3 – Other");
            MenuJump0();
        }

        static void Menu1()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nText: What do you want to do? \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"Enter the number:  
                                1 – Reverse text  
                                2 – Encrypt  
                                3 – Decrypt");
            int count = -1;
            if (count > 0)
            {
                Menu1();
            }
            else
            {
                Console.WriteLine("                                Press 4 to back in Menu");
                MenuJump1();
            }
        }


        static void Main(string[] args)
        {
            string tit = "ThyWickedMom";
            Console.Title = tit;            
            StartUp();
        }
    }
}
