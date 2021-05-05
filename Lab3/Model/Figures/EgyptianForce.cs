using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Figures
{
    public class EgyptianForce : FigureBase
    {
        /// <summary>
        /// Площадь основания
        /// </summary>
        private double _baseArea;

        /// <summary>
        /// Высота
        /// </summary>
        private double _height;

        /// <summary>
        /// Площадь основания пирамиды
        /// </summary>
        public double BaseArea
        {
            get
            {
                return _baseArea;
            }
            set
            {
                CheckingNumber(value);
                _baseArea = value;
            }
        }

        /// <summary>
        /// Площадь основания пирамиды
        /// </summary>
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                FigureBase.CheckingNumber(value);
                _height = value;
            }
        }

        /// <summary>
        /// Вычисление египетской силы
        /// </summary>
        public override double CalculateVolume
        {
            get 
            {
                return Math.Round((1 / 3) * BaseArea *
                    Height, 3);
            }
        }
    }
}
