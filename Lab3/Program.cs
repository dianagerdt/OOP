using System;
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
            Console.WriteLine("Добро пожаловать в вычислятор " +
                "объемов странных фигур!\n" +
                "Нажмите любую кнопку, чтобы начать...");
            Console.ReadKey();

            while (true)
            {
                Console.WriteLine("");
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
        /// Вывести информацию в консоль
        /// </summary>
        /// <param name="figure">Экземпляр класса Фигура</param>
        public static void GetVolumeInfo(FigureBase figure)
        {
            Console.WriteLine($"Объем фигуры равен " +
                $"{figure.Volume} м^3. \n");
        }
    }
}
