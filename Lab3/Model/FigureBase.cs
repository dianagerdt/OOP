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
        /// Число
        /// </summary>
        private double _number;

        public double Number
        {
            get
            {
                return _number;
            }
            set
            {
                CheckingNumber(value);
                _number = value;
            }
        }

        /// <summary>
        /// Расчёт объёма
        /// </summary>
        public abstract double CalculateVolume { get; }

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
            if(!IsNumberCorrect(number))
            {
                throw new ArgumentOutOfRangeException("А, ой... Кажется, " +
                    "вы ввели не число.");
            }
            else
            {
                return number;
            }
        }

        /// <summary>
        /// Проверка числа на корректность ввода
        /// </summary>
        /// <param name="value">Число для проверки</param>
        /// <returns>Верно/неверно в зависимости от результата
        /// проверки</returns>
        private static bool IsNumberCorrect(double value)
        {
            var regex = new Regex(@"^-?\d*\.?\d*");

            return regex.IsMatch(Convert.ToString(value));
        }
    }
}
