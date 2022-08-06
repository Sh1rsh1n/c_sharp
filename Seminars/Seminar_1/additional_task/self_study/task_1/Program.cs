int n = new Random().Next(20, 99);
Console.WriteLine("Введите людое число от 1 до 99: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n);

string message = (n % d == 0) ? " делится " : " не делится ";

Console.WriteLine("число " + d + message + "на число " + n + " без остатка");