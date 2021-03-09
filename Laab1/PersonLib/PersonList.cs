using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLib
{
    /// <summary>
    /// Класс Список персон
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Список людей
        /// </summary>
        private Person[] _personArray = new Person[0];

        /// <summary>
        /// Добавление персоны в список
        /// </summary>
        /// <param name="person">Экземпляр класса персона</param>
        public void AddPerson(Person person)
        {
            var temporaryArray = _personArray;

            _personArray = new Person[temporaryArray.Length + 1];

            for (int i = 0; i < temporaryArray.Length; i++)
            {
                _personArray[i] = temporaryArray[i];
            }

            _personArray[temporaryArray.Length] = person;
        }

        /// <summary>
        /// Очистить список 
        /// </summary>
        public void DeleteAllPeople()
        {
            Array.Resize(ref _personArray, 0);
        }

        /// <summary>
        /// Удаление персоны из списка
        /// </summary>
        /// <param name="person">Экземпляр класса Персона</param>
        public void DeletePersonByIndex(Person person)
        {
            DeleteByIndex(GetIndexOfPerson(person));
        }

        /// <summary>
        /// Удаление персоны по ее индексу
        /// </summary>
        /// <param name="index">Индекс экземпляра класса 
        /// Человек</param>
        public void DeleteByIndex(int index)
        {
            if (index < 0 || index > _personArray.Length - 1)
            {
                throw new Exception("You entered " +
                    "an invalid index!");
            }
            var temporaryArray = _personArray;
            var temporaryIndex = 0;
            _personArray = new Person[temporaryArray.Length - 1];

            for (int i = 0; i < temporaryArray.Length; i++)
            {
                if (i != index)
                {
                    _personArray[temporaryIndex] = temporaryArray[i];
                    temporaryIndex++;
                }
            }
        }

        /// <summary>
        /// Возвращает индекс элемента при наличии его в списке
        /// </summary>
        /// <param name="person">Экземпляр класса Персона</param>
        /// <returns>Индекс экземпляра класса</returns>
        public int GetIndexOfPerson(Person person)
        {
            for (int index = 0; index < _personArray.Length; index++)
            {
                if (_personArray[index] == person)
                {
                    return index;
                }
            }

            throw new Exception("The person you specified does not exist " +
                "in this list!");
        }

        /// <summary>
        /// Удаление персоны из списка по имени и фамилии
        /// </summary>
        /// <param name="person">Экземпляр класса Персона</param>
        public void DeletePersonByName(string name, string surname)
        {
            Person[] truePersons = new Person[0];
            for (int i = 0; i < _personArray.Length; i++)
            {
                if ((_personArray[i].Name != name) && (_personArray[i].Surname != surname))
                {
                    Array.Resize(ref truePersons, truePersons.Length + 1);
                    truePersons[truePersons.Length - 1] = _personArray[i];
                }
            }
            _personArray = truePersons;
        }

        /// <summary>
        /// Количество персон в списке
        /// </summary>
        public int NumberOfPersons
        {
            get
            {
                return _personArray.Length;
            }
        }

        /// <summary>
        /// Добавление нескольких людей
        /// </summary>
        /// <param name="persons">Массив людей</param>
        public void AddArrayOfPeople(Person[] persons)
        {
            foreach (Person person in persons)
            {
                AddPerson(person);
            }
        }

        /// <summary>
        /// Поиск элемента по индексу
        /// </summary>
        /// <param name="index">Индекс человека</param>
        /// <returns>возвращает значение по указанному индексу</returns> 
        public Person FindByIndex(int index)
        {
            if (index >= 0 && index < _personArray.Length)
            {
                return _personArray[index];
            }
            else
            {
                throw new Exception("The index you requested " +
                    "does not exist!");
            }
        }
    }
}
