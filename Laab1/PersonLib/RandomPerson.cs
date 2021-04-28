using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLib
{
    public class RandomPerson
    {
        /// <summary>
        /// Генерирует случайного человека
        /// </summary>
        /// <returns>Персона со случайными данными</returns>
        public static Person GetRandomPerson()
        {
            string[] _maleNames = new string[]
            {
                "John", "Carl", "Rick", "Mattew",
                "Nicholas", "Robert", "Samuel",
                "Stan", "Kenny", "Severus", "Jake"
            };

            string[] _femaleNames = new string[]
            {
                "Lyla", "Samanta", "Kate", "Kira",
                "Amelia", "Julia", "Anastasia",
                "Sindy", "Luna", "Violet", "Anna"
            };

            string[] _allSurnames = new string[]
            {
                "Potter", "Granger", "Black", "Malfoy",
                "Weasley", "Dursley", "Riddle",
                "Krum", "Snape", "Lovegood", "Lestrange"
            };

            Random random = new Random();
            
            string name;            
            Sex sex = (Sex)random.Next(0, 2);
            switch (sex)
            {
                case Sex.Male:
                    name = _maleNames[random.Next(_maleNames.Length)];
                    break;
                case Sex.Female:
                    name = _femaleNames[random.Next(_femaleNames.Length)];
                    break;
                default:
                    return new Person("Default", "Person", 0, Sex.Male);
            }

            string surname = _allSurnames[random.Next(_allSurnames.Length)];

            int age = random.Next(0, Person.AgeMax);
            return new Person(name, surname, age, sex);
        }

    }
}
