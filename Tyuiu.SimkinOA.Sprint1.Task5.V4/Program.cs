using Tyuiu.SimkinOA.Sprint1.Task5.V4.Lib;


DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Симкин О. А. | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнил: Симкин О. А. | РППб-25-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет значение по                       *");
Console.WriteLine("* формуле и печатает его на экране                                        *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

double number, b;
Console.WriteLine("Введите количество секунд : ");
number = double.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
b = double.Parse(Console.ReadLine());

double result = ds.Calculate(number,b);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(result);