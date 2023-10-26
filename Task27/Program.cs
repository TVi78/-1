// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Sum(int num)
{
    int summa=0;
    if (num<0)
    {
        num=Math.Abs(num);
    }
    
    while(num/10>0)
    {
       summa+=num%10;
       num=num/10;
    }
    summa+=num;
    return summa;
}

Console.WriteLine("Напишите число:");
int number= Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(number));