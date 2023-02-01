Console.WriteLine("1) Задайте первую прямую y = k1 * x + b1");
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Задана первая прямая y = {k1} * x + {b1}");

Console.WriteLine();

Console.WriteLine("2) Задайте вторую прямую y = k2 * x + b2");
Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Задана вторая прямая y = {k2} * x + {b2}");

Console.WriteLine();

if (k1 == k2)
{
    if (b1 == b2) { Console.WriteLine("Ответ: заданы одинаковые прямые"); }
    else { Console.WriteLine("Ответ: прямые параллельны"); }
}
else
{
    Console.WriteLine($"вычтем (2) y = {k2} * x + {b2}  из (1) y = {k1} * x + {b1}:");
    double k3 = k1 - k2;
    double b3 = b1 - b2;
    Console.WriteLine($"0 = {k3} * x + {b3}");
    Console.WriteLine($"найдем значение х:");
    double x = -1 * b3 / k3;
    Console.WriteLine($"{x:f2}");
    Console.WriteLine($"найдем значение y подставив х в (2):");
    double y = k2 * x + b2;
    Console.WriteLine($"{y:f2}");
    Console.WriteLine($"Ответ: точка пересечения имеет координаты ( {x:f2} ; {y:f2} )");
}