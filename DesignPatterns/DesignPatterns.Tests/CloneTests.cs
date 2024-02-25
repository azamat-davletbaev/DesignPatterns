using System;
using System.Security.Cryptography;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class CloneTests
    {
        [TestMethod]
        public void HumanCloneTest()
        {
            var human = new Human(36, 177, 80);
            
            var cloneHuman = human.mClone();
            var cloneHuman2 = human.Clone();

            Assert.IsTrue(Helper.isEquals(human, cloneHuman));
            Assert.IsTrue(Helper.isEquals(human, cloneHuman2));
        }

        [TestMethod]
        public void PersonCloneTest()
        {
            var person = new Person("Azamat", 36, 177, 80);

            var clonePerson = person.mClone();
            var clonePerson2 = person.Clone();
                        
            Assert.IsTrue(Helper.isEquals(person, clonePerson));
            Assert.IsTrue(Helper.isEquals(person, clonePerson2));
        }

        [TestMethod]
        public void EmployeCloneTest()
        {
            var employe = new Employee("developer", "Azamat", 36, 177, 80);

            var cloneEmploye = employe.mClone();
            var cloneEmploye2 = employe.Clone();

            Assert.IsTrue(Helper.isEquals(employe, cloneEmploye));
            Assert.IsTrue(Helper.isEquals(employe, cloneEmploye2));
        }
    }
}