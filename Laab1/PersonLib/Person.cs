using System;
using System.Text.RegularExpressions;

namespace PersonLib
{
    /// <summary>
    /// Класс Человек 
    /// Включает в себя поля, свойства и методы класса
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Имя 
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возраст
        /// </summary>
        private int _age;

        /// <summary>
        /// Имя 
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                CheckingNameAndSurname(value);
                _name = ConvertToRightRegister(value);
            }
        }

        /// <summary>
        /// Фамилия 
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            private set
            {
                CheckingNameAndSurname(value);
                _surname = ConvertToRightRegister(value);
            }
        }
        /// <summary>
        /// Максимальный возраст человека
        /// </summary>
        public const int AgeMax = 125;

        /// <summary>
        /// Возраст 
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }
            private set
            {
                //TODO:
                if (value < 0 || value > AgeMax)
                {
                    throw new Exception(
                        $"The age must be between 0 and {AgeMax} years!");
                }
                _age = value;
            }
        }

        //TODO: Public set?
        /// <summary>
        /// Пол 
        /// </summary>
        public Sex Sex { get; private set; }

        /// <summary>
        /// Констукрутор класса
        /// </summary>
        /// <param name="name">Имя человека</param>
        /// <param name="surname">Фамилия человека</param>
        /// <param name="age">Возраст человека</param>
        /// <param name="sex">Пол человека</param>
        public Person(string name, string surname, int age, Sex sex)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Sex = sex;
        }

        /// <summary>
        /// Проверка имени и фамилии
        /// </summary>
        /// <param name="value">Имя или фамилия для проверки</param>
        /// <returns>Корректная строка</returns>
        public static string CheckingNameAndSurname(string value)
        {
            if (value == string.Empty)
            {
                throw new Exception(
                    "Expression is null or empty! ");
            }
            else if (!IsNameAndSurnameCorrect(value))
            {
                throw new FormatException("Name or surname must contain " +
                    "only Cyrillic or Latin symbols!");
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// Проверка имени и фамилии на корректность ввода
        /// </summary>
        /// <param name="value">Имя или фамилия для проверки</param>
        /// <returns>Верно/неверно в зависимости от результата
        /// проверки</returns>
        public static bool IsNameAndSurnameCorrect(string value)
        {
            var regex = new Regex("^([A-Za-z]|[А-Яа-я])+(((-| )?([A-Za-z]|" +
                "[А-Яа-я])+))?$");
            
            //TODO: 
            return regex.IsMatch(value);
        }

        /// <summary>
        /// Проверка регистра c учётом двойных имени или фамилии
        /// </summary>
        /// <param name="value">Фамилия или имя для преобразования</param>
        /// <returns>Фамилия или имя с корректным регистром</returns>
        private string ConvertToRightRegister(string value)
        {
            string FirstLetterChangeToUpper(string name)
            {
                return name.Substring(0, 1).ToUpper() +
                    name.Substring(1, name.Length - 1).ToLower();
            }

            var symbols = new[] { "-", " " };
            foreach (var symbol in symbols)
            {
                if (value.Contains(symbol))
                {
                    int indexOfSymbol = value.IndexOf(symbol);
                    return value.Substring(0, 1).ToUpper()
                        + value.Substring(1, indexOfSymbol - 1).ToLower()
                        + symbol
                        + value.Substring(indexOfSymbol + 1, 1).ToUpper()
                        + value.Substring(indexOfSymbol + 2).ToLower();
                }
            }
            return FirstLetterChangeToUpper(value);
        }

        /// <summary>
        /// Булевая проверка возраста на корректность ввода
        /// </summary>
        /// <param name="age">Возраст для проверки</param>
        /// <returns>Верно/неверно в зависимости от результата
        /// проверки</returns>
        public static bool IsAgeCorrect(string age)
        {
            var regex = new Regex("^[0-9]+$");
            //TODO: 
            return regex.IsMatch(age);
        }

        /// <summary>
        /// Проверка для ввода возраста с клавиатуры
        /// </summary>
        /// <param name="number">Возраст для проверки</param>
        /// <returns>Корректный возраст</returns>
        public static int CheckingAgeFromKey(string number)
        {
            if (number == string.Empty)
            {
                throw new Exception(
                    "Expression is null or empty! ");
            }
            //TODO: To global const
            else if (!IsAgeCorrect(number))
            {
                throw new Exception("Age must contain " +
                    $"only integer values in range 0-{AgeMax}!");
            }
            else if (Convert.ToInt32(number) < 0 || Convert.ToInt32(number) > AgeMax)
            {
                throw new Exception("The age must be " +
                    $"between 0 and {AgeMax} years!");
            }
            else
            {
                return Convert.ToInt32(number);
            }
        }

        /// <summary>
        /// Проверка пола при вводе с клавиатуры
        /// </summary>
        /// <param name="sex">Пол человека</param>
        /// <returns>Корректное значение</returns>
        public static bool IsSexCorrect(string sex)
        {
            if (Convert.ToInt32(sex) < 0 || Convert.ToInt32(sex) > 1)
            {
                return false;
            }
            return true;            
        }

        /// <summary>
        /// Проверка для ввода с клавиатуры пола
        /// </summary>
        /// <param name="number">Цифра пола для проверки</param>
        /// <returns>Корректная цифра для определения пола</returns>
        public static int CheckingSexFromKey(string number)
        {
            if (number == string.Empty)
            {
                throw new Exception(
                    "Expression is null or empty!");
            }
            else if (!IsSexCorrect(number))
            {
                throw new Exception("Expression must contain " +
                    "only 0 or 1!");
            }
            else
            {
                return Convert.ToInt32(number);
            }
        }

        //TODO: Rename
        /// <summary>
        /// Вывод информации о человеке
        /// </summary>
        public string Info
        {
            get
            {
                return $"{Name} {Surname}, Age: {Age}, Sex: {Sex}";
            }
        }
    }
}
