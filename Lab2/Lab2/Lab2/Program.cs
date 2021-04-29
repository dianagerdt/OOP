using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLib;

namespace Lab2
{
    /// <summary>
    /// Основной класс  
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">Параметры</param>
        static void Main(string[] args)
        {
            Console.WindowWidth = 100;

            Console.WriteLine("Press any key to start...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Generation of 7 random people...");
            Console.WriteLine();
            Console.ReadKey();

            var listOfPersons = new PersonList();

            for (int i = 0; i < 7; i++)
            {
                listOfPersons.AddPerson(GetRandomPerson.CreateRandomPerson());
            }

            Console.WriteLine("A list of persons has been sucсessfully created!");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Randomly generated list:\n");

            for (int i = 0; i < listOfPersons.NumberOfPersons; i++)
            {
                Console.ReadKey();
                Console.WriteLine(listOfPersons.FindByIndex(i).Info);
                Console.WriteLine();
            }
            
            Console.ReadKey();
            Console.Write("The forth person in the list is...\n ");

            switch (listOfPersons.FindByIndex(3))
            {
                case Adult adult:
                    {
                        Console.WriteLine(adult.GoToTheTherapist());
                        break;
                    }

                case Child child:
                    {
                        Console.WriteLine(child.GoFilmTiktoks());
                        break;
                    }
            }

            Console.ReadKey();
        }
    }
}
