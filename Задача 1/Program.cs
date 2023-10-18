// See https://aka.ms/new-console-template for more information
using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже
        if (firstNumber<secondNumber)
        {
            Console.Write($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
        }
        else if (firstNumber==secondNumber)
        {
            Console.Write($"Введенные числа равны `{firstNumber}`");
        }
        else
        {
            Console.Write($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
        }
    }


  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 6;
            secondNumber = 5;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}
