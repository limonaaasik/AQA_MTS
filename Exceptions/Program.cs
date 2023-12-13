﻿// See https://aka.ms/new-console-template for more information

using Exceptions;

// -====================== Ошибка ======================-
/*
int[] array = new int[3];
int value = array[5];
*/


// -====================== Исключение ======================-
/*
Object obj = null;  // нельзя взаимодействовать с null-объектом, поэтому получаем эксепшен
obj.GetHashCode();
*/


// -====================== Checked Exceptions (Контролируемые исключения) ======================-
CheckedExceptions checkedExceptions = new CheckedExceptions();
// Uncomment для формирования ошибки
// checkedExceptions.ReadFile("file.txt");

// -====================== Unchecked Exceptions (Неконтролируемое исключение) ======================-
UncheckedExceptions uncheckedExceptions = new UncheckedExceptions();
// Uncomment для формирования ошибки. Был метод, в котором установили, что второй параметр не должен быть 0, а мы передали 0.
// uncheckedExceptions.DivideNumbers(1, 0);

// -====================== Использования try -> catch -> finally ======================-
ExceptionUsage exceptionUsage = new ExceptionUsage();
//exceptionUsage.Template();
//exceptionUsage.ShortForm1();
//exceptionUsage.ShortForm2();
//exceptionUsage.ShortForm3();

//exceptionUsage.ManyCatch();

//exceptionUsage.FilterCatch(1, 0);
//exceptionUsage.FilterCatch(0, 1);

// -====================== Обработка исключений и условные конструкции ======================-
/*string? data = Console.ReadLine();

if (int.TryParse(data, out var x))
{
    Console.WriteLine($"x = {x}");
}
else
{
    Console.WriteLine("Некорректный ввод...");
}
*/

ThrowExceptions throwExceptions = new ThrowExceptions();
//throwExceptions.CheckUsername();
//throwExceptions.CheckUsername1();


// -====================== Собственные исключения ======================-
CustomExceptionUsage customExceptionUsage = new CustomExceptionUsage();
// customExceptionUsage.Run();
// customExceptionUsage.ProcessInput(" ");
customExceptionUsage.UseCustomArgumentException();