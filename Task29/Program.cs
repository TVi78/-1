// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] vivod(int len)
{
int[] number=new int[len];
for (int i = 0; i < len; i++)
{
 Console.Write($"Введите {i} элемент: ");   
 number[i]= Convert.ToInt32(Console.ReadLine());
}
return number;
}

Console.WriteLine("Напишите количество элементов в массиве:");
int len= Convert.ToInt32(Console.ReadLine());

Console.WriteLine(string.Join(", ", vivod(len)));