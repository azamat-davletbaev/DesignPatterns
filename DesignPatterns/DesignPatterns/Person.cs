using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /// <summary>
    /// Класс персона, наследник Human
    /// </summary>
    public class Person : Human
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; private set; }
                       
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="age">Возраст</param>
        /// <param name="height">Рост</param>
        /// <param name="weight">Вес</param>
        public Person(string name, int age, int height, int weight) : base(age, height, weight)
        {
            this.Name = name;
        }

        /// <summary>
        /// Переопределяем метод клонирования интерфейса IMyCloneable
        /// </summary>
        public override object mClone() => new Person(Name, Age, Height, Weight);        
    }
}
