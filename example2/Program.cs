// //   Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).



string QuarterRange(int quarter)
{
    if (quarter == 1) return "x > 0; y > 0";
    if (quarter == 2) return "x < 0; y > 0";
    if (quarter == 3) return "x < 0; y < 0";
    if (quarter == 4) return "x > 0; y < 0";
    return null;
}

Console.WriteLine ("Введите номер четверти:");
int number = Convert.ToInt32(Console.ReadLine());

string result= QuarterRange(number);

Console.WriteLine (result != null ? result : "Некорректный ввод");
