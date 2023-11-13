// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.


int side(string msg)
{
    System.Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void GetBinaryView(int number)
{
    if (number == 0)
    {
        return;
    }
    GetBinaryView(number / 2);
    System.Console.Write(number % 2);
}

int number = side("Введите число: ");
GetBinaryView(number);