
// Семинар 2. Задача 1.
// ПРОВЕРЯЕМ КАКОЕ ИЗ ДВУХ ЧИСЕЛ БОЛЬШЕ

Console.WriteLine("Введите целое число");

string inputedString1 = Console.ReadLine();
string inputedString2 = Console.ReadLine();

int number1 = Convert.ToInt32(inputedString1);
// Console.WriteLine($"Вы ввели число {number1}!");
int number2 = Convert.ToInt32(inputedString2);
// Console.WriteLine($"Вы ввели число {number2}!");

if (number1 > number2)
{ 
    Console.WriteLine($"Первое чисто {number1} больше второго {number2}"); 
}
else 
 Console.WriteLine($"второе число {number2} больше первого  {number1}");
