/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*
    SumNumbers() - принимает на вход два заначения, начальное и конечное
    используюем тернарный оператор для вычисления
    если start == end, то возвращаем start, иначе вызваем снова функцию и прибавляем к ней start.
    так происходит до тех пор пока start не будет равно end.
*/
int SumNumbers(int start, int end)
{
    return start == end ? end : SumNumbers(start + 1, end) + start;
}



Console.Write("Enter start number: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Enter last number: ");
int last = int.Parse(Console.ReadLine());

int result = SumNumbers(first, last);
Console.WriteLine(result);