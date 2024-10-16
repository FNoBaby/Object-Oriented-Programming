using System;

class Program
{
    static void Main()
    {
        string password = " ";
        string confPassword = " ";
        bool isPasswordMatch = false;

        while (!isPasswordMatch)
        {
            Console.WriteLine("Enter your password: ");
            //Using a Method for password reading to hide the password
            password = ReadPassword();
            Console.WriteLine("Confirm your password: ");
            //Using a Method for password reading to hide the password
            confPassword = ReadPassword();

            if (password == confPassword)
            {
                isPasswordMatch = true;
            }
            else
            {
                Console.WriteLine("Passwords do not match. Please try again.");
            }
        }

        Console.WriteLine("Password set successfully.");

        int attempts = 3;
        bool accessGranted = false;

        while (attempts > 0 && !accessGranted)
        {
            Console.WriteLine("Enter your password to access: ");
            //Using a Method for password reading to hide the password
            string enteredPassword = ReadPassword();

            if (enteredPassword == password)
            {
                accessGranted = true;
                Console.WriteLine("Access granted.");
            }
            else
            {
                attempts--;
                // Using string interpolation to display the number of attempts left
                // Calling a variable in the middle of a string by using {} and $ before the string allows the concatination to look cleaner
                Console.WriteLine($"Incorrect password. You have {attempts} attempt(s) left.");
            }
        }

        if (!accessGranted)
        {
            Console.WriteLine("Access denied.");
        }
    }

    static string ReadPassword()
    {
        string password = "";
        //ConsoleKeyInfo is a struct that represents the key that was pressed, along with the state of the modifier keys (Ctrl, Alt, and Shift).
        //This allows us to read the key that was pressed and the state of the modifier keys.
        ConsoleKeyInfo key;

        do
        {
            //ReadKey() method reads the next key pressed by the user and returns the pressed key.
            //The true parameter passed to the ReadKey() method indicates that the pressed key should not be displayed on the console.
            //This is done to hide the password.
            //The key variable stores the key that was pressed.
            //The key.Key property returns the ConsoleKey enumeration value that represents the key that was pressed.
            key = Console.ReadKey(true);

            //If the key pressed is not the Backspace key or the Enter key, the key character is added to the password string and an asterisk is displayed on the console.
            if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
            {
                //The key.KeyChar property returns the character representation of the key that was pressed.
                //The character representation of the key is added to the password string.
                //An asterisk is displayed on the console to hide the password.
                password += key.KeyChar;
                Console.Write("*");
            }
            //If the Backspace key is pressed and the password string is not empty, the last character is removed from the password string and the last character is erased from the console.
            //The password string is updated to remove the last character.
            //The \b escape sequence moves the cursor one position to the left, and the space character is displayed to erase the last character.
            else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
            {
                password = password.Substring(0, password.Length - 1);
                Console.Write("\b \b");
            }
            //If the Enter key is pressed, the loop is terminated.
            //The loop continues until the Enter key is pressed.
        } while (key.Key != ConsoleKey.Enter);

        Console.WriteLine();
        return password;
    }
}