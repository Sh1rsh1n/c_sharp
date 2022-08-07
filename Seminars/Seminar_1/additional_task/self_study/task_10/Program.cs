bool accessLogin;
bool accessPass;
string login;
string pass;

do
{
    Console.WriteLine("Input your login: ");
    login = Console.ReadLine();
    accessLogin = login.Length != 5;
}
while (accessLogin);

do
{
    Console.WriteLine("Input your password: ");
    pass = Console.ReadLine();
    accessPass = pass.Length < 6;
}
while(accessPass);

Console.Write("Congratulation! Registration success!");