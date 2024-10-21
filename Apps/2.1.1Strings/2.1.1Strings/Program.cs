//-------------------------------------------------------------
//1

// Prompt the user to enter a word
Console.Write("Please enter a word: ");
string word = Console.ReadLine();

// (a)
Console.WriteLine("Total number of characters: " + word.Length);

// (b)
Console.WriteLine("Uppercase: " + word.ToUpper());

// (c)
Console.WriteLine("Lowercase: " + word.ToLower());

//-------------------------------------------------------------
//2

Console.Write("Enter two words in one line: ");
string input = Console.ReadLine();

// Split the input into two words
string[] words = input.Split(' ');

// Display the first and second words
if (words.Length == 2)
{
    Console.WriteLine("First word: " + words[0]);
    Console.WriteLine("Second word: " + words[1]);
}
else
{
    Console.WriteLine("Please enter exactly two words separated by a space.");
}

//-------------------------------------------------------------
//3

// Prompt the user to enter a string with leading and trailing spaces
Console.Write("Enter a word: ");
string inputString = Console.ReadLine();

// Remove the leading and trailing spaces
string trimmedString = inputString.Trim();

// Display the trimmed string
Console.WriteLine("You have entered: " + trimmedString);

//-------------------------------------------------------------
//4

// Prompt the user to enter name and surname
Console.Write("Enter your name and surname: ");
string name = Console.ReadLine();
string surname = Console.ReadLine();

// Get the initials
char nameInitial = char.ToUpper(name[0]);
char surnameInitial = char.ToUpper(surname[0]);

// Display the initials
Console.WriteLine("Your initials are " + nameInitial + "." + surnameInitial + ".");

//-------------------------------------------------------------
//5

// Generate three random letters
Random random = new Random();
char randomChar1 = (char)random.Next('a', 'z' + 1);
char randomChar2 = (char)random.Next('a', 'z' + 1);
char randomChar3 = (char)random.Next('A', 'Z' + 1);

// Display the random characters
Console.WriteLine("Random character 1: " + randomChar1);
Console.WriteLine("Random character 2: " + randomChar2);
Console.WriteLine("Random character 3: " + randomChar3);

// Join the characters into one string
string randomWord = $"{randomChar1}{randomChar2}{randomChar3}";

// Display the created word
Console.WriteLine("You have created the word: " + randomWord);

