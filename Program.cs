//----------------------------------------------------------DZ6--------------------------------------------------------------------------

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*

void EvenCount(int M)
{
    int count = 0;
    Console.WriteLine("Введите числа: ");
    for(int num = 0; num < M; num++)
    {
        int current = Convert.ToInt32(Console.ReadLine());
        if(current > 0)
           count++;
    }
    Console.WriteLine($"Общее количество чисел больше нуля: {count}");
}
Console.Write("Введите количество элементов: ");
int M = Convert.ToInt32(Console.ReadLine());
EvenCount(M);

*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void intersections (double k1, double k2, double b1, double b2)
{
    double x = (b2 - b1) / (k1 - k2); 
    double y = k2 * (b2 - b1) / (k1 - k2) + b2;
    if(k1 / k2 == b1 / b2)
        Console.WriteLine("the lines coincide.");
    else 
        if(k1 == k2)
            Console.WriteLine("No points of intersection of lines.");
        else
            Console.WriteLine($"Point of intersection of lines with coordinates: ({Math.Round(x, 2)}, {Math.Round(y, 2)})");
    
}
Console.Write("Input the element equation K1; ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the element equation K2; ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the element equation B1; ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the element equation B2; ");
double b2 = Convert.ToInt32(Console.ReadLine());
intersections(k1, k2, b1, b2);
