using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Lab3
{
    /// <summary>
    /// Класс для тестирования библиотеки классов Model
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Параметры</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в вычислятор объемов странных фигур!\n" +
                "Нажмите любую кнопку, чтобы начать...");
            Console.ReadKey();

            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Вычисление объёма египетской силы");
                Console.WriteLine("2 - Вычисление объёма ящика пива");
                Console.WriteLine("3 - Вычисление объёма дискошара");
                Console.WriteLine("4 - Выход из программы");
                var consoleKey = Console.ReadLine();
                switch (consoleKey)
                {
                    case "1":
                        {
                            GetVolumeInfo(AddConsoleFigure.
                                GetNewEgyptianForceFromKeyboard());
                            break;
                        }
                    case "2":
                        {
                            GetVolumeInfo(AddConsoleFigure.
                                GetNewBoxOfBeerFromKeyboard());
                            break;
                        }
                    case "3":
                        {
                            GetVolumeInfo(AddConsoleFigure.
                                GetNewDiscoBallFromKeyboard());
                            break;
                        }
                    case "4":
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Попробуйте ещё раз.");
                            break;
                        }
                }
            }
        }

        /// <summary>
        /// Вывести ифномарцию о емкости конденсатора на консоль
        /// </summary>
        /// <param name="capacitor">Экземпляр класса Конденсатор</param>
        public static void GetVolumeInfo(FigureBase figure)
        {
            Console.WriteLine($"Объем фигуры равен " +
                $"{figure.CalculateVolume} м^3. \n");
        }
    }
}
