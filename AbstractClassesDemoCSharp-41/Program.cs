
using AbstractClassesDemoCSharp_41;

//Cannot make an instance of an Abstract class (it is a template for other classes to inherit from)
//var dog = new Animal();

var cat = new Cat();

cat.AbstractAnimal();
cat.VirtualAnimal();

var dog = new Dog();

dog.AbstractAnimal();
dog.VirtualAnimal();

Console.WriteLine();

var circle = new Circle(25);

var area = circle.CalculateArea();

Console.WriteLine(Math.Round(area, 2));