// See https://aka.ms/new-console-template for more information
using OOP;

Console.WriteLine("----------OOP---------------");
Person p = new Person("John", 30, "123-45-6789");
//Console.WriteLine(p.GetData());
//p.show();
//Console.WriteLine(Person.DispDate());  //calling static method without an object
//Console.WriteLine(p.GetData(true)); //calling overloaded method

//await Person.Task2(); //calling asynchronus method 

int num = 10;
Person.Add(ref num); //passed by reference
//Console.WriteLine(num);
Person.calc(num,out int result);
//Console.WriteLine(result);

Person CopyPerson = new Person(p);
Console.WriteLine(CopyPerson.GetData());

//struct example
var white = new MyStruct("White", 255);

Console.WriteLine(Person.season.winter);
Console.WriteLine((int)Person.season.winter);

foreach (var day in Enum.GetValues(typeof(Person.Day)))
{
    Console.WriteLine($"{day} = {(int)day}");
}

Console.WriteLine("----------Inheritance & Polymorphism---------------");

//inheritance
var Emp = new Employee("Alice", "987-65-4321", 5000);
var Emp2 = new Employee("Bob", "654-32-1987", 6000,new Addresses("","","",""));
var programmer = new Programmers("Charlie", "321-54-9876", 7000, 2000);

var abstractObj = new DerivedAbstract();
abstractObj.AbstractMethod();