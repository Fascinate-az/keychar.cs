var contatore = 0;
string input = "";

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


    input += tasto.KeyChar;

}

Console.WriteLine($"hai digitato A ben {contatore} volte \n le lettere digitate sono {input}");
Console.ReadKey();
