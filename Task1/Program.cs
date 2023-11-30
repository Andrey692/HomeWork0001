
// Задайте одномерный массив из 10-ти целых чисел от 1 до 100.
// Найти колличество элементов массива, значения которых
// лежат в отрезке [20,90]

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index<length)
    {
        collection[index] = new Random().Next(1,100); 
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
    int scor = 0;   // подсчет попадающих элементов

    while (index<count)
    {
        if (collection[index] > 20 && collection[index] < 90)
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
System.Console.Write(pos);
