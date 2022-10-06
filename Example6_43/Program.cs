using static System.Console;
Clear();
WriteLine("Найдем точку пересечения двух прямых");
WriteLine("Первая прямая задана уравнением y=k1*x+b1");
WriteLine("Вторая прямая задана уравнением y=k2*x+b2");
WriteLine("Введите значения k1");
double k1 = Convert.ToDouble(ReadLine());
WriteLine("Введите значения b1");
double b1 = Convert.ToDouble(ReadLine());
WriteLine("Введите значения k2");
double k2 = Convert.ToDouble(ReadLine());
WriteLine("Введите значения b2");
double b2 = Convert.ToDouble(ReadLine());
GetIntersectionPoint(k1, b1, k2, b2);





void GetIntersectionPoint(double k1, double b1, double k2, double b2)
{
    if (k1 == k2) { WriteLine("Прямые не пересекаются"); }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k2 * x + b2;
        WriteLine($"Пересечение двух прямых является точка с координатами x={x} y={y}");
    }
}