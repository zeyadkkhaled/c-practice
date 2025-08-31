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

