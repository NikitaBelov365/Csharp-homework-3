// Задача 3
// Напишите программу, которая принимает на вход число 
// (N) и выдаёт таблицу кубов чисел от 1 до N.

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
int number = InputInt("Specify the number of restrictions for calculating cubes from 1");

for (int i = 1; i <= number; i++)
{
    int cube = i*i*i;
    System.Console.WriteLine($"{cube}");
}