int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
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

void GetQuater(int axisX, int axisY)
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
}

int coorX = InputNum("Введите значение координаты X: ");
int coorY = InputNum("Введите значение координаты Y: ");
/* string result = GetQuater(coorX, coorY);
Console.WriteLine(result); */
GetQuater(coorX, coorY);