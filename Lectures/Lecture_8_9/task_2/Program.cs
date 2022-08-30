/*
Factorial
*/

int Factorial(int value)
{
    if (value == 0 || value == 1) return 1;
    else return value * Factorial(value - 1);
}

int result = Factorial(3); 
Console.WriteLine(result);