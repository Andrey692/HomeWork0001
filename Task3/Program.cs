// задайте массив из вещественных чисел с ненулевой дробной частью,
// найдите разницу между максимальным и минимальным элементом массива.

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int size = ReadInt("введите размер массива");

double[] array = new double[size];
Random rand = new Random();
for (int i = 0; i < size; i++)
{
    array[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 2);
}

double  numMax(double[] collection)
{
    int count = collection.Length;
    int index = 0;
    double max = 0;

    while (index<count)
    {
        if (collection[index] > max)
        {
            max = collection[index];
        }
        index++;
    }
    return max;
}

double  numMin(double[] collection)
{
    int count = collection.Length;
    int index = 0;
    double min = 100000;

    while (index<count)
    {
        if (collection[index] < min)
        {
            min = collection[index];
        }
        index++;
    }
    return min;
}



double Max = numMax(array);
double Min = numMin(array);
double diff = Math.Round(Max - Min, 2);

System.Console.WriteLine("["+ string.Join(", ",array)+"]");

System.Console.WriteLine("max = " + Max);
System.Console.WriteLine("min = " + Min);
System.Console.WriteLine( "diff = " + diff);