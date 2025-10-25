//Лабораторная работа №3. Программирование циклических алгоритмов
//Оператор цикла for
//Вариант #14  средний уровень
try
{
    Console.Write("Введите число x: ");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите число n: ");
    double n = double.Parse(Console.ReadLine());
    double k = 3;
    double i = 1;
    double S = ((n + k) * (Math.Pow(-2, k - 1) / ((k - 5) * (Math.Pow(x, k)))) * ((k + 7) * i) * ((Math.Pow(i, 3) - 27) / (i - 7)));
    Console.WriteLine($"S={S}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}