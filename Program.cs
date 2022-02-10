//Assignment 1
Console.WriteLine("Assignmnet 1 Output\n");

//Test your Knowledge
//1) What type would you choose for the following "numbers"?
//A person’s telephone number
uint telephoneNumber = 1231231234;
Console.WriteLine($"uInt variable for telephone number: {telephoneNumber}");
//A person’s height
decimal height = 5.9m;
Console.WriteLine($"Decimal variable for person's height: {height}");
//A person’s age
byte personAge = 100;
Console.WriteLine($"uInt variable for telephone number: {personAge}");
//A person’s gender (Male, Female, Prefer Not To Answer)
Console.WriteLine($"Enum for person's gender: {Gender.Male}");
//A person’s salary
decimal salary = 80500.5m;
Console.WriteLine($"Decimal variable for salary: ${salary}");
//A book’s ISBN
long bookIsbn = 1234567891234;
Console.WriteLine($"Long variable for book’s ISBN: {bookIsbn}");
//A book’s price
decimal bookPrice = 14.35m;
Console.WriteLine($"Decimal variable for book price: ${bookPrice}");
//A book’s shipping weight
decimal bookShippinWeight = 20.123m;
Console.WriteLine($"Decimal variablecfor book’s shipping weight: {bookShippinWeight}");
//A country’s population
ulong cPopulation = 7123123123;
Console.WriteLine($"uLong variable for a country’s population: {cPopulation}");
//The number of stars in the universe
ulong starsInUniverse = 200123123123;
Console.WriteLine($"uLong variable for number of stars in the universe: {starsInUniverse}");
//The number of employees in each of the small or medium businesses in the United Kingdom (up to about 50,000 employees per business)
ushort numbEmployees = 50000;
Console.WriteLine($"uShort variable for number of employees: {numbEmployees}");

//2)What are the difference between value type and reference type variables? What is boxing and unboxing?
//Value type directly contain their data | Reference type Store references to their data (Known as objects)
//Value type each has its own copy of data | Reference type two reference variable can reference the same object
//Operation on one value type can not effect another | Operation on one reference type can effect another
//boxing: convert value type to reference type
//unboxing: convert reference type to value

//3.What is meant by the terms managed resource and unmanaged resource in .NET
//Managed resources are those that are pure .NET code and managed by the runtime and are under its direct control
//Unmanaged resources are those that are not. File handles, pinned memory, COM objects, database connections etc

//4.Whats the purpose of Garbage Collector in .NET?
//Don’t need to manually release memory
//Allocates objects on managed heap efficiently

//Playing with Console App
Console.WriteLine("\nPlaying with Console App");
string color = " ";
string astrologySign = " ";
string streetAddress = " ";
Console.WriteLine("What is your favorite color?");
color = Console.ReadLine();
Console.WriteLine("What is your astrology sign?");
astrologySign = Console.ReadLine();
Console.WriteLine("What is your street address?");
streetAddress = Console.ReadLine();
Console.WriteLine($"Your hacker name is: {color}{astrologySign}{streetAddress}.");

