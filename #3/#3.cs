//Лабораторная работа №3. Программирование циклических алгоритмов
//Вычисление бесконечных сумм
//Вариант #14  
try
{
    Console.Write("Введите число x: ");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Максимальное число итераций: ");
    int maxIterations = int.Parse(Console.ReadLine());
    double sum = 0;
    double previousSum;
    int k = 1;
    do
    {
        double term = Math.Pow(-1, k) * Math.Cos(k * x) / (k * k);
        previousSum = sum;
        sum += term;
        k++;
    }
    while (k <= maxIterations);
    Console.WriteLine($"Вычисленная сумма: {sum:F10}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}