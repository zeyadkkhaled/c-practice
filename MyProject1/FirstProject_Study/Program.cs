// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.Write("This is my first project in C#.");
//Console.Write("This is my first project in C#.");

using System.Collections.Generic;

int num = 10;

float num2 = 10.5f; //f: suffix to make it a float not double
string name = "John Doe";
const float PI = 3.14f; // const: constant value that cannot be changed

//for each , only works for arrays and collections
//foreach (singleArrayDatatype variable in ArrayName)
//{
//    code....
//}
//arrays(fixedsize 1D)

//1-1D array
//data type[] name = new data type[size]; or //data type[] name = {value1, value2, ...};
//data type[] name = new data type[] {value1, value2, ...};

string[] names = new string[5]; //fixed size 1D array
int[] ints =  { 1, 2, 3, 4, 4 }; //fixed size 1D array with values
//adding values to the array
names[0] = "Alice";
names[4] = "Bob";
foreach (string Name in names)
{
    //if (Name != null) // Check for null to avoid printing empty slots
    //    Console.WriteLine(Name);
    if (!string.IsNullOrEmpty(Name)) // Check for null or empty string
        Console.WriteLine(Name);
    //we can also use keyword continue 
}
//we can use for loop to iterate through the array 

Console.WriteLine("-----------------------------");


Console.WriteLine(Array.IndexOf(ints,4)); //you give it arrayname and the value you want to find, it returns the first index of the value in the array
Console.WriteLine(Array.LastIndexOf(ints, 4));


//2-Multi-dimensional arrays
// datatype[,] name = new datatype[Rowsize, columnsize];

int[,] matrix = new int[3, 2]
{
   { 1, 2 },
   { 1, 2 },
   { 1, 2 }
};
//we can initialize it like this too
matrix[0, 0] = 10; //changing value at row 0 column 0

//Jagged arrays (array of arrays)
// datatype[][] name = new datatype[rowsize][];
int[][] jaggedarray = new int[3][]; //declaring jagged array with 3 arrays
jaggedarray[0] = new int[2] { 1, 2 }; //declaring first array 
jaggedarray[0][0] = 10; //changing value at index 0 of first array
jaggedarray[1] = new int[3];  //declaring second array
jaggedarray[1][0]= 10; //changing value at index 0 of second array

//string built-in methods 
string text = "     Hello World ";

Console.WriteLine(text.Length); //length of the string 
Console.WriteLine(text.ToUpper()); //convert to uppercase
Console.WriteLine(text.ToLower()); //convert to lowercase
Console.WriteLine(text.Contains("hello")); //check if string contains a substring, returns boolean (case sensitive)
Console.WriteLine(text.StartsWith("Hello")); //returns boolean (case sensitive)
Console.WriteLine(text.EndsWith("World")); //returns boolean (case sensitive)
Console.WriteLine(text.IndexOf("or")); //returns the index of the first occurrence of the substring, returns -1 if not found (case sensitive)
Console.WriteLine(text.LastIndexOf("o")); //returns the index of the last occurrence of the substring, returns -1 if not found (case sensitive)
//Very useful method
Console.WriteLine(text.Trim()); //removes whitespace from both ends of the string (before and after), use it before adding to database
Console.WriteLine(text.Replace(" ","---"));  //replaces *all* occurrences of a substring with another substring
Console.WriteLine(text.Substring(10)); //returns substring starting from the specified index to the end
Console.WriteLine(text.Substring(10, 3)); //returns substring starting from the specified index with the specified length

//veryy very  useful method
//split method : splits a string into an array of substrings based on a specified delimiter
string languages = "C#, Java, Python, JavaScript";
string[] langs =  languages.Split(", "); //splitting the string into an array of substrings based on the delimiter ", "

foreach (string langg in langs)
{
    Console.WriteLine(langg); //printing each substring
}

//join method : joins an array of strings into a single string with a specified delimiter (oppisite to split)
string joinedlangs = string.Join(" | ", langs); //joining the array of substrings into a single string with the delimiter " | "
Console.WriteLine(joinedlangs); //printing the joined string

Console.WriteLine("-----------------------------");

