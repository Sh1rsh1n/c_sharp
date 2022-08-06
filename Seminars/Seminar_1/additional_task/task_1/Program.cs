Random random = new Random();

int n = random.Next(-50, 50);

string message1 = (n >= 0) ? "possitive" : "negative";
string message2 = (n % 2 == 0) ? "even" : "odd";

Console.WriteLine("Numbers {0}, {1}, {2}", n, message1, message2);
Console.ReadKey();


string mess;

Console.WriteLine("Input day of week: Mon, Tue, Wen, Ths, Fri, Sat, Sun");
string day = Console.ReadLine();
switch(day)
{
    case "Sat" : mess = "Go to walking with my freinds"; break;
    case "Sun" : mess = "Relax"; break;
    default: mess = "Working"; break;
}

Console.WriteLine(mess);
Console.ReadKey();