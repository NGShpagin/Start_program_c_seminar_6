// Задача 1. Домашнее задание
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


void CountPosNum()
{
    int i = 0;
    string number = "";
    while (number != "q")
    {
        Console.WriteLine("Enter 'q' to stop");
        Console.Write("Enter any number: ");
        int num = int.Parse(Console.ReadLine());
        if (num > 0) i++;
        Console.WriteLine($"You entered {i} positive numbers");
    }
}

CountPosNum();