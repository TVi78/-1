// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int positNumber(int m){
int k=0;
int[] mass=new int[m];
Console.WriteLine("Введите числа: ");
    for (int i=0; i<m; i++){
        mass[i]=Convert.ToInt32(Console.ReadLine());
        if (mass[i]>0) k++;
    }
return k;
}

Console.WriteLine("Введите количество чисел");
int m=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{positNumber(m)}");
