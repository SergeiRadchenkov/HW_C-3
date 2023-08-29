/* int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
} */

/* double num = 1.438736;
num = Math.Round(num, 3);
Console.WriteLine(num); */

// Math.Pow() Math.Sqrt() Math.Round()

int[] GetCoor (string message)
{
    int[] coordinates = new int[2];
    Console.Write(message + "X:");
    coordinates[0] = int.Parse(Console.ReadLine()!);
    Console.Write(message + "Y:");
    coordinates[1] = int.Parse(Console.ReadLine()!);

    return coordinates;
}

double Distance(int[] pointA, int[] pointB)
{
    int deltaX = pointA[0] - pointB[0];
    int deltaY = pointA[1] - pointB[1];
    double dist = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
    return dist;
}

int[] pointA = GetCoor("Введите для точки А координату ");
int[] pointB = GetCoor("Введите для точки B координату ");
double result = Distance(pointA, pointB);
result = Math.Round(result, 3);
Console.WriteLine(result);