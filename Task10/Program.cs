// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number2;
int number=Convert.ToInt32(Console.ReadLine());
if (number>99 && number<1000)
{
    number2=number/10;
    number=number2%10;
    Console.WriteLine($"{number}");
}
else 
{
    Console.WriteLine($"Число {number} не является трехзначным");
}

