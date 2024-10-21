//----------------------------------------------------------
//Part A
//1

void printDate()
{
    Console.WriteLine(DateTime.Now);
}

//----------------------------------------------------------
//2

void printOddNumbers()
{
    for (int i = 1; i <= 20; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
    }
}

//----------------------------------------------------------
//Part B
//1

void printCharacters()
{
    Console.WriteLine("Enter the Letter to start");
    char start = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

    Console.WriteLine("Enter the Letter to end");
    char end = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

    start++;
    for (char c = start ; c < end; c++)
    {
        Console.WriteLine(c);
    }
}

//----------------------------------------------------------
//2

void printRandomBitMatrix(int n)
{
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(random.Next(2) + " ");
        }
        Console.WriteLine();
    }
}

//Console.WriteLine("Matrix dimensions: ");
//int n = Convert.ToInt32(Console.ReadLine());
//printRandomBitMatrix(n);

//----------------------------------------------------------
//3

void computeFutureInvestmentValue(double principal, double rate, int years)
{
    rate = rate / 100; // Convert percentage to decimal
    Console.WriteLine("Years\tFutureValue");
    for (int i = 1; i <= years; i++)
    {
        double futureValue = principal * Math.Pow(1 + rate, i);
        Console.WriteLine($"{i}\t{futureValue:F2}");
    }
}

//Console.WriteLine("Enter principal");
//double principal = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter rate");
//double rate = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter years");
//int years = Convert.ToInt32(Console.ReadLine());

//computeFutureInvestmentValue(principal, rate, years);


//double principal = 1000;
//double rate = 10;
//int years = 5;
//computeFutureInvestmentValue(principal, rate, years);

//----------------------------------------------------------
// Part C
//1

bool isValidPassword(string password)
{
    if (password.Length < 10)
    {
        return false;
    }

    int digitCount = 0;
    foreach (char c in password)
    {
        if (!char.IsLetterOrDigit(c))
        {
            return false;
        }
        if (char.IsDigit(c))
        {
            digitCount++;
        }
    }

    return digitCount >= 2;
}

//Console.WriteLine("Input a password:");
//string password = Console.ReadLine();

//bool isValid = isValidPassword(password);
//Console.WriteLine("Password is valid:" + isValid + " " + password);

//----------------------------------------------------------
//2

double readDouble(string prompt)
{
    double value;
    while (true)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine();

        // Try to parse the input
        // If successful, return the value
        // Otherwise, print an error message and try again
        // TryParse is a safer way to parse numbers than Convert.ToDouble
        // because it doesn't throw an exception if the input is invalid
        // It returns a boolean indicating whether the parsing was successful

        if (double.TryParse(input, out value))
        {
            return value;
        }
        Console.WriteLine("Invalid input. Please enter a number.");
    }
}

//double value = readDouble("Enter a number:");
//Console.WriteLine("You entered: " + value);

//----------------------------------------------------------
//3
ConsoleColor getRandomConsoleColor()
{
    Array colors = Enum.GetValues(typeof(ConsoleColor));
    Random random = new Random();
    return (ConsoleColor)colors.GetValue(random.Next(colors.Length));
}

//ConsoleColor randomColor = getRandomConsoleColor();
//Console.WriteLine("Random color: " + randomColor);

//----------------------------------------------------------
// Part D
//1

double findSmallestNumber(int num1 ,int num2, int num3)
{
    return Math.Min(num1, Math.Min(num2, num3));
}

//int num1 = 25;
//int num2 = 37;
//int num3 = 29;
//double smallest = findSmallestNumber(num1, num2, num3);
//Console.WriteLine("The smallest number is: " + smallest);

//----------------------------------------------------------
//2

double calculateAverage(int num1 ,  int num2, int num3)
{
    return (num1 + num2 + num3) / 3.0;
}

//int num1 = 25;
//int num2 = 45;
//int num3 = 65;
//double average = calculateAverage(num1, num2, num3);
//Console.WriteLine("The average is: " + average);

//----------------------------------------------------------
//3

void displayMiddleCharacter(string str)
{
    int length = str.Length;
    int middle = length / 2;

    if (length % 2 == 0)
    {
        // Even length: display one middle character
        Console.WriteLine("The middle character in the string: " + str[middle]);
    }
    else
    {
        // Odd length: display two middle characters
        Console.WriteLine("The middle characters in the string: " + str[middle - 1] + str[middle]);
    }
}

//Console.WriteLine("Input a string:");
//string input = Console.ReadLine();
//displayMiddleCharacter(input);


//----------------------------------------------------------
//4

int countVowels(string str)
{
    int count = 0;
    foreach (char c in str)
    {
        if ("AEIOUaeiou".Contains(c))
        {
            count++;
        }
    }
    return count;
}

//string str = "Hello, World!";
//int vowelCount = countVowels(str);
//Console.WriteLine("Number of vowels: " + vowelCount);

//----------------------------------------------------------
//5
int countWords(string str)
{
    // Check if the input string is null or empty
    // If so, return 0
    // Split the string into words using whitespace characters
    // IsNullOrWhiteSpace is a convenient method that checks for null, empty, or whitespace strings
    if (string.IsNullOrWhiteSpace(str))
    {
        return 0;
    }

    string[] words = str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
    return words.Length;
}

//Console.WriteLine("Input the string:");
//string input = Console.ReadLine();
//int wordCount = countWords(input);
//Console.WriteLine("Number of words in the string: " + wordCount);

//----------------------------------------------------------
//6

int sumOfDigits(int number)
{
    int sum = 0;
    string numberStr = Math.Abs(number).ToString(); // Convert the number to a string and handle negative numbers

    foreach (char digit in numberStr)
    {
        sum += int.Parse(digit.ToString());
    }

    return sum;
}

//Console.WriteLine("Input an integer:");
//int input = Convert.ToInt32(Console.ReadLine());
//int sum = sumOfDigits(input);
//Console.WriteLine("The sum is " + sum);

//----------------------------------------------------------
//7
bool isLeapYear(int year)
{
    if (year % 4 == 0)
    {
        if (year % 100 == 0)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            return false;
        }
        return true;
    }
    return false;
}

//Console.WriteLine("Input a year:");
//int year = Convert.ToInt32(Console.ReadLine());
//bool result = isLeapYear(year);
//Console.WriteLine(result);

//----------------------------------------------------------
//8

double calculateTriangleArea(double side1, double side2, double side3)
{
    // Calculate the semi-perimeter
    double s = (side1 + side2 + side3) / 2;

    // Calculate the area using Heron's formula
    double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));

    //Rounds to 2 d.p.
    return Math.Round(area, 2);
}

//Console.WriteLine("Input Side-1:");
//double side1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Input Side-2:");
//double side2 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Input Side-3:");
//double side3 = Convert.ToDouble(Console.ReadLine());

//double area = calculateTriangleArea(side1, side2, side3);
//Console.WriteLine("The area of the triangle is" + area);