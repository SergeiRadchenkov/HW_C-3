int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void Squares(int num)
{
    for (int i = 1; i <= num; i++)
    {
        int res = (int)Math.Pow(i, 2);
        Console.Write(res);
        if (i != num) Console.Write(", ");
    }
}

int number = InputNum("Введите число: ");
Squares(number);