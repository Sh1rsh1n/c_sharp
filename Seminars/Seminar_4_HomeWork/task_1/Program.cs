/*
Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную 
степень B
*/

/*
метод возведение в степерь, принимает на взод два числа, 
где number - число, а exp - степень, в которую его нужно возвести
если значение степени меньше 0, то наш метод выбросит исключение
*/
int Exponentiation(int number, int exp)
{
    if(exp < 0) throw new ArgumentException("incorrect exponent value"); 

    int result = 1; //переменная для хранения произведения чисел
    for (int i = exp; i > 0; i--) //пойдем немного нестандартно, присвоим пересенной i значение exp, и выполняем цикл пока i > 0  
    {
        result *= number; //перемножаем переменные number и result на каждой итерации
    }
    return result;
}

/*
вызываем метод Exponentiation() и присваеваем результат его выполнения переменной value
*/
int value = Exponentiation(10, 3);
Console.WriteLine($"Exponentiation = {value}");