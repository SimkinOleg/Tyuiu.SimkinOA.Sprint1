using Tyuiu.SimkinOA.Sprint1.Task3.V3.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Симкин О. А. | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #3                                                              *");
Console.WriteLine("* Выполнил: Симкин О. А. | РППб-25-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, вычисляет объём параллелепипеда и                   *");
Console.WriteLine("* печатает  результат на экране.                                          *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

double length, width, height;

Console.WriteLine("Введите длину: ");
length = double.Parse(Console.ReadLine());

Console.WriteLine("Введите ширину: ");
width = double.Parse(Console.ReadLine());

Console.WriteLine("Введите высоту: ");
height = double.Parse(Console.ReadLine());

double result = ds.ParallelepipedVolume(length, width, height);



Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(result);