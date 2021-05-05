using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Figures
{
    /// <summary>
    /// Класс Египетская пирамида
    /// </summary>
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
                CheckingNumber(value);
                _height = value;
            }
        }

        /// <summary>
        /// Вычисление египетской силы
        /// </summary>
        /// <retutns>Объём пирамиды</retutns>

        public override double Volume
        {
            get 
            {
                return Math.Round(BaseArea * Height * 1 / 3, 2);
            }
        }
    }
}
