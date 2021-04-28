using System;
using System.Text.RegularExpressions;

namespace PersonLib
{
    /// <summary>
    /// Человек, который притворяется
    /// взрослым
    /// </summary>
    public class Adult : PersonBase
    {
        /// <summary>
        /// Минимальный возраст взрослого
        /// </summary>
        public const int MinAge = 18;

        /// <summary>
        /// Максимальный возраст взрослого
        /// </summary>
        public const int MaxAge = 100;

        /// <summary>
        /// Возраст
        /// </summary>
        public override int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (!(MinAge < value) && !(value <= MaxAge))
                {
                    throw new ArgumentOutOfRangeException(
                        "Sorry, the age must be between 18 and 100 years.");
                }
                _age = value;
            }
        }

        /// <summary>
        /// Поле паспортных данных
        /// </summary>
        private string _passport;
        
        /// <summary>
		/// Паспорт
		/// </summary>
		public string Passport
        {
            get => _passport;
            set
            {
                const string pattern = @"\D";
                Regex regex = new Regex(pattern);
                if (value.Length != 10 || regex.IsMatch(value.ToString()) == true)
                {
                    throw new ArgumentException("Passport must contain 10 digits!");
                }
                _passport = value;
            }
        }

        /// <summary>
        /// Свойство Семейное положение
        /// </summary> 
        public MaritalStatus MaritalStatus { get; set; }

        /// <summary>
        /// супруг
        /// </summary>
        private Adult _partner;

        /// <summary>
        /// Супруг(а)
        /// </summary>
        public Adult Partner
        {
            get 
            { 
                return _partner; 
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(
                        $"{nameof(Partner)}", $"{nameof(Partner)} value is" +
                        " null!");
                }
                if (MaritalStatus == MaritalStatus.Married &&
                    value.MaritalStatus == MaritalStatus.Married)
                {
                    _partner = value;
                }
                else
                {
                    throw new ArgumentException(
                        "Something went wrong." +
                        "Please check marital statuses both of partners!");
                }
            }
        }

        /// <summary>
        /// Поле Место работы
        /// </summary>
        private string _job;

        /// <summary>
        /// Информация о месте работы
        /// </summary>
        public string Job { get; set; }

        /// <summary>
		/// Конструктор класса Adult
		/// </summary>
		/// <param name="name">Имя</param>
		/// <param name="surname">Фамилия</param>
		/// <param name="age">Возраст</param>
		/// <param name="sex">Пол</param>
		/// <param name="passport">Паспорт</param>
		/// <param name="partner">Супруг(а)</param>
		/// <param name="job">Место работы</param>
		public Adult(string name, string surname, int age, Sex sex,
            string passport, Adult partner, string job) : base(name, surname, age, sex)
        {
            Passport = passport;
            Partner = partner;
            Job = job;
        }

        /// <summary>
		/// Конструктор по умолчанию
		/// </summary>
		public Adult() : this("Диана", "Гердт", 23, Sex.Female, "2283220000", null, "Безработная") { }

        /// <summary>
        /// Получение информации о взрослом человеке
        /// </summary>
        /// <returns></returns>
        public override string Info
        {
            get
            {
                var personInfo = base.Info + $"\nPassport Data: {Passport}" +
                $"\nMaritial Status: {MaritalStatus}";
                if (MaritalStatus == MaritalStatus.Married)
                {
                    personInfo += $"\nSpouse: {Partner.Name} " +
                        $"{Partner.Surname}";
                }
                personInfo += "\nPlace of work: ";
                if (string.IsNullOrEmpty(Job))
                {
                    personInfo += "Unemployed";
                }
                else
                {
                    personInfo += Job;
                }
                return personInfo;
            }
        }
    }
}
