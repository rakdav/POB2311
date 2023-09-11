//4.1
//Console.Write("Введите x:");
//double x=double.Parse(Console.ReadLine());

//double y=(x>0)?Math.Sin(x)*Math.Sin(x):
//    1-2*Math.Sin(x*x);
//Console.WriteLine($"y={y:F2}");
//4.3
//Console.Write("Введите x:");
//double x=double.Parse(Console.ReadLine());
//Console.WriteLine(x<4?"1 область":"2 область");

//{
//    int a = 6;
//    Console.WriteLine(a);
//}
//Console.WriteLine(a);

//4.13
//Console.Write("Введите a:");
//double a=double.Parse(Console.ReadLine());
//Console.Write("Введите b:");
//double b = double.Parse(Console.ReadLine());
//Console.Write("Введите c:");
//double c = double.Parse(Console.ReadLine());
//double d = b * b - 4 * a * c;
//if(d>0)
//{
//    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
//    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
//    Console.WriteLine($"x1={x1:F2} x2={x2:F2}");
//}
//else if(d==0)
//{
//    double x = -b / 2 * a;
//    Console.WriteLine($"{x:F2}");
//}
//else Console.WriteLine("Корней нет");

//4.6
//Console.Write("Введите a:");
//double a=double.Parse(Console.ReadLine());
//Console.Write("Введите b:");
//double b = double.Parse(Console.ReadLine());
//if (a > b) Console.WriteLine($"{a}>{b}");
//else if (a < b) Console.WriteLine($"{a}<{b}");
//else Console.WriteLine($"{a}={b}");

//4.20
//Console.Write("Введите m:");
//int m=int.Parse(Console.ReadLine());
//Console.Write("Введите n:");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine((m%n==0)?m/n:
//    $"{m} на {n} нацело не делится");

byte a = byte.Parse(Console.ReadLine());
Console.WriteLine(a);
uint b = (uint)a;
Console.WriteLine(b);

//nnn