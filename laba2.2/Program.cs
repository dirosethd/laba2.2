try
{
    Console.WriteLine("Введите a:");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите b:");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите c:");
    int c = int.Parse(Console.ReadLine());

    if ((a == b) || (a == c) || (b == c)) Console.WriteLine("Треугольник р/б");
    else Console.WriteLine("Треугольник не р/б");
}
catch
{
    Console.WriteLine("Введите правильно");
}

