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
        /// Возраст с проверкой
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

    }
}
