string myLogin = "my_name", myPass = "qwerty";

string message = "", messageYes = "Welcome!", messageNo = "access denied!";
Console.Write("Input your login: ");
string login = Console.ReadLine();

if (login.Length < 6)
{
    message = "Login is short...\n" + messageNo;
}
else if (login != myLogin)
{
    message = "Incorrect login\n" + messageNo; 
} 
else
{
    Console.Write("Input your password: ");
    string pass = Console.ReadLine();
    message = (pass == myPass) ? messageYes : "Incorrect password!\n" + messageNo;
}

Console.WriteLine(message);
Console.ReadKey();
