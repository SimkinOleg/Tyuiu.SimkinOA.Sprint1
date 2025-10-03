using Tyuiu.SimkinOA.Sprint1.Task6.V14.Lib;


DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Симкин О. А. | РППб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #14                                                             *");
Console.WriteLine("* Выполнил: Симкин О. А. | РППб-25-1                                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая проверяет что строка                        *");
Console.WriteLine("*составлена только из русских букв                                        *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
Console.WriteLine("***************************************************************************");

string stroka;
Console.WriteLine("Введите стоку: ");
stroka = Console.ReadLine();


bool result = ds.CheckLowerCaseRusLetters(stroka);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(result);