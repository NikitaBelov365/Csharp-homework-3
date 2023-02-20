// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом. Проверка без применения строк

int InputInt(string message)
{
    System.Console.WriteLine($"{message}>");
    int value;
    if (int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    System.Console.WriteLine("Its not a number");
    Environment.Exit(1);
    return 0;
}

bool ValidatePalindrome(int number)
{
    if (number / 10000 == number % 10 && number / 10 % 10 == number / 1000 % 10)
    {
        return true;
    }
    System.Console.WriteLine($"{number} is not a palindrome.");
    return false;

}
int number = InputInt("Input 5 digit number");
if(ValidatePalindrome(number))
{
    System.Console.WriteLine($"{number} is a palindrome!");
}
