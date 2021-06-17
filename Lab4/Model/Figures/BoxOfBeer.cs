using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Figures
{
    [Serializable]
    /// <summary>
    /// Класс Ящик пива 
    /// (то есть параллелепипед)
    /// </summary>
    public class BoxOfBeer : FigureBase
    {
        /// <summary>
        /// Длина
        /// </summary>
        private double _length;

        /// <summary>
        /// Ширина
        /// </summary>
        private double _width;

        /// <summary>
        /// Высота
        /// </summary>
        private double _height;

        /// <summary>
        /// Длина
        /// </summary>
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                CheckingNumber(value);
                _length = value;
            }
        }

        /// <summary>
        /// Ширина
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                CheckingNumber(value);
                _width = value;
            }
        }

        /// <summary>
        /// Высота
        /// </summary>
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                CheckingNumber(value);
                _height = value;
            }
        }

        /// <summary>
        /// Тип фигуры
        /// </summary>
        public override string FigureType => "Параллелепипед";

        /// <summary>
        /// Вычисление объёма ящика пива
        /// </summary>
        /// <retutns>Объём ящика</retutns>
        public override double Volume
        {
            get 
            {
                return Math.Round(Length * Width * Height, 4);
            }
        }
    }
}
