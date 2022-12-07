// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("Вы хотите задать массив из 8 элементов сами с клавиатуры (вариант 1) или получить случайный массив (вариант 2)? Введите 1 или 2:");
int v = Convert.ToInt32(Console.ReadLine());
int[] array = new int[8];

void Mass(int[] arr)
{
    for (int i=0; i<8; i++)
    {
        Console.WriteLine($"Введите значение {i+1} элемента массива:");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void Mass_Ran(int max, int min, int[] arr)
{
    for (int i=0; i<8; i++)
    {
        arr[i] = new Random().Next(min,max+1);
    }
}

void PtintArray(int[] arr)
{
    Console.Write("Вывод массива из 8 элементов:[");
    for (int i = 0; i < 8; i++)
    {
        if (i == 7)
        {
            Console.WriteLine($"{arr[i]}]");
        }
        else
        {
            Console.Write($"{arr[i]},");
        }
    }
    
}

if (v<3 && v>0)
{
    if (v == 1)
    {
        Mass(array);
        PtintArray(array);
    }
    else
    {
        Console.WriteLine("Введите минимальное значение, которое может принимать элемент массива:");
        int min = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите максимальное значение, которое может принимать элемент массива:");
        int max = Convert.ToInt32(Console.ReadLine());
        Mass_Ran(max,min,array);
        PtintArray(array);
    }
}
else
{
    Console.WriteLine("Такого варианта ввода массива - нет.");
}
