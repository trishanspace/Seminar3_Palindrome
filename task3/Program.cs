// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int num = InputInt();
int[] CubeTable = GetCube(num);
PrintArray(CubeTable);

int InputInt()
{
    Console.WriteLine("Введите целое число");
    bool number = int.TryParse(Console.ReadLine(), out int num);

    if (number)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}

int[] GetCube(int num)
{
    int[] array = new int[num]; // обозначение массива
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (int)(Math.Pow(i + 1, 3));
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}