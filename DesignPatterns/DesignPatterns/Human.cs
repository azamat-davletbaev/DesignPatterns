using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /// <summary>
    /// Базовый класс 'Человек'
    /// </summary>
    public class Human : IMyCloneable<object>, ICloneable
    {
        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; private set; }
        /// <summary>
        /// Рост
        /// </summary>
        public int Height { get; private set; }
        /// <summary>
        /// Вес
        /// </summary>
        public int Weight { get; private set; }
                
        /// <summary>
        /// Конструктор базового класса
        /// </summary>
        /// <param name="age"></param>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        public Human(int age, int height, int weight)
        {
            this.Age = age;
            this.Height = height;
            this.Weight = weight;
        }

        /// <summary>
        /// Метод реализует интерфейс IMyCloneable
        /// </summary>
        /// <returns></returns>
        public virtual object mClone() => new Human(Age, Height,Weight);

        /// <summary>
        /// Метод реализует интерфейс ICloneable
        /// </summary>
        /// <returns></returns>
        public object Clone() => this.MemberwiseClone();
    }
}
