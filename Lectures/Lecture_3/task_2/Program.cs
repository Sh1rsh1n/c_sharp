string text = "Эгил Левитс назвал действующую политику выдачи видов на жительство и виз «неоправданной щедростью» и заявил, что предыдущие правительства «создали риски безопасности и способствовали двуязычию».";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;

    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'а', 'А');
Console.WriteLine(newText);