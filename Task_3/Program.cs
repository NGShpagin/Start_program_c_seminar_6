// Задача 2. Решение в группах задач
//Напишите программу, которая будет преобразовывать десятичное число в двоичное.

void Decimal(int num)
{
    string i = "";
    while (num > 1)
    {
        i = num % 2 + i;
        num = num / 2;
    }
Console.WriteLine(i);
}

Decimal(47);