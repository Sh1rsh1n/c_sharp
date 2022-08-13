/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

/*
    Вводим с консоли пятизначное число
*/
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());


/*
    Передаем методу isFiveDigit значение number, введеное с консоли и выполняем проверку
    если метод isFiveDigit вернет true, передаем методу findPalindrom значение number, получаем результат
    если метод isFiveDigit вернет false, выводим на консоль сообщение: "Incorrect value"
*/
if(isFiveDigit(number))
{
    findPalindrom(number);
}
else
{
    Console.WriteLine("Incorrect value");
}

/*
    метод isFiveDigit на вход принимает значение типа int
    выполняет проверку, что число находится в диапозоне от 10000 до 99999
    и на выходе выдает значение типа bool (true/false).
*/
bool isFiveDigit(int num)
{
    if (num >= 10_000 && num <= 99_999)
    {
        Console.WriteLine("OK");
        return true;
    }
    return false;
}

/*
    метод findPalindrom на вход принимает значение типа int
    ничего не возвращает(void)
    выполняет расчеты и сразу выводим результат в консоль.
*/
void findPalindrom(int num)
{
    if (num / 10000 == num % 10) //проверяем равенство первого и последнего числа
    {
        int cutNum = num % 10000 / 10; //отсекаем от 5-значного числа 1ую и 5ую цифры

        if (cutNum / 100 == cutNum % 10) //проверяем полученное 3-значное число сравнивая первое и последнее число
        {
            Console.WriteLine("This number is palindrom.");
        }
        else
        {
            Console.WriteLine("Isn't palindrom");
        }
    }
    else
    {
        Console.WriteLine("Isn't palindrom");
    }
}