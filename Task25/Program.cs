// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int stepen (int A, int B)
{
    int sum=1;
    for (int i = 1; i < B+1; i++)
    {
        sum*=A;
    }
    return sum;
}


Console.WriteLine("Введите числа:");
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(stepen(a, b));