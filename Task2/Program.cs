// задайте массив на 10 целых чисел.
// Определить колличество четных чисел в массиве.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index] = new Random().Next(1,10); 
        index++;
    }
}

void PrintArray(int[] collection)
{
            System.Console.Write("["+ string.Join(", ",collection)+"] " + "=> ");

}


int  IndexOf(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    int scor = 0;   // подсчет четных элементов

    while (index<count)
    {
        if (collection[index] % 2 == 0)
        {
            scor = scor + 1;
        }
        index++;
    }
    return scor;
}

int[] array = new int[10];  // создаем новый массив в котором 10 элементов

FillArray(array);  // вызов функции заполнения

PrintArray(array); // вызов функции вывода


int pos = IndexOf(array);
System.Console.WriteLine(pos);
