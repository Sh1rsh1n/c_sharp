/*
Возведение в степень
*/

int Exponentiation(int value, int exponent)
{
    if (exponent == 0) return 1;
    else if (exponent == 0 && value == 0) return 1;
    else return Exponentiation(value, exponent - 1) * value;
}

int result = Exponentiation(0, 0);
Console.WriteLine(result);