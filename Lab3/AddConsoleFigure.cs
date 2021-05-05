using System;
using System.Collections.Generic;
using Model.Figures;

namespace Lab3
{
    public static class AddConsoleFigure
    {
        /// <summary>
        /// Ввод данных о размерах ящика пива
        /// </summary>
        /// <returns>Созданный экземпляр класса Ящик пива</returns>
        public static BoxOfBeer GetNewBoxOfBeerFromKeyboard()
        {
            var boxOfBeer = new BoxOfBeer();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.WriteLine("Длина ящика: ");
                    boxOfBeer.Length =
                        ReadFromConsoleAndParse();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Ширина ящика: ");
                    boxOfBeer.Width =
                        ReadFromConsoleAndParse();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Высота ящика: ");
                    boxOfBeer.Height =
                        ReadFromConsoleAndParse();
                })
            };
            actions.ForEach(SetValue);
            return boxOfBeer;
        }

        /// <summary>
        /// Ввод данных о пирамиде
        /// </summary>
        /// <returns>Созданный экземпляр класса Египетская сила</returns>
        public static EgyptianForce GetNewEgyptianForceFromKeyboard()
        {
            var egyptianForce = new EgyptianForce();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.WriteLine("Длина ящика: ");
                    egyptianForce.BaseArea =
                        ReadFromConsoleAndParse();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Ширина ящика: ");
                    egyptianForce.Height =
                        ReadFromConsoleAndParse();
                }),
            };
            actions.ForEach(SetValue);
            return egyptianForce;
        }

        /// <summary>
        /// Ввод данных о дискошаре
        /// </summary>
        /// <returns>Созданный экземпляр класса Дискошар</returns>
        public static DiscoBall GetNewDiscoBallFromKeyboard()
        {
            var discoball = new DiscoBall();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.WriteLine("Радиус дискошара: ");
                    discoball.Radius =
                        ReadFromConsoleAndParse();
                }),
            };
            actions.ForEach(SetValue);
            return discoball;
        }

        /// <summary>
        /// Получить пользовательский ввод и преобразовать в double
        /// </summary>
        public static double ReadFromConsoleAndParse()
        {
            return double.Parse(Console.ReadLine().Replace('.', ','));
        }

        // <summary>
        /// Получение пользовательский ввода
        /// и задание параметра
        /// </summary>
        public static void SetValue(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"\n{e.Message}\n");
                }
            }
        }


    }
}
