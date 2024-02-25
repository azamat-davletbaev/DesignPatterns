using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /// <summary>
    /// Класс Сотрудник, наследник персоны
    /// </summary>
    public class Employee : Person
    {
        /// <summary>
        /// Специальность
        /// </summary>
        public string Speciality { get; private set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="speciality">Специальность</param>
        /// <param name="name">Имя</param>
        /// <param name="age">Возраст</param>
        /// <param name="height">Рост</param>
        /// <param name="weight">Вес</param>
        public Employee(string speciality, string name, int age, int height, int weight) : base(name, age, height, weight)
        {
            this.Speciality = speciality;
        }

        /// <summary>
        /// Переопределяем метод клонирования интерфейса IMyCloneable
        /// </summary>
        public override object mClone() => new Employee(Speciality, Name, Age, Height, Weight);
    }
}
