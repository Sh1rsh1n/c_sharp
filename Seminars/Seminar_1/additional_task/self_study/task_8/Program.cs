Console.WriteLine("Input country: ");

string nameCity = Console.ReadLine();

switch(nameCity)
{
    case "Minsk": 
    case "Brest": 
    case "Vitebsk": Console.WriteLine("Belarus"); break;
    case "Smolensk":
    case "Moscow":
    case "Kazan":
    case "Kursk": Console.WriteLine("Russia"); break;
    case "Berlin":
    case "Bonn":
    case "Hamburg":
    case "Munchen": Console.WriteLine("Germany"); break;
    default: Console.WriteLine("incorrect name of the city"); break;    
}
