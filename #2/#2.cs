//Лабораторная работа №3. Программирование циклических алгоритмов
//Оператор цикла for
//Вариант #14  средний уровень
try
{
    Console.Write("Введите число x: ");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите число n: ");
    double n = double.Parse(Console.ReadLine());
    double S = 0;
    for (int k = 3; k <= n; k++)
    {
        double sum = Math.Pow(-2, k - 1) / Math.Pow(k - 5, k);
        double mul = 1;
        for (int i = 1; i <= k + 7; i++)
        {
            if (i == 7)
            {
                mul *= 316;
            }
            else
            {
                mul *= (Math.Pow(i, 3) - 27) / (i - 7);
            }
        }
        S += sum * mul;
    }
    Console.WriteLine($"S = {S}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}