Console.WriteLine("Input number from 0 to 5: ");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 0: Console.WriteLine("zero"); break;
    case 1: Console.WriteLine("one"); break;
    case 2: Console.WriteLine("two"); break; 
    case 3: Console.WriteLine("three"); break; 
    case 4: Console.WriteLine("four"); break; 
    case 5: Console.WriteLine("five"); break;
    default: Console.WriteLine("incorrect number"); break;
}