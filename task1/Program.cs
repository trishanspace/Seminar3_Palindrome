/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int num = InputInt();
int[] array = GetArray();
int Reverse = GetReverse();

int InputInt()
{
    Console.WriteLine("Введите число");
    bool number = int.TryParse(Console.ReadLine(), out int num);

    if (number)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное число");
        return -1;
    }
}

int[] GetArray()
{
    int[] array = new int[num];
    return array;
}

int GetReverse()
{
    int n = num;
    int reverse = 0;
    while (reverse < array.Length)
    {
        int i = n % 10;
        reverse = reverse * 10 + i;
        n = n / 10;
    }
    return reverse;
}

{
    if (Reverse == num)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}