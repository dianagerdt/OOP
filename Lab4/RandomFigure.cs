using System;
using Model;
using Model.Figures;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    /// <summary>
    /// Класс для генерации случайной фигуры
    /// </summary>
    public static class RandomFigure
    {
        /// <summary>
        /// Рандомайзер
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Максимальное значение параметра
        /// </summary>
        private const int MAXVALUE = 10000;

        /// <summary>
        /// Минимальное значение параметра
        /// </summary>
        private const int MINVALUE = 0;
        
        /// <summary>
        /// Значение делителя 
        /// </summary>
        private const double DIVIDER = 10000.0;

        /// <summary>
        /// Сгенерировать случайное число double через int
        /// </summary>
        /// <param name="minValue">Минимальное значение</param>
        /// <param name="maxValue">Максимальное значение</param>
        /// <param name="divider">Делитель</param>
        public static double GetRandomDouble(int minValue, int maxValue,
            double divider)
        {
            var randomValue = Convert.ToDouble(_random.Next(minValue, maxValue));
            return randomValue / divider;
        }

        /// <summary>
        /// Сгенерировать случайную фигуру
        /// </summary>
        /// <returns>Сгенерированный объект класса FigureBase</returns>
        public static FigureBase GetRandomFigure()
        {
            var figureType = _random.Next(0, 3);

            switch (figureType)
            {
                case 0:
                {
                    return GetRandomParallelepiped();
                }
                case 1:
                {
                    return GetRandomPyramid();
                }
                case 2:
                {
                    return GetRandomBall();
                }
                default:
                {
                    throw new ArgumentException("Тип фигуры отсутствует.");
                }
            }
        }

        /// <summary>
        /// Сгенерировать случайный параллелепипед
        /// </summary>
        /// <returns>Случайный параллелепипед</returns>
        public static FigureBase GetRandomParallelepiped()
        {
            var parallelepiped = new BoxOfBeer
            {
                Length = GetRandomDouble(MINVALUE, MAXVALUE, DIVIDER),
                Width = GetRandomDouble(MINVALUE, MAXVALUE, DIVIDER),
                Height = GetRandomDouble(MINVALUE, MAXVALUE, DIVIDER)
            };
            return parallelepiped;
        }

        /// <summary>
        /// Сгенерировать случайную пирамиду
        /// </summary>
        /// <returns>Случайная пирамида</returns>
        public static FigureBase GetRandomPyramid()
        {
            var pyramid = new EgyptianForce
            {
                Length = GetRandomDouble(MINVALUE, MAXVALUE, DIVIDER),
                Width = GetRandomDouble(MINVALUE, MAXVALUE, DIVIDER),
                Height = GetRandomDouble(MINVALUE, MAXVALUE, DIVIDER)
            };
            return pyramid;
        }

        /// <summary>
        /// Сгенерировать случайный шар
        /// </summary>
        /// <returns>Случайный шар</returns>
        public static FigureBase GetRandomBall()
        {
            var ball = new DiscoBall
            {
                Radius = GetRandomDouble(MINVALUE, MAXVALUE, DIVIDER),
            };
            return ball;
        }
    }
}
