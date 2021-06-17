using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Lab3
{
    public class FigureEventArgs : EventArgs
    {
        /// <summary>
        /// Фигура для передачи
        /// </summary>
        public FigureBase SendingFigure { get; }

        /// <summary>
        /// Конструктор для передачи фигуры
        /// </summary>
        /// <param name="sendingFigure">Транспорт</param>
        public FigureEventArgs(FigureBase sendingFigure)
        {
            SendingFigure = sendingFigure;
        }
    }
}
