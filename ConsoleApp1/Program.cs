using ConsoleApp1;

MyPoint p1 = new MyPoint(1, 1);
MyPoint p2 = new MyPoint(2, 2);
MyPoint p3 = new MyPoint(2, 5);
Console.WriteLine($"p1 = {p1}");
Console.WriteLine($"p2 = {p2}");
Console.WriteLine($"p3 = {p3}");
Console.WriteLine($"p1 - 1 = {p1 - 1}");
Console.WriteLine($"1 - p2 = {1 - p2}");
Console.WriteLine($"-p3 = {-p3}");
Console.WriteLine($"--p3 = {--p3}");

int asize = 4;
PointArray p1a = new PointArray(asize);
for (int i = 0; i<p1a.Lenght; i++)
{
    Console.WriteLine($"p1a[{i}] = {p1a[i]}");
}
Console.WriteLine($"p1a.Min() = {p1a.Min()}");
Console.WriteLine($"points count = {MyPoint.Size}");
MyPoint[] p2atmp = new MyPoint[asize];
for (int i = 0; i < p2atmp.Length; i++)
{
    Console.WriteLine($"Введите координаты для Точки № {i}");
    Console.Write("Координата X: ");
    double x = Double.Parse(Console.ReadLine());
    Console.Write("Координата Y: ");
    double y = Double.Parse(Console.ReadLine());
    p2atmp[i] = new MyPoint(x, y);
}
PointArray p2a = new PointArray(p2atmp, asize);
for (int i = 0; i < p2a.Lenght; i++)
{
    Console.WriteLine($"p2a[{i}] = {p2a[i]}");
}
Console.WriteLine($"p2a.Min() = {p2a.Min()}");
Console.WriteLine($"points count = {MyPoint.Size}");