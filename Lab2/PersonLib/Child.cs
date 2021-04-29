using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLib
{
    /// <summary>
	/// Спиногрыз
	/// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Максимальный возраст ребёнка
        /// по законодательству РФ
        /// </summary>
        public const int MaxChildAge = 17;

        /// <summary>
        /// Проверка возраста ребенка
        /// </summary>
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
                if (!(value > MinAge) && !(value <= MaxChildAge))
                {
                    throw new ArgumentOutOfRangeException(
                        "Sorry, the age must be between 0 and 17 years.");
                }
                _age = value;
            }
        }

        /// <summary>
        /// Мать
        /// </summary>
        public Adult Mother { get; set; }

        /// <summary>
        /// Отец
        /// </summary>
        public Adult Father { get; set; }

        /// <summary>
        /// Название детского сада или школы
        /// </summary>
        public string School { get; set; }

        /// <summary>
        /// Информация о ребёнке
        /// </summary>
        /// <returns>Информация о ребенке</returns>
        public override string Info
        {
            get
            {
                var personInfo = base.Info;
                if (Mother != null)
                {
                    personInfo += $"\nMother:" +
                        $"{Mother.Name} {Mother.Surname} ";
                }
                if (Father != null)
                {
                    personInfo += $"\nFather:" +
                        $" {Father.Name} {Father.Surname} ";
                }
                if (Mother == null && Father == null)
                {
                    personInfo += "\nOrphan";
                }
                if (School != null)
                {
                    personInfo += $"\nSchool: {School}";
                }
                return personInfo;
            }
        }

        /// <summary>
        /// Ребенок-тиктокер
        /// </summary>
        /// <returns>Горе в семье</returns>
        public string GoWatchTiktoks()
        {

            return $"{ShortInfoAboutPerson}, who watched Tiktoks " +
                $"all day and didn't do homework.";
        }
    }
}

