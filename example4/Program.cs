// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N



// Console.WriteLine("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine());
// int i = 1;

// while (i <= n)
// {
//     Console.WriteLine($"{i,5}-> {i*i,5}");
//     i= i+1;
// }


void WriteTableSquare (int number)
{
    int i = 1;
    while (i <= number)
    {
        Console.WriteLine($"{i,5}-> {i*i,5}");
        i= i+1;
    }
}
Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());

WriteTableSquare (n);