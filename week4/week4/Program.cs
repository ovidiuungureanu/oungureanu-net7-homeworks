using System.Security.Cryptography.X509Certificates;
using week4;


// Exercise 1

Book book = new Book ("War and Peace", "Leo Tolstoy", 1869 );

Console.WriteLine(book.GetTitle());
Console.WriteLine(book.GetAuthor());
Console.WriteLine(book.GetYear());
Console.WriteLine();

book.SetTitle("Anna Karenina");
book.SetAuthor("Leo Tolstoy");
book.SetYear(1877);

Console.WriteLine(book.GetTitle());
Console.WriteLine(book.GetAuthor());
Console.WriteLine(book.GetYear());


// Exercise 2
Console.WriteLine();

Product product = new Product("Apple", 0.99, 10);

Console.WriteLine(product.GetName());
Console.WriteLine(product.GetPrice());
Console.WriteLine(product.GetQuantity());
Console.WriteLine();

product.SetName("Orange");
product.SetPrice(1.49);
product.SetQuantity(20);

Console.WriteLine(product.GetName());
Console.WriteLine(product.GetPrice());
Console.WriteLine(product.GetQuantity());


// Exercise 3
Console.WriteLine();

Animal animal = new Animal("Max", "Dog", "Labrador Retriever", 2, "Yellow", 75, true);

Console.WriteLine(animal.GetName());
Console.WriteLine(animal.GetSpecies());
Console.WriteLine(animal.GetBreed());
Console.WriteLine(animal.GetAge());
Console.WriteLine(animal.GetColor());
Console.WriteLine(animal.GetWeight());
Console.WriteLine(animal.IsSpayedOrNeutered());
Console.WriteLine();

animal.SetName("Buddy");
animal.SetSpecies("Cat");
animal.SetBreed("Siamese");
animal.SetAge(5);
animal.SetColor("Gray");
animal.SetWeight(12);
animal.SetIsSpayedOrNeutered(false);

Console.WriteLine(animal.GetName());
Console.WriteLine(animal.GetSpecies());
Console.WriteLine(animal.GetBreed());
Console.WriteLine(animal.GetAge());
Console.WriteLine(animal.GetColor());
Console.WriteLine(animal.GetWeight());
Console.WriteLine(animal.IsSpayedOrNeutered());


// Exercise 4
Console.WriteLine();

Calculator calculator = new Calculator();

Console.WriteLine(calculator.Add(2, 3));
Console.WriteLine(calculator.Subtract(5, 2));
Console.WriteLine(calculator.Multiply(3, 4));
Console.WriteLine(calculator.Divide(10, 5));
Console.WriteLine(calculator.Power(2, 3));
Console.WriteLine(calculator.SquareRoot(9));


// Exercise 5
Console.WriteLine();

University myUniversity = new University("My University");

Student john = new Student("John", "Doe", 123456, 3.8);
Student jane = new Student("Jane", "Smith", 654321, 3.6);

myUniversity.AddStudent(john);
myUniversity.AddStudent(jane);

Faculty mary = new Faculty("Mary", "Jones", 111111, new List<string>() { "Math", "Physics" });
Faculty bob = new Faculty("Bob", "Smith", 222222, new List<string>() { "English", "History" });

myUniversity.AddFaculty(mary);
myUniversity.AddFaculty(bob);

Console.WriteLine(myUniversity.GetStudentCount());
Console.WriteLine(myUniversity.GetFacultyCount());

// Exercise 6
Console.WriteLine();

College college = new College();
college.name = "Frantz";
Student1 ovi = new Student1("Ovidiu", DateTime.Now.AddYears(-12), DateTime.Now.AddYears(2), college, DateTime.Now.AddYears(-25));
ovi.Print();
Console.WriteLine(ovi.IsStillStudent());


// Exercise 7




