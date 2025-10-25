//Лабораторная работа №3. Программирование циклических алгоритмов
//Операторы цикла с предусловием и постусловием
//Вариант #14  средний уровень
try
{
    Console.Write("Введите число m: ");
    int m = int.Parse(Console.ReadLine());
    for (int i = 100; i <= 900; i += 200)
    {
        int res = i / m;
        int rem = i % m;
        Console.WriteLine($"{i} / {m} = {res} (остаток: {rem})");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}