//Лабораторная работа №3. Программирование циклических алгоритмов
//Табулирование функций
//Вариант #14  высокий уровень
try
{
    double x_start = 1.0;
    double x_end = 2.0;
    double step = 0.1;
    Console.WriteLine("\n{0,10} | {1,15}", "x", "f(x)");
    Console.WriteLine(new string('-', 30));
    int count = 0;
    for (double x = x_start; x <= x_end; x += step)
    {
        Console.WriteLine("{0,10:F2} | {1,15:F8}", x);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}