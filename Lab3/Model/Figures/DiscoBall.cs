using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Figures
{
    /// <summary>
    /// Класс Дискошар
    /// </summary>
    public class DiscoBall : FigureBase
    {

        /// <summary>
        /// Радиус дискошара
        /// </summary>
        private double _radiusOfFigure;

        /// <summary>
        /// Радиус дискошара
        /// </summary>
        public double Radius
        {
            get
            {
                return _radiusOfFigure;
            }
            set
            {
                CheckingNumber(value);
                _radiusOfFigure = value;
            }
        }

        /// <summary>
        /// Вычисление объёма шара
        /// </summary>
        /// <retutns>Объём шара</retutns>

        public override double Volume
        {
            get
            {
                return Math.Round((4 / 3) * Math.PI *
                    Math.Pow(Radius, 2), 3);
            }
        }
    }
}
