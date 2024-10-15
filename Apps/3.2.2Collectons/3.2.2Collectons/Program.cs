//--------------------------------------------------------------------------------

//1

//String[] malti = {"ktieb", "tifel", "missier", "pjanta", "karozza"};
//String[] english = { "book", "child", "father", "plant", "car" };

//while (true)
//{
//    Console.WriteLine("-----Menu-----");
//    Console.WriteLine("1. Malti to English");
//    Console.WriteLine("2. English to Malti");
//    Console.WriteLine("3. Exit");

//    int choice = Convert.ToInt32(Console.ReadLine());

//    switch (choice) {
//        case 1:
//            Console.WriteLine("Enter a word in Malti");
//            string word = Console.ReadLine();

//            if (malti.Contains(word)) {
//                Console.WriteLine("The translation of: " + word + " is " + english[Array.IndexOf(malti , word)]);
//            }
//            else
//            {
//                Console.WriteLine("Word not found");
//            }
//            break;

//        case 2:
//            Console.WriteLine("Enter a word in English");
//            string word2 = Console.ReadLine();

//            if (english.Contains(word2))
//            {
//                Console.WriteLine("The translation of: " + word2 + " is " + malti[Array.IndexOf(english, word2)]);
//            }
//            else
//            {
//                Console.WriteLine("Word not found");
//            }
//            break;

//        case 3:
//            Console.WriteLine("Exiting program");
//            return;

//        default:
//            Console.WriteLine("Invalid choice");
//            break;
//    }
//}

//--------------------------------------------------------------------------------

//2
//String[] employees = null;
//while (true)
//{
//    Console.WriteLine("Safari Travel Employees");
//    Console.WriteLine("1) Create New Employees List");
//    Console.WriteLine("2) View All Employees List");
//    Console.WriteLine("3) Edit Employee");
//    Console.WriteLine("4) Search Employee");
//    Console.WriteLine("5) Quit");

//    int choice = Convert.ToInt32(Console.ReadLine());

//    switch (choice) {
//        case 1:
//            Console.WriteLine("Enter number of employees");
//            int num = Convert.ToInt32(Console.ReadLine());

//            employees = new String[num];

//            for (int i = 0; i < num; i++)
//            {
//                Console.WriteLine("Enter employee name");
//                employees[i] = Console.ReadLine();
//            }
//            break;
//        case 2:
//            if (employees == null)
//            {
//                Console.WriteLine("No employees found");
//            }
//            else
//            {
//                foreach (string employee in employees)
//                {
//                    Console.WriteLine(employee);
//                }
//            }
//            break;
//        case 3:
//            Console.WriteLine("Enter employee name to edit");
//            string name = Console.ReadLine();

//            if (employees.Contains(name))
//            {
//                Console.WriteLine("Enter new name");
//                string newName = Console.ReadLine();
//                employees[Array.IndexOf(employees, name)] = newName;
//            }
//            else
//            {
//                Console.WriteLine("Employee not found");
//            }
//            break;
//        case 4:
//            Console.WriteLine("Enter employee name to search");
//            string search = Console.ReadLine();

//            if (employees.Contains(search))
//            {
//                Console.WriteLine("Employee found");
//            }
//            else
//            {
//                Console.WriteLine("Employee not found");
//            }
//            break;
//        case 5:
//            Console.WriteLine("Exiting program");
//            return;
//        default:
//            Console.WriteLine("Invalid choice");
//            break;
//    }

//}

//--------------------------------------------------------------------------------

//3

//Random random = new Random();
//int[] numbers = new int[5];
//int[] guess = new int[5];

//for (int i = 0; i < 5; i++)
//{
//    numbers[i] = random.Next(1, 3);
//}

//while (true)
//{
//    for (int i = 0; i < 5; i++)
//    {
//        Console.WriteLine("Guess Number " + i + " : ");
//        guess[i] = Convert.ToInt32(Console.ReadLine());
//    }

//    int correct = 0;
//    for (int i = 0; i < 5; i++)
//    {
//        if (numbers[i] == guess[i])
//        {
//            correct++;
//        }
//    }
//    if(correct == 0)
//    {
//        Console.WriteLine("You guessed none of the Numbers");
//    }
//    else if(correct != 5)
//    {
//        Console.WriteLine("You guessed some of the Numbers");
//    }
//    else
//    {
//        Console.WriteLine("You guessed all the Numbers");
//        break;
//    }
//}

