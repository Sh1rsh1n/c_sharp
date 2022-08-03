Console.WriteLine("input user name: ");
string username = Console.ReadLine();

if(username.ToLower() == "alex")
{
    Console.WriteLine("Hey, this is Alex");
}
else
{
    Console.Write("Hello, " + username);
}