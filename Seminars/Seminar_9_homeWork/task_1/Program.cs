/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""
*/

/*
ShowNumbers() - метод принимает на вход начальное и конечное значение, решение с помощью рекурсии
проверяет, если числа равны, то возвращает начальное значение
инчае выводит в консоль начальное значение 
далее снова вызывает сам себя(рекурсия) и действия выше повотряются снова
и так будет повотряться до тех пор пока значение start не будет равно значению end
*/
int ShowNumbers(int start, int end)
{
    if(start == end) return start;
    Console.Write($"{start} ");
    return ShowNumbers(start + 1, end);
}


Console.Write("Enter start number: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Enter last number: ");
int last = int.Parse(Console.ReadLine());

Console.WriteLine(ShowNumbers(first, last));
