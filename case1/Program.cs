/* int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
} */

int[] GetCoor (string message)
{
    int[] coordinates = new int[2];
    Console.WriteLine(message + "X:");
    coordinates[0] = int.Parse(Console.ReadLine()!);
    Console.WriteLine(message + "Y:");
    coordinates[1] = int.Parse(Console.ReadLine()!);

    return coordinates;
}

/* string GetQuater(int axisX, int axisY)
{
    string answer = "";
    if (axisX > 0 && axisY > 0)
        answer = "1 четверть";
    else if (axisX < 0 && axisY > 0)
        answer = "2 четверть";
    else if (axisX < 0 && axisY < 0)
        answer = "3 четверть";
    else if (axisX > 0 && axisY < 0)
        answer = "4 четверть";
    else 
        answer = "Точка находится на границе четверти";

    return answer;
} */

/* void GetQuater(int axisX, int axisY)
{
    if (axisX > 0 && axisY > 0)
        Console.WriteLine("1 четверть");
    else if (axisX < 0 && axisY > 0)
        Console.WriteLine("2 четверть");
    else if (axisX < 0 && axisY < 0)
        Console.WriteLine("3 четверть");
    else if (axisX > 0 && axisY < 0)
        Console.WriteLine("4 четверть");
    else 
        Console.WriteLine("Точка находится на границе четверти");
} */

void GetQuater(int[] coor)
{
    if (coor[0] > 0 && coor[1] > 0)
        Console.WriteLine("1 четверть");
    else if (coor[0] < 0 && coor[1] > 0)
        Console.WriteLine("2 четверть");
    else if (coor[0] < 0 && coor[1] < 0)
        Console.WriteLine("3 четверть");
    else if (coor[0] > 0 && coor[1] < 0)
        Console.WriteLine("4 четверть");
    else 
        Console.WriteLine("Точка находится на границе четверти");
}
int[] coors = GetCoor("Введите значение координаты ");

/* int coorX = InputNum("Введите значение координаты X: ");
int coorY = InputNum("Введите значение координаты Y: "); */
/* string result = GetQuater(coorX, coorY);
Console.WriteLine(result); */
// GetQuater(coorX, coorY);
GetQuater(coors);