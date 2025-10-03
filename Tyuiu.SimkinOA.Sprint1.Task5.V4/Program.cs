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

int number;
Console.WriteLine("Введите количество секунд : ");
number = int.Parse(Console.ReadLine());



int result = ds.SecondsToHours(number);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(result);