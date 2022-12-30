
using System;
using week5.Exercise_1;
using week5.Exercise_2;
using week5.Exercise_3;
using static week5.Exercise_4.Employee;
using week5.Exercise_4;
using week5.Exercise_5;
using week5.Exercise_6;
using week5.Exercise_7;

// Exercise 1
Console.WriteLine();

BankAccount myAccount = new BankAccount(123456, "John Doe", 1000);

myAccount.Deposit(500);
myAccount.Withdraw(200);

Console.WriteLine(myAccount.GetBalance());

List<Transaction> transactions = myAccount.GetTransactionHistory();
foreach (Transaction transaction in transactions)
{
    Console.WriteLine($"{transaction.Timestamp}: {transaction.Type} ${transaction.Amount}");
}

myAccount.AccountNumber = 654321;
myAccount.AccountHolder = "Jane Smith";

Console.WriteLine(myAccount.AccountNumber);
Console.WriteLine(myAccount.AccountHolder);


// Exercise 2
Console.WriteLine();

Book book = new Book("The Great Gatsby", "F. Scott Fitzgerald", 180);

Console.WriteLine(book.GetTitle());
Console.WriteLine(book.GetAuthor());
Console.WriteLine(book.GetPageCount());
Console.WriteLine(book.GetCurrentPage());

book.NextPage();
Console.WriteLine(book.GetCurrentPage());

book.NextPage();
book.NextPage();
book.NextPage();
Console.WriteLine(book.GetCurrentPage());

book.PreviousPage();
Console.WriteLine(book.GetCurrentPage());

book.Title = "The Great Gatsby (Revised Edition)";
Console.WriteLine(book.GetTitle());

book.Author = "F. Scott Fitzgerald (Revised by Jane Doe)";
Console.WriteLine(book.GetAuthor());


// Exercise 3
Console.WriteLine();

Rectangle rectangle1 = new Rectangle("Green", 6, 8);
Rectangle rectangle2 = new Rectangle("Yellow", 10, 12);

Circle circle1 = new Circle("Purple", 3);
Circle circle2 = new Circle("Orange", 5);

List<Shape> shapes = new List<Shape> { rectangle1, rectangle2, circle1, circle2 };

foreach (Shape shape in shapes)
{
    shape.CalculateArea();
}

shapes.Sort((shape1, shape2) => shape2.Area.CompareTo(shape1.Area));

foreach (Shape shape in shapes)
{
    Console.WriteLine(shape.Color + ": " + shape.Area);
}

double totalPerimeter = 0;
foreach (Shape shape in shapes)
{
    totalPerimeter += shape.GetPerimeter();
}

Console.WriteLine("Total perimeter: " + totalPerimeter + " inches");


// Exercise 4
Console.WriteLine();

Manager manager = new Manager("John Doe", 35, 50000, Department.IT);
Developer developer = new Developer("Jane Smith", 28, 30000, new List<string> { "C#", "JavaScript" }, false);

Console.WriteLine(manager.CalculateBonus());
Console.WriteLine(developer.CalculateBonus());

Console.WriteLine(manager.GetContactInfo());


// Exercise 5
Console.WriteLine();

BankAccount_Ex5 account1 = new BankAccount_Ex5("123456", "John Doe", 1000);
BankAccount_Ex5 account2 = new BankAccount_Ex5("654321", "Jane Smith", 2000);

account1.Deposit(500);
account2.Withdraw(1000);

Console.WriteLine(account1.Balance);
Console.WriteLine(account2.Balance);

Console.WriteLine(account1.GetInterest());
Console.WriteLine(account2.GetInterest());

Console.WriteLine(Bank.NumAccounts);


// Exercise 6
Console.WriteLine();

IShape circle6 = new Circle1(5);
IShape rectangle6 = new Rectangle1(10, 5);

Console.WriteLine(circle6.CalculateArea());
Console.WriteLine(rectangle6.CalculateArea());

Console.WriteLine(circle6.CalculateArea("square feet"));
Console.WriteLine(rectangle6.CalculateArea("square meters"));

IColor circle6Color = (IColor)circle6;
circle6Color.Color = "Red";

IColor rectangle6Color = (IColor)rectangle6;
rectangle6Color.Color = "Blue";

Console.WriteLine(circle6Color.Color);
Console.WriteLine(rectangle6Color.Color);


// Exercise 7
Console.WriteLine();

Hotel firstClient = new Client("Vlad", "Popescu", 1903, DateTime.Today, 3, NumberOfTheRoom.Room100);
Hotel secondClient = new Client("Ioana", "Ionescu", 2101, DateTime.Today, 7, NumberOfTheRoom.Room102);
Hotel thirdClient = new Client("Alexandra", "Munteanu", 2546, DateTime.Today, 5, NumberOfTheRoom.Room1011);
Hotel fourthClient = new Client("Gabriel", "Sava", 1975, DateTime.Today, 11, NumberOfTheRoom.Room107);

Console.WriteLine(firstClient.GetStayInfo());
Console.WriteLine(thirdClient.GetDueDate());
Console.WriteLine(secondClient.ClientId);
Console.WriteLine(fourthClient.GetClientInfo());

Console.WriteLine(fourthClient.AvailableRooms());

Console.WriteLine(firstClient.GetStayInfo("Welcome"));




















































































































