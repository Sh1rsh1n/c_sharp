Console.WriteLine("input first word");
char firstWord = Convert.ToChar(Console.ReadLine());

switch(firstWord)
{
    case 'f': Console.WriteLine("fisika"); break;
    case 'm': Console.WriteLine("mathimatic"); break;
    case 'h': Console.WriteLine("history"); break;
    case 'g': Console.WriteLine("geografy"); break;
    case 'b': Console.WriteLine("biology"); break;
    default: Console.WriteLine("incorrect word"); break;
}