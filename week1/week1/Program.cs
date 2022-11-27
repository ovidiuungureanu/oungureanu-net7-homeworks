// Exercise 1
// Input: 10  2
// Output: Addition = 12  Substraction = 8  Division = 5  Multiplication = 20

Console.WriteLine("Introduceti primul numar");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti al doilea numar");
int number2 = Convert.ToInt32(Console.ReadLine());

int addition = number1 + number2;
Console.WriteLine(addition);

int substraction = number1 - number2;
Console.WriteLine(substraction);

int division = number1 / number2;
Console.WriteLine(division);

int multiplication = number1 * number2;
Console.WriteLine(multiplication);

// Input: 12.9  3
// Output: Addition = 15.9  Substraction = 9.9  Division = 4.3  Multiplication = 38.7

Console.WriteLine("Introduceti primul numar");
double number3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Introduceti al doilea numar");
double number4 = Convert.ToDouble(Console.ReadLine());

double addition1 = number3 + number4;
Console.WriteLine(addition1);

double substraction1 = number3 - number4;
Console.WriteLine(substraction1);

double division1 = number3 / number4;
Console.WriteLine(division1);

double multiplication1 = number3 * number4;
Console.WriteLine(multiplication1);

// Exercise 2
// Input: 33 11 25
// Output: Minimum number is 11   Maximum number is 33

Console.WriteLine("Introduceti primul numar");
int number5 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti al doilea numar");
int number6 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti al treilea numar");
int number7 = Convert.ToInt32(Console.ReadLine());

int[] num = new int[3] {number5, number6, number7};

int min = num.Min();
Console.WriteLine("Minimum number is {0}.", min);

int max = num.Max();
Console.WriteLine("Maximum number is {0}.", max);

// Exercise 3
// Input = 1239
// Output = 3 years, 4 months, 24 days

Console.WriteLine("Number of days");
double totalDays = Convert.ToDouble(Console.ReadLine());

double totalYears = Math.Truncate(totalDays / 365);
double totalMonths = Math.Truncate((totalDays % 365) / 30);
double remainingDays = Math.Truncate((totalDays % 365) % 30);

Console.WriteLine(" {0} years, {1} months and {2} days", totalYears, totalMonths, remainingDays);

// Input = 409
// Output = 1 year, 1 month, 14 days

Console.WriteLine("Number of days");
double TotDays = Convert.ToDouble(Console.ReadLine());

double TotYears = Math.Truncate(TotDays / 365);
double TotMonths = Math.Truncate((TotDays % 365) / 30);
double ReDays = Math.Truncate((TotDays % 365) % 30);

Console.WriteLine(" {0} year, {1} month and {2} days", TotYears, TotMonths, ReDays);

// Exercise 4
// Input: 13, 99, -441
// Output: Minimum number is -441  Maximum number is 99

Console.WriteLine("Introduceti primul numar");
double number10 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Introduceti al doilea numar");
double number11 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Introduceti al treilea numar");
double number12 = Convert.ToDouble(Console.ReadLine());

double[] nums = new double[3] { number10, number11, number12 };

double min1 = nums.Min();
Console.WriteLine("Minimum number is {0}.", min1);

double max1 = nums.Max();
Console.WriteLine("Maximum number is {0}.", max1);

// Input: 33, 11, 25
// Output: Minimum number is 11    Maximum number is 33

Console.WriteLine("Introduceti trei numere");
int nr1 = Convert.ToInt32(Console.ReadLine());
int nr2 = Convert.ToInt32(Console.ReadLine());
int nr3 = Convert.ToInt32(Console.ReadLine());

string Min = nr1 < nr2 || nr1 < nr3 ? "Minimum number is " + nr1 :
                    nr2 < nr1 || nr2 < nr3 ? "Minimum number is " + nr2 :
                              nr3 < nr1 || nr3 < nr2 ? "Minimum number is " + nr3 : "No result";

Console.WriteLine(Min);

string Max = nr1 > nr2 || nr1 > nr3 ? "Maximum number is " + nr1 :
                    nr2 > nr1 || nr2 > nr3 ? "Maximum number is " + nr2 :
                              nr3 > nr1 || nr3 > nr2 ? "Maximum number is " + nr3 : "No result";

Console.WriteLine(Max);

// Exercise 5
// Input: Enter the Physics mark: 95
//        Enter the Chemistry mark: 95
//        Enter the Biology mark: 97
//        Enter the Mathematics mark: 98
//        Enter the Computer Science mark: 90
// Output: Percentage = 95.00 and grade is A.

Console.WriteLine("Input Physics Mark");
int Physics = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Chemistry Mark");
int Chemistry = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Biology Mark");
int Biology = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Mathematics Mark");
int Mathematics = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input ComputerScience Mark");
int ComputerScience = Convert.ToInt32(Console.ReadLine());

double Percentage = (Physics + Chemistry + Biology + Mathematics + ComputerScience) / 5;
Console.WriteLine("Percentage = " + Percentage);

if (Percentage >= 90)
{
    Console.WriteLine("grade is A");
}
else if (Percentage >= 80)
{
    Console.WriteLine("grade is B");
}
else if (Percentage >= 70)
{
    Console.WriteLine("grade is C");
}
else if (Percentage >= 60)
{
    Console.WriteLine("grade is D");
}
else if (Percentage >= 40)
{
    Console.WriteLine("grade is E");
}
else if (Percentage < 40)
{
    Console.WriteLine("grade is F");
}

// Exercise 6
// Input: V
// Output: Very Good

char Grade;
Console.WriteLine("Input the grade");
Grade = Convert.ToChar(Console.ReadLine());

switch (Grade)
{
    case 'E':
        Console.WriteLine("Excellent");
        break;
    case 'V':
        Console.WriteLine("Very Good");
        break;
    case 'G':
        Console.WriteLine("Good");
        break;
    case 'A':
        Console.WriteLine("Average");
        break;
    case 'F':
        Console.WriteLine("Fail");
        break;
}

// Exercise 7
// Input: 4
// Output: April

List<string> Months = new List<string>() { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
int MonthNr;
MonthNr = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Months[MonthNr - 1]);

// Exercise 8
// Input: 28
// Output: Normal in Temp

Console.WriteLine("Input Temperature");
int c = Convert.ToInt32(Console.ReadLine());

if (c < 0)
{
    Console.WriteLine("Freezing weather");
}
else if (c < 10 && c >= 0)
{
    Console.WriteLine("Very Cold weather");
}
else if (c < 20 && c >= 10)
{
    Console.WriteLine("Cold weather");
}
else if (c < 30 && c >= 20)
{
    Console.WriteLine("Normal in Temp");
}
else if (c < 40 && c >= 30)
{
    Console.WriteLine("Its Hot");
}
else if (c >= 40)
{
    Console.WriteLine("Its Very Hot");
}

//Exercise 9

Console.WriteLine("Exercise 9");

int Add = 25 + 25;
Console.WriteLine(Add);

int Sub = 67 - 32;
Console.WriteLine(Sub);

int Mul = 31 * 10;
Console.WriteLine(Mul);

int Div = 25 / 5;
Console.WriteLine(Div);

int Rem = 20 % 6;
Console.WriteLine(Rem);

int x1 = 5;
x1++;
Console.WriteLine(x1);

int x2 = 5;
x2--;
Console.WriteLine(x2);

int x3 = 5;
x3 += 6;
Console.WriteLine(x3);

int x4 = 5;
x4 -= 2;
Console.WriteLine(x4);






































