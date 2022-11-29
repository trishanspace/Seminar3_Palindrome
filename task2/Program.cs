// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double InputInt()
{
    Console.WriteLine("Введите число");
    bool number = double.TryParse(Console.ReadLine(), out double num);

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
double ax = InputInt();
double ay = InputInt();
double az = InputInt();
double bx = InputInt();
double by = InputInt();
double bz = InputInt();

double GetDistance (double ax, double ay, double az, double bx,  double by,  double bz)
{
    double AB = Math.Sqrt ((bx - ax)*(bx - ax) + (by - ay)*(by - ay) + (bz - az)*(bz - az)); //MS - извл кв корень
    return AB;
}
double result = GetDistance(ax,ay,az,bx,by,bz);
Console.WriteLine(result);