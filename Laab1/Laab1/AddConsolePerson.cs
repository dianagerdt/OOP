using System;
using System.Collections.Generic;
using System.Linq;
using PersonLib;

namespace Laab1
{
    /// <summary>
    /// Класс, предназначенный для
    /// добавленя персоны через консоль
    /// </summary>
    public static class AddConsolePerson
    {
        /// <summary>
        /// Добавление Person через консоль        
        /// </summary>
        /// <returns>Новая персона</returns>
        public static Person NewPerson()
        {
            Person newPerson = new Person("Mrs", "Nobody", 123, Sex.Female);
            List<Action> actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.Write("Name: ");
                    newPerson.Name = Console.ReadLine();
                }),
                new Action(() =>
                {
                    Console.Write("Surname: ");
                    newPerson.Surname = Console.ReadLine();
                }),
                new Action(() =>
                {
                    Console.Write("Age: ");
                    newPerson.Age = int.Parse(Console.ReadLine());
                }),
                new Action(() =>
                {
                    Console.Write("Sex (0 - Male, 1 - Female): ");
                    string sex = Console.ReadLine();
                    Person.CheckingSex(sex);
                    newPerson.Sex = (Sex)Enum.Parse(
                        typeof(Sex), sex);
                }),
            };
            actions.ForEach(SetValue);
            return newPerson;
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