//DateTime
DateTime now = DateTime.Now; //current date and time(local)
Console.WriteLine(now);
DateTime utcNow = DateTime.UtcNow; //current date and time(UTC) --global current time
Console.WriteLine(utcNow);
var Today = DateTime.Today; //current date with time set to 00:00:00
Console.WriteLine(Today);
var custom = new DateTime(2023, 10, 5); //custom date (year, month, day) with time set to 00:00:00 (default)
Console.WriteLine(custom);
Console.WriteLine(custom.AddDays(10)); //adding 10 days to the custom date  
Console.WriteLine(custom.AddMonths(2)); //adding 2 months to the custom date
Console.WriteLine(custom.AddYears(1)); //adding 1 year to the custom date
Console.WriteLine(custom.ToString("yyyy/MM/dd")); //formatting the date to a specific format
Console.WriteLine(custom.ToString("yy/MMM/ddd"));
Console.WriteLine(custom.ToString("yy/MMMM/dddd"));


Console.WriteLine("--------------List---------------");

//declaration of collections
// collectionname<datatype> name = new collectionname<datatype>();

//non generic collection: ArrayList (can store any data type, not type safe, not recommended for new projects)
//generic collection: List<T> (can store any data type, type safe, recommended for new projects)



//1- List is like array but dynamic in size and provides many built-in methods and dosen't have specific data type , allows duplicate elements

// Fix for CS1503: Convert the string 'languagesss' into an IEnumerable<string> before passing it to AddRange.  
List<string> lang = new List<string>() {"nodejs","c" }; // Declaring a list of strings  
lang.Add("C#"); // Adding elements to the list  
lang.Add("Java");

// Correcting the issue by splitting the string into an array of substrings  
string languagesss = "C#, Java, Python, JavaScript";
lang.AddRange(languagesss.Split(", ")); // Split the string and add the resulting array to the list

//removing an element from the list
lang.Remove("JavaScript"); // Removing an element from the list (all similar)
lang.RemoveAt(0); // Removing an element at a specific index (index 0 here),not for all collections
lang.Insert(0, "JavaScript"); // Inserting an element at a specific index (index 0 here)
lang[2] = "TypeScript"; // Updating an element at a specific index (index 2 here)
foreach (string l in lang)
{
    Console.WriteLine(l); // Printing each element in the list  
}
Console.WriteLine(lang[0]); // Accessing elements by index


Console.WriteLine("-------------HashSet----------------");

// 2- HashSet (stores *unique* elements, no specific order, provides set operations like union, intersection, etc.)
//declaring a HashSet of integers 
//we have add and remove methods but no insert or update method
var Myset = new HashSet<int>(); // Declaring a HashSet of integers
Myset.Add(1); // Adding elements to the HashSet 
Myset.Add(2);
Myset.Add(2); // Duplicate elements are ignored
Myset.Add(3);
Myset.Add(4);
Myset.Add(5);

//to update an element, we have to remove it and add the new element
Myset.Remove(2); // Removing an element from the HashSet(all occurance)
Myset.Add(22); // Adding the updated element to the HashSet

foreach (var s in Myset)
{
    Console.WriteLine(s); // Printing each element in the HashSet
}
 
Console.WriteLine("-------------SortedSet----------------");

// 3- SortedSet (stores *unique* elements in sorted order, provides set operations like union, intersection, etc.)
//sorted set od strings

var MySortedset = new SortedSet<string>(); // Declaring a SortedSet of strings
MySortedset.Add("Banana"); // Adding elements to the SortedSet
MySortedset.Add("Apple");
MySortedset.Add("Orange");
MySortedset.Add("Mango");


foreach (var item in MySortedset)
{ 
    Console.WriteLine(item); // Printing each element in the SortedSet                       
}

Console.WriteLine("-------------Stack----------------");

// 4- Stack (LIFO - Last In First Out, provides push and pop operations)

Stack<int> mystack = new Stack<int>(); // Declaring a Stack of integers
//add->push
mystack.Push(1); // Adding elements to the Stack
mystack.Push(2);
mystack.Push(3);
mystack.Push(4);
//remove -> pop() :deletes and returns the top element of the stack
Console.WriteLine(mystack.Pop()); // Removing the top element from the Stack and printing it
Console.WriteLine(mystack.Peek()); // Returns the top element without removing it
