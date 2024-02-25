using DesignPatterns;

Console.WriteLine("Домашнее задание по теме 'Паттерны проектирования', паттер 'Прототип':");
Console.WriteLine("(Подробности в тестах)");
Console.WriteLine("---------------------------");

Console.WriteLine("Инициализированы классы Human-> Person-> Employee:");

var human = new Human(36,177,80);
var person = new Person("Azamat", 36, 177, 80);
var employe = new Employee("developer", "Azamat", 36, 177, 80);

var cloneHuman = human.mClone();
var cloneHuman2 = human.Clone();
var clonePerson = person.mClone();
var clonePerson2 = person.Clone();
var cloneEmploye = employe.mClone();
var cloneEmploye2 = employe.Clone();

Console.WriteLine($"human == cloneHuman: {Helper.isEquals(human,cloneHuman)}");
Console.WriteLine($"human == cloneHuman2: {Helper.isEquals(human, cloneHuman2)}");
Console.WriteLine($"person == clonePerson: {Helper.isEquals(person, clonePerson)}");
Console.WriteLine($"person == clonePerson2: {Helper.isEquals(person, clonePerson2)}");
Console.WriteLine($"employe == clonePerson: {Helper.isEquals(employe, cloneEmploye)}");
Console.WriteLine($"employe == clonePerson2: {Helper.isEquals(employe, cloneEmploye2)}");

Console.ReadLine();