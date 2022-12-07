// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Введите число, которое нужно возвести в степень:");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите натуральное число равное степени, в которую нужно возвести:");
int b = Convert.ToInt32(Console.ReadLine());
if (b>0)
{
    Console.WriteLine($"{a} в степени {b} равно {Stepen(a,b)}.");
}
else
{
    Console.WriteLine($"{b} - не натуральное число.");
}
double Stepen(double a, int b)
{
    double st = 1;
    for (int i=0; i<b; i++)
    {
        st=st*a;
    }
    return st;
}