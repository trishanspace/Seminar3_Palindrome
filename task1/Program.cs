/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int num = InputInt();

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
// //определение длины числа
// int LengthNumber(int num)
// {
//     if (num == 0)
//         return 1;

//     int result = 0;

//     while (num > 0)
//     {
//         num = num / 10;
//         result++;
//     }

//     return result;
// }
//создание массива
//переворот массива

//int ArrayReverse = num;
{
    int[] array = new int[num];
    array.Reverse();
}
//сравниваем

if (num == )
{
    Console.WriteLine("Это число является палиндромом");
}
else
{
    Console.WriteLine("Это число не является палиндромом");
}




//int GetPalindrome()





// получаем длину числа
//int GetLengthNum;
// {
//     int GetLengthNum(int num)
//     {
//     return (num == 0) ? 1 : (int)Math.Log10(Math.Abs(num)) + 1;
//     }    
// }





//получение массива
//int[] GetNum = new int[];//{количество чисел};  




// int num.Length (int num);

// for (i = 0; num > 0; i++; num /= 10)
// {
//     return num.Length;
// }

// int[] PalNum (int num)
// {
//     int[] array = new int[num]; // обозначение массива

//     if (num.Length)
//     {
//         void Reverse(Array num, int 0, int num.Length);
//     }
//     return PalNum;
// }


// if (num == GetPal)
// {
//     Console.WriteLine("Это число является палиндромом");
// }
// else
// {
//     Console.WriteLine("Это число не является палиндромом");
// }


