﻿using System;
using System.Collections.Generic;
using Model.Figures;

namespace Lab3
{
    /// <summary>
    /// Добавление фигур с консоли
    /// </summary>
    public static class AddConsoleFigure
    {
        /// <summary>
        /// Ввод данных о размерах ящика пива
        /// </summary>
        /// <returns>Экземпляр класса Ящик пива</returns>
        public static BoxOfBeer GetNewBoxOfBeerFromKeyboard()
        {
            var boxOfBeer = new BoxOfBeer();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.WriteLine("Длина ящика, м: ");
                    boxOfBeer.Length =
                        ReadFromConsoleAndParse();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Ширина ящика, м: ");
                    boxOfBeer.Width =
                        ReadFromConsoleAndParse();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Высота ящика, м: ");
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
        /// <returns>Экземпляр класса Египетская сила</returns>
        public static EgyptianForce GetNewEgyptianForceFromKeyboard()
        {
            var egyptianForce = new EgyptianForce();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.WriteLine("Площадь основания, м: ");
                    egyptianForce.BaseArea =
                        ReadFromConsoleAndParse();
                }),
                new Action(() =>
                {
                    Console.WriteLine("Высота, м: ");
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
        /// <returns>Экземпляр класса Дискошар</returns>
        public static DiscoBall GetNewDiscoBallFromKeyboard()
        {
            var discoball = new DiscoBall();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.WriteLine("Радиус дискошара, м: ");
                    discoball.Radius =
                        ReadFromConsoleAndParse();
                }),
            };
            actions.ForEach(SetValue);
            return discoball;
        }

        /// <summary>
        /// Чтение с консоли и преобразование в double
        /// </summary>
        public static double ReadFromConsoleAndParse()
        {
            return double.Parse(Console.ReadLine().Replace('.', ','));
        }

        // <summary>
        /// Получение пользовательского ввода
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
