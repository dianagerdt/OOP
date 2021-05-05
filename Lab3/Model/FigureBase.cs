using System;
using System.Text.RegularExpressions;

namespace Model
{
    public abstract class FigureBase
    {

        public abstract double CalculateVolume { get; }
        
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
        /// Проверка числа
        /// </summary>
        /// <param name="number">Возраст для проверки</param>
        /// <returns>Корректный возраст</returns>
        public static double CheckingNumber(double number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("The number" +
                    " must be greater than zero!");
            }
            if(!IsNumberCorrect(number))
            {
                throw new ArgumentOutOfRangeException("Oops! Check if" +
                    " the number is entered correctly");
            }
            else
            {
                return number;
            }
        }

        /// <summary>
        /// Проверка имени и фамилии на корректность ввода
        /// </summary>
        /// <param name="value">Имя или фамилия для проверки</param>
        /// <returns>Верно/неверно в зависимости от результата
        /// проверки</returns>
        private static bool IsNumberCorrect(double value)
        {
            var regex = new Regex(@"^-?\d*\.?\d*");

            return regex.IsMatch(Convert.ToString(value));
        }
    }
}
