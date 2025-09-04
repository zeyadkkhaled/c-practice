//Collection: OOP Example
using OOP_Example;

List <Book> Books = new List<Book>(); //List of books to store book objects 
Dictionary<int, Book> BookDict = new Dictionary<int, Book>(); // Dictionary to search book by ID instead of searching in list because searching in dictionary is faster
Dictionary<int,Queue<string>> WaitingList = new Dictionary<int, Queue<string>>(); // Dictionary to maintain waiting list for each book (book ID as key and queue of names as value)

int nextId = 1;

while (true)
{
    Console.WriteLine("\nLibrary Menu:   \n");
    Console.WriteLine("1. Add Book ");
    Console.WriteLine("2. Display All Books");
    Console.WriteLine("3. Borrow Book");
    Console.WriteLine("4. Return Book");
    Console.WriteLine("5. Exit");
    Console.Write("Choose an option: ");
    var choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            var book = new Book();
            book.Id = nextId++;
            Console.Write("Enter Title: ");
            book.Title = Console.ReadLine();
            Console.Write("Enter Author: ");
            book.Author = Console.ReadLine();
            Console.Write("Enter Number of Pages: ");
            if (int.TryParse(Console.ReadLine(), out int pages) && pages > 0)
            {
                book.Pages = pages;
                Books.Add(book); //Add book to the list we created
                BookDict[book.Id] = book; //Add book to the dictionary we created (for search)
                WaitingList[book.Id] = new Queue<string>(); //Initialize waiting list for the book
                Console.WriteLine("Book added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid number of pages.");
            }
            break;
        case "2":
            Console.WriteLine("\nAll Books in Library:");
            if (Books.Count > 0)
            {
                foreach (var b in Books)
                {
                    b.DisplayInfo(); //Display book info using polymorphic method
                }
            }
            else
            {
                Console.WriteLine("\nNo books available.\n");
            }
            break;
        case "3":
            Console.WriteLine("Enter Book ID");
            if(int.TryParse(Console.ReadLine(), out int BookID) && BookDict.ContainsKey(BookID))
            {
                var bookToBorrow = BookDict[BookID];
                if (bookToBorrow.isAvailable) //check availability (not borrowed)
                {
                    Console.WriteLine("Enter your Name: \n");
                    var Borrower = Console.ReadLine();
                    bookToBorrow.isAvailable = false; //mark as borrowed
                    Console.WriteLine($"You have borrowed '{bookToBorrow.Title}'.");
                }
                else //Borrowed
                {
                    Console.Write("Book is currently unavailable. Enter your name to join the waiting list: ");
                    var name = Console.ReadLine();
                    WaitingList[BookID].Enqueue(name);
                    Console.WriteLine($"{name} have been added to the waiting list for '{bookToBorrow.Title}'.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Book ID.");
            }
            break;
        case "4":
            Console.WriteLine("Enter Book ID to return:");
            if (int.TryParse(Console.ReadLine(), out int BookReturnID)&&BookDict.ContainsKey(BookReturnID))
            {
                var bookToReturn = BookDict[BookReturnID];
                if (!bookToReturn.isAvailable) //if it was borrowed
                {
                    bookToReturn.isAvailable = true; //mark as available
                    Console.WriteLine($"You have returned '{bookToReturn.Title}'.");
                    //Check waiting list
                    if (WaitingList[BookReturnID].Count > 0)
                    {
                        var nextBorrower = WaitingList[BookReturnID].Dequeue();
                        bookToReturn.isAvailable = false; //mark as borrowed again
                        Console.WriteLine($"{nextBorrower}, you have borrowed '{bookToReturn.Title}' from the waiting list.");
                    }
                    else //No one in waiting list
                    {
                        Console.WriteLine($"'{bookToReturn.Title}' is now available for borrowing.");
                    }
                }
                else
                {
                    Console.WriteLine("This book was not borrowed.");
                }


            }
            break;
    }
}