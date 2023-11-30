// Дано натуральное число в диапазоне от 1 до 100000.
// Создать массив, состоящий из числ зтого числа. 
// пример 543  [5, 4, 3]

System.Console.WriteLine("введите число от 1 до 100000  ");
int N = Convert.ToInt32(Console.ReadLine());

int size = 0;
int m1 = 0;
int m2 = 0;
int m3 = 0;
int m4 = 0;
int m5 = 0;

if (N<10)
{
    size = 1;
    m1 = N;

    int[] array = new int[size];
    array[0] = m1;
    
    System.Console.Write("["+ string.Join(", ",array)+"]");
}
else if (N>10 && N<100)
{
    size = 2;
    m1 = N % 10;
    m2 = N / 10;

     int[] array = new int[size];
    array[0] = m2;
    array[1] = m1;
    
    System.Console.Write("["+ string.Join(", ",array)+"]");
}
else if (N>100 && N<1000)
{
    size = 3;
    m1 = N % 10;
    m2 = (N / 10) % 10;
    m3 = N / 100;

    int[] array = new int[size];
    array[0] = m3;
    array[1] = m2;
    array[2] = m1;
   
    System.Console.Write("["+ string.Join(", ",array)+"]");
}
else if (N>1000 && N<10000)
{
    size = 4;
    m1 = N % 10;
    m2 = (N / 10) % 10;
    m3 = (N / 100) % 10;
    m4 = N / 1000;

    int[] array = new int[size];
array[0] = m4;
array[1] = m3;
array[2] = m2;
array[3] = m1;
System.Console.Write("["+ string.Join(", ",array)+"]");
}

else if (N>10000 && N<100000)
{
    size = 5;
    m1 = N % 10;
    m2 = (N / 10) % 10;
    m3 = (N / 100) % 10;
    m4 = (N / 1000) % 10;
    m5 = N / 10000;

    int[] array = new int[size];
    array[0] = m5;
    array[1] = m4;
    array[2] = m3;
    array[3] = m2;
    array[4] = m1;
    System.Console.Write("["+ string.Join(", ",array)+"]");
}

// Здравствуйте! Можно еще усовешенствовать, но нехватает времени.



