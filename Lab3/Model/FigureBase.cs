using System;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// Базовый класс 
    /// для всех объёмных фигур
    /// </summary>
    public abstract class FigureBase
    {
        /// <summary>
        /// Расчёт объёма
        /// </summary>
        public abstract double Volume { get; }

        /// <summary>
        /// Проверка числа
        /// </summary>
        /// <param name="number">Число для проверки</param>
        /// <returns>Корректное число</returns>
        public static double CheckingNumber(double number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Величина должна " +
                    "быть положительным числом!");
            }
            else
            {
                return number;
            }
        }

    }
}
