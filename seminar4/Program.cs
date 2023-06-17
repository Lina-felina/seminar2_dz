// Семинар 1. Задача 4.
// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N");

string inputedString = Console.ReadLine();

int N = Convert.ToInt32(inputedString);


Console.WriteLine($"Все числа от 1 до {N}");
int a = 2;

while (a <= N)
{
    Console.WriteLine(a);
    a +=2;
}
