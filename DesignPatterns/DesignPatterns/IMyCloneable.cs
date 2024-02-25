using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    /// <summary>
    /// Интерфейс кастомного клонирования
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IMyCloneable<T> where T : new()
    {
        /// <summary>
        /// Метод клонирования
        /// </summary>
        /// <returns></returns>
        public virtual T mClone() => new T();
    }
}
