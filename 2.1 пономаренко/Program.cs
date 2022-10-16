Console.Write("Введите X: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите Y: ");
double y = double.Parse(Console.ReadLine());
if (x >= 0 && y >= 0)  Console.WriteLine("Первая четверть");
else if (x <= 0 && y >= 0) Console.WriteLine("Вторая четверть");
else if (x <= 0 && y <= 0) Console.WriteLine("Третья четверть");
else if (x >= 0 && y <= 0) Console.WriteLine("Четвертая четверть");
