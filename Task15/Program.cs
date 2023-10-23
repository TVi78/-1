// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int day=Convert.ToInt32(Console.ReadLine());

if (day==6 || day==7)
{
    Console.WriteLine("да");
}
else if (day<1 || day>7)
{
    Console.WriteLine("Такого дня недели нет");
}
else 
{
    Console.WriteLine("нет");
}
