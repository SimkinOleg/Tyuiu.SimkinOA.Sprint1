using Tyuiu.SimkinOA.Sprint1.Task7.V17.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Симкин О. А. | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #17                                                             *");
Console.WriteLine("* Выполнил: Симкин О. А. | РППб-25-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет выражение                         *");
Console.WriteLine("*по исходным значениям данных                                             *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

double x, y;
Console.WriteLine("Введите число x: ");
x = double.Parse(Console.ReadLine());

Console.WriteLine("Введите число y: ");
y = double.Parse(Console.ReadLine());


double result = ds.Calculate(x,y);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(result);