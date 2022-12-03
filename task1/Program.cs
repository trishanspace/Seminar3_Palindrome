/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int num = InputInt();
int len = LengthNumber();


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

{
    int LengthNumber = (num == 0) ? 1 : (int)Math.Log10(Math.Abs(num)) + 1;
}

{
    int n = num;
    int reverse = 0;
    while (len)
    {
        int i = n % 10;
        reverse = reverse * 10 + i;
        n = n / 10;
    }
}

{
    if (reverse == num)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}