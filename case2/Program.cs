int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void Diapozon(int quater)
{
    if (quater == 1)
        Console.WriteLine("X > 0, Y > 0");
    else if (quater == 2)
        Console.WriteLine("X < 0, Y > 0");
    else if (quater == 3)
        Console.WriteLine("X < 0, Y < 0");
    else if (quater == 4)
        Console.WriteLine("X > 0, Y < 0");
    else 
        Console.WriteLine("Такой четверти не существует");
}

int quater = InputNum("Введите номер четверти");
Diapozon(quater);