﻿using System;
using PersonLib;

namespace Laab1
{
    /// <summary>
    /// Основной класс  
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Параметры</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start...");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("Step 1. Two lists of persons are creating, " +
                "each contains three persons...");
            Console.WriteLine();
            Console.ReadKey();

            var listOne = new PersonList();
            var listTwo = new PersonList();

            var arrayOne = new Person[]
            {
                new Person("Bender", "Rodriguez", 40, Sex.Male),
                new Person("Philip junior", "Fry", 28, Sex.Male),
                new Person("Sean", "Diaz", 10, Sex.Female),
            };

            var arrayTwo = new Person[]
            {
                new Person("Eric", "Cartman", 12, Sex.Male),
                new Person("albus-severus", "Potter", 11, Sex.Male),
                new Person("Bojack", "Horseman", 50, Sex.Male),
            };

            listOne.AddArrayOfPeople(arrayOne);
            listTwo.AddArrayOfPeople(arrayTwo);

            Console.WriteLine("Two lists of persons have been sucсessfully created!");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Step 2. Displaying the contents of " +
                "each list to the console...");
            ShowListOfPersons(listOne, listTwo);
            Console.WriteLine();

            Console.WriteLine("Step 3. Adding a new person to the first list... ");
            listOne.AddPerson(new Person("Doctor", "Zoidberg", 98, Sex.Male));
            ShowListOfPersons(listOne, listTwo);
            Console.WriteLine();
            Console.WriteLine("A new person has been successfully added" +
                " to the first list!");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Step 4. Copying the second person from the first" +
                " list to the end of the second list... ");
            listTwo.AddPerson(listOne.FindByIndex(1));
            ShowListOfPersons(listOne, listTwo);
            Console.WriteLine();
            Console.WriteLine("Now the same person is on both lists!");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Step 5. Removing the second person from the first list...");
            listOne.DeleteByIndex(1);
            ShowListOfPersons(listOne, listTwo);
            Console.WriteLine();
            Console.WriteLine("Removing a person from the 1st list did not " +
                "delete the same person in the 2nd list!");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Step 6. Clearing the second list...");
            listTwo.DeleteAllPeople();
            ShowListOfPersons(listOne, listTwo);
            Console.WriteLine("All persons have been successfully removed from the 2nd list!");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Step 7. Let's add a new person " +
                "to the second list from keyboard...");
            Console.WriteLine();
            listTwo.AddPerson(AddConsolePerson.NewPerson());
            ShowListOfPersons(listOne, listTwo);
            Console.WriteLine();

            Console.WriteLine("Step 8. Add a random person " +
                "to the second list...");
            Person randPerson = RandomPerson.GetRandomPerson();
            listTwo.AddPerson(randPerson);
            ShowListOfPersons(listOne, listTwo);
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Вывод списка персон
        /// </summary>
        /// <param name="listOne">Список один</param>
        /// <param name="listTwo">Список два</param>
        public static void ShowListOfPersons(PersonList listOne, PersonList listTwo)
        {
            var personLists = new PersonList[]
            {
                listOne,
                listTwo
            };
            Console.ReadKey();
            for (int i = 0; i < personLists.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"List {i + 1}");
                Console.WriteLine();

                for (int j = 0; j < personLists[i].NumberOfPersons; j++)
                {
                    Console.WriteLine(personLists[i].FindByIndex(j).Info);
                }
            }
            Console.ReadKey();
        }
    }
}
