var contatore = 0;

while (true)
{
    var tasto = Console.ReadKey();
    if (tasto.Key == ConsoleKey.A)
    {
        contatore++;
    }
    else if (tasto.Key == ConsoleKey.Enter)
    {
        break;
    }
        



}

Console.WriteLine($"hai digitato A ben {contatore}");
Console.ReadKey();
