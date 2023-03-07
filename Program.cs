using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandSetName = "1";
            const string CommandChangeConsoleColor = "2";
            const string CommandSetPassword = "3";
            const string CommandWriteName = "4";
            const string CommandEsc = "5";
            const string CommandDateBirth = "6";
            const string CommandEnterNumber = "7";
            const string CommandEnterAmountMoney = "8";
            const string CommandShowAmountMoneySafe = "9";

            int consoleColor;
            string password;
            string setName = "";
            string setPassword = "";
            string writeName;
            bool canExamination = true;
            string dateBirth;
            int enterNumber;
            string enterAmountMoney = "";
            int showAmountMoneySafe;
            string userInput;
            string esc = "выход из программы";

            while (canExamination)
            {
                Console.WriteLine(CommandSetName + " - установить имя ");
                Console.WriteLine(CommandChangeConsoleColor + " - изменить цвет консоли ");
                Console.WriteLine(CommandSetPassword + " - установить пароль ");
                Console.WriteLine(CommandWriteName + " - вывести имя, после ввода пароля ");
                Console.WriteLine(CommandEsc + " - выход из программы ");
                Console.WriteLine(CommandDateBirth + " - установите дату рождения ");
                Console.WriteLine(CommandEnterNumber + " - введите число ");
                Console.WriteLine(CommandEnterAmountMoney + " - введите количество денег ");
                Console.WriteLine(CommandShowAmountMoneySafe + " - показать количество денег в сейфе ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandEsc:
                        Console.WriteLine(" Введите exit ");
                        userInput= Console.ReadLine();
                        canExamination = false;
                        break;

                    case CommandSetName:
                        Console.WriteLine(" Введите ваше имя ");
                        setName = Console.ReadLine();
                        break;

                    case CommandSetPassword:
                        Console.WriteLine(" Введите любой пароль ");
                        setPassword = Console.ReadLine();
                        break;

                    case CommandWriteName:
                        Console.Write(" Введите пароль ");
                        password = Console.ReadLine();

                        if (setPassword == password)
                        {
                            Console.WriteLine(" Ваше имя - " + setName);
                        }
                        else
                        {
                            Console.WriteLine(" Неверный пароль ");
                        }
                        break;

                    case CommandDateBirth:
                        Console.WriteLine(" Введите дату рождения ");
                        dateBirth= Console.ReadLine();
                        break;
                   
                    case CommandEnterNumber:
                        Console.WriteLine(" Введите любое число ");
                        enterNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                       
                    case CommandEnterAmountMoney:
                        Console.WriteLine(" Введите любое количество денег ");
                        enterAmountMoney= Console.ReadLine();
                        break;

                    case CommandShowAmountMoneySafe:
                        Console.WriteLine(" У вас денег в сейфе " + enterAmountMoney + " рублей ");
                        break;

                    case CommandChangeConsoleColor:
                        Console.WriteLine(" Выберите цвет консоли от 1 до 15 ");
                        consoleColor = Convert.ToInt32(Console.ReadLine());
                        
                        if (consoleColor > 15 && consoleColor <= 1)
                        {
                            Console.WriteLine(" Такого цвета нету ");
                        }
                        else
                        {
                            Console.ForegroundColor = (ConsoleColor)consoleColor;
                        }
                        break;
                }       
            }
        }
    }
}