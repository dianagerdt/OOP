using System;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using Model.Figures;

namespace Model
{
    /// <summary>
    /// Базовый класс 
    /// для всех объёмных фигур
    /// </summary>
    [Serializable]
    [XmlInclude(typeof(BoxOfBeer))]
    [XmlInclude(typeof(EgyptianForce))]
    [XmlInclude(typeof(DiscoBall))]

    public abstract class FigureBase
    {
        /// <summary>
        /// Тип фигуры
        /// </summary>
        public abstract string FigureType { get; }

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
            else if (double.IsNaN(number))
            {
                throw new Exception("Нечисловое значение!");
            }
            else
            {
                return number;
            }
        }
    }
}