//Practice number sizes and ranges
Console.WriteLine("\nPractice number sizes and ranges");
//1) Understanding types (bytes, min, max)
//sbyte
Console.WriteLine(String.Format("{0} = #bytes: {1}, min: {2:E}, max: {3:E}", "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue));
//byte
Console.WriteLine(String.Format("{0} = #bytes: {1}, min: {2:E}, max: {3:E}", "byte", sizeof(byte), byte.MinValue, byte.MaxValue));
//short
Console.WriteLine(String.Format("{0} = #bytes: {1}, min: {2:E}, max: {3:E}", "short", sizeof(short), short.MinValue, short.MaxValue));
//ushort
Console.WriteLine(String.Format("{0} = #bytes: {1}, min: {2:E}, max: {3:E}", "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue));
//int
Console.WriteLine(String.Format("{0} = #bytes: {1}, min: {2:E}, max: {3:E}", "int", sizeof(int), int.MinValue, int.MaxValue));
//uint
Console.WriteLine(String.Format("{0} = #bytes: {1}, min: {2:E}, max: {3:E}", "uint", sizeof(uint), uint.MinValue, uint.MaxValue));
//long
Console.WriteLine(String.Format("{0} = #bytes: {1}, min: {2:E}, max: {3:E}", "long", sizeof(long), long.MinValue, long.MaxValue));
//ulong
Console.WriteLine(String.Format("{0} = #bytes: {1}, min: {2:E}, max: {3:E}", "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue));
//float
Console.WriteLine(String.Format("{0} = #bytes: {1}, min: {2:E}, max: {3:E}", "float", sizeof(float), float.MinValue, float.MaxValue));
//double
Console.WriteLine(String.Format("{0} = #bytes: {1}, min: {2:E}, max: {3:E}", "double", sizeof(double), double.MinValue, double.MaxValue));
//decimal
Console.WriteLine(String.Format("{0} = #bytes: {1}, min: {2:E}, max: {3:E}", "decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue));

//2) Centuries Conversion
int century = 0;
Console.WriteLine("\nInput an integer of century to convert: ");
century = Convert.ToInt32(Console.ReadLine());
int year = century * 100;
long days = century * 36524;
long hours = century * 876576;
long minutes = century * 52594560;
long seconds = century * 3155673600;
ulong milliseconds = (ulong)(century * 3155673600000);
ulong microseconds = (ulong)(century * 3155673600000000);
ulong nanoseconds =(ulong)(century * 3155673600000000000);
Console.WriteLine($"{century} century = {year} years = {days} days = {hours} hours = {minutes} minutes = {seconds} " +
    $"seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");

//Controlling Flow and Converting Types 
//Test your Knowledge
//1) What happens when you divide an int variable by 0?
//A runtime error as an unhandle exception for dividing by zero.

//2) What happens when you divide a double variable by 0?
//It returns infinity.

//3) What happens when you overflow an int variable, that is, set it to a value beyond its range?
//When an integer overflows, it goes around to the other side of its range.

//4) What is the difference between x = y++; and x = ++y;?
// In x = y++, x = y
// While in x = ++y, x = y + 1

//5) What is the difference between break, continue, and return when used inside a loop statement?
//  Break get out of a loop without having to return anything
//  Continue gets out of one iteration of the loop, then continues the loop
//  Return get out of a loop while returning data

//6) What are the three parts of a for statement and which of them are required?
// for (part1; part2; part3) {}
//Part 1 - Initializer: Is executed one time before the execution of the code block
//Part 2 - Condition: Defines the condition for executing the code block
//Part 3 - Iteration: Is executed every time after the code block has been executed
//All parts are optional and not required.

//7) What is the difference between the = and == operators ?
// = operator assigns a value to a variable while the
// == operator compares both variables returning true if they equal or false otherwise

//8) Does the following statement compile? for ( ; true; ) ;
//Yes the statement compiles.

//9) What does the underscore _ represent in a switch expression?
// _ represents the default case in a switch statement, which executes when there is no match

//10.What interface must an object implement to be enumerated over by using the foreach statement?
//The IEnumerable interface provides support for the foreach iteration.
//IEnumerable requires that you implement the GetEnumerator method.

//Practice loops and operators
Console.WriteLine("\nPractice loops and operators");
//1) FizzBuzzi
int max = 100;
for (byte i = 1; i <= max; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.Write("Fizz Buzz, ");
        continue;
    }
    else if (i % 3 == 0)
    {
        Console.Write("Fizz, ");
        continue;
    }
    else if (i % 5 == 0)
    {
        Console.Write("Buzz, ");
        continue;
    }
    Console.Write(i + ", ");
}

//2) Print-a-Pyramid
Console.WriteLine("\n");
int stars = 0, space = 0;
int rows = 5, cloumn = 9;
for (int i = 0; i < rows; i++)
{
    stars = (i * 2) + 1;
    space = cloumn - stars;
    //First Spaces
    for (int x = 0; x < space / 2; x++)
    {
        Console.Write(" ");
    }
    //Stars
    for (int y = 0; y < stars; y++)
    {
        Console.Write("*");
    }
    //Last Spaces
    for (int z = 0; z < space; z++)
    {
        Console.Write(" ");
    }
    Console.Write("\n");
}

//3) Random number generation
int correctNumber = new Random().Next(3) + 1;
Console.WriteLine("\nWhat is the correct number");
int guessedNumber = int.Parse(Console.ReadLine());
if (guessedNumber >= 1 && guessedNumber <= 3)
{
    if (correctNumber == guessedNumber)
    {
        Console.WriteLine("Correct!");
    }
    else if (correctNumber < guessedNumber)
    {
        Console.WriteLine("Guessed High");
    }
    else if (correctNumber > guessedNumber)
    {
        Console.WriteLine("Guessed Low");
    }
}
else
{
    Console.WriteLine("Number is outside of range");
}

//4) Days Old
int birthYear, birthMonth, birthDay, daysOld = 0;
DateTime dateTime = DateTime.Now;

Console.WriteLine("When is your birth year?");
birthYear = int.Parse(Console.ReadLine());
Console.WriteLine("When is your birth month?");
birthMonth = int.Parse(Console.ReadLine());
Console.WriteLine("When is your birth day?");
birthDay = int.Parse(Console.ReadLine());

birthYear = int.Parse(dateTime.ToString("yyyy")) - birthYear;
birthMonth = int.Parse(dateTime.ToString("MM")) - birthMonth;
birthDay = int.Parse(dateTime.ToString("dd")) - birthDay;

daysOld = (birthYear * 365) + (birthMonth * 30) + (birthDay);

Console.WriteLine($"Person is {daysOld} days old.");

//5) Time Greeting
if (int.Parse(dateTime.ToString("HH")) >= 5 && int.Parse(dateTime.ToString("HH")) <= 11)
{
    Console.WriteLine("Good Morning");
}
if (int.Parse(dateTime.ToString("HH")) >= 12 && int.Parse(dateTime.ToString("HH")) <= 16)
{
    Console.WriteLine("Good Afternoon");
}
if (int.Parse(dateTime.ToString("HH")) >= 17 && int.Parse(dateTime.ToString("HH")) <= 20)
{
    Console.WriteLine("Good Evening");
}
if (int.Parse(dateTime.ToString("HH")) >= 21 || int.Parse(dateTime.ToString("HH")) <= 4)
{
    Console.WriteLine("Good Night");
}

//6) Count up to 24
int maxNumb = 24;
int numbCounting = 4;
for (int z = 1; z  <= numbCounting; z++)
{
    for (int a = 0; a <= maxNumb; a = a + z)
    {
        Console.Write(a + ", ");
    }
    Console.WriteLine("");
}

//Assignment 2 TestRun
Assignment2 testRunA2 = new Assignment2();

//None top level statments
enum Gender { Male, Female, Prefer_Not_To_Answer }