using System;
using System.Collections.Generic;
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
                    string ageString = Console.ReadLine();
                    if(!Int32.TryParse(ageString, out int age))
                    {
                        throw new ArgumentException("The age must be an " +
                            "integer value!");
                    }
                    newPerson.Age = age;
                }),
                new Action(() =>
                {
                    Console.Write("Sex (0 - Male, 1 - Female): ");
                    int sex = Int32.Parse(Console.ReadLine());
                    Person.CheckingSex(sex);
                    newPerson.Sex = (Sex)Enum.Parse(
                        typeof(Sex), Convert.ToString(sex));
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
