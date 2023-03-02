//Console.WriteLine("Hello!");
//int a = Console.ReadLine();
//Console.Write("Imput number: ");
//int a = Convert.ToInt32(Console.ReadLine());
//int a = int.Parse(Console.ReadLine()!);
//Console.WriteLine("You imput this number ->"  + a );  //You imput this number ->7679
//Console.WriteLine($"You imput This number --> {a} "); //You imput This number --> 7679
//=========================================================

//Пользователь вводит число и в ответ получает его квадрат.

//Console.Write("Imput namber: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($" Quad of {a} -> {a * a}");  /or
//int quad = a * a ;
//Console.WriteLine($"Answer {quad}");

//==========================================================

// Задача 2. Напишите программу, которая на вход принимает два числа
// и проверяет, является ли первое число квадратом второго.

// Console.Write("Imput first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Imput second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if(num2 * num2 == num1)

// {
//     Console.WriteLine($"Answer: {num1} - is the square of the number {num2}");
// }
// else
// {
//     Console.WriteLine($"Answer: {num1} - is not the square of the number {num2}");
// }
//=========================================================

// Задача 3. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// Console.Write("Imput N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int current = n * (-1);
// while (current <= n)
// {
//     Console.Write(current + " ");
//     current++;
// }

//==============================================================

// Задача 4. 1. Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает **последнюю** цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Enter a three-digit number: ");
int num =  Convert.ToInt32(Console.ReadLine());

if(num >=100 && num <=999)
{
    int remainder = num % 10;
    Console.WriteLine($"Last digit of {num} -> {remainder}");
}
else
{
    Console.WriteLine("You imput not three-digit number!");
}