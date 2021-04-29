using System;
using System.Text.RegularExpressions;

namespace PersonLib
{
    /// <summary>
    /// Базовый класс  
    /// </summary>
    public abstract class PersonBase
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
        protected int _age;

        /// <summary>
        /// Имя 
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
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
            set
            {
                CheckingNameAndSurname(value);
                _surname = ConvertToRightRegister(value);
            }
        }

        /// <summary>
        /// Возраст 
        /// </summary>
        public virtual int Age { get; set; }

        /// <summary>
        /// Пол 
        /// </summary>
        public Sex Sex { get; set; }

        /// <summary>
        /// Констукрутор класса
        /// </summary>
        /// <param name="name">Имя человека</param>
        /// <param name="surname">Фамилия человека</param>
        /// <param name="age">Возраст человека</param>
        /// <param name="sex">Пол человека</param>
        public PersonBase(string name, string surname, int age, Sex sex)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Sex = sex;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public PersonBase() : this("Diana", "Negerdt", 100, Sex.Female) { }
        
        /// <summary>
        /// Наименьший допустимый возраст 
        /// </summary>
        public const int MinAge = 0;

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
        private static bool IsNameAndSurnameCorrect(string value)
        {
            var regex = new Regex("^([A-Za-z]|[А-Яа-я])+(((-| )?([A-Za-z]|" +
                "[А-Яа-я])+))?$");

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
        /// Вывод информации о человеке
        /// </summary>
        public virtual string Info
        {
            get
            {
                return $"{Name} {Surname}, Age: {Age}, Sex: {Sex}";
            }
        }

        /// <summary>
        /// Имя и фамилия
        /// </summary>
        /// <returns>Строка с информацией</returns>
        public string ShortInfoAboutPerson
        {
            get
            {
                return $"{Name} {Surname}";
            }
        }
    }
}
