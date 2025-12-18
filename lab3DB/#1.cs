//Лабораторная работа №3. Программирование циклических алгоритмов
//Операторы цикла с предусловием и постусловием
//Вариант #14  средний уровень
try
{
    Console.Write("Введите число m: ");
    int m = int.Parse(Console.ReadLine());

    int i = 100; 
    while (i <= 900) 
    {
        int res = i / m;           
        Console.WriteLine($"{i} / {m} = {res}");
        i += 200;
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}