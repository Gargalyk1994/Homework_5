/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/


double[] GetArray(int size, int minValue, int maxValue)// Кирилл подскажите: не могу эти переменые поставить в тип double. Почему?
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

double GetDiff (double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    double result = max - min;
    return result;
}
Console.Clear();

double[] startArray = GetArray(12, 1, 99);
Console.WriteLine($"[{String.Join(", ", startArray)}]");
Console.WriteLine($"Difference max and min: {GetDiff(startArray)}");
