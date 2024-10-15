//-----------------------------------------------------------------------------------------------

//1
//String[] country = { "Malta", "Latvia", "Hungary", "Slovenia", "Czech Rep"};

//for (int i = 0; i < country.Length; i++)
//{
//    Console.WriteLine(country[i]);
//}

//foreach (string item in country)
//{
//    Console.WriteLine(item);
//}
//country.ForEach(Console.WriteLine);

//-----------------------------------------------------------------------------------------------

//2
//int[] numbers = { 20, 5, 15, 10, 25, 35, 30 };

//Console.WriteLine(numbers.Length);

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}
//numbers.ForEach(Console.WriteLine);

//-----------------------------------------------------------------------------------------------

//3
//Console.WriteLine("Enter the number of students in the Programming Class");
//int numberOfStudents = int.Parse(Console.ReadLine());

//string[] students = new string[numberOfStudents];

//for (int i = 0; i < students.Length; i++)
//{
//    Console.WriteLine("Enter the name of student " + (i + 1));
//    students[i] = Console.ReadLine();
//}

//foreach (string student in students)
//{
//    Console.WriteLine(student);
//}
//students.ForEach(Console.WriteLine);
//Console.WriteLine("The number of students in the Programming Class is " + students.Length);

//-----------------------------------------------------------------------------------------------

//4
//int[] numbers = new int[10];
//int sum = 0;
//Console.WriteLine("Enter 10 numbers");
//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//foreach (int number in numbers)
//{
//    sum += number;
//}

//Console.WriteLine("The sum of the numbers is " + sum);

//-----------------------------------------------------------------------------------------------

//5
//Random random = new Random();
//int[] numbers = new int[5];

//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = random.Next(1, 42);
//}

//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}

//-----------------------------------------------------------------------------------------------

//6
//String[] names = new string[4];

//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine("Enter the name of student " + (i + 1));
//    names[i] = Console.ReadLine();
//}

//Console.Clear();

//Console.WriteLine("Enter a name to find in the array");
//string name = Console.ReadLine();

//if (names.Contains(name))
//{
//    Console.WriteLine(name + "found at position" + Array.IndexOf(names, name));
//}
//else
//{
//    Console.WriteLine(name + "not found");
//}

//-----------------------------------------------------------------------------------------------

//7

//Random random = new Random();

//int[] numbers = new int[5];

//for (int i = 0; i < numbers.Length; i++)
//{
//    int number = random.Next(1, 42);

//    if (numbers.Contains(number))
//    {
//        Console.WriteLine("Duplicate number found");
//        i--;
//    }
//    else
//    {
//        numbers[i] = number;
//    }
//}

//foreach (int number in numbers)
//{
//    Console.WriteLine(number);
//}

//-----------------------------------------------------------------------------------------------