string input = "";
while (true)
{
    var tasto = Console.ReadKey();
    if (tasto.Key == ConsoleKey.Enter) 
    {
       
        break;
    }
    input += tasto.KeyChar;
}
Console.WriteLine($"i tasti digitati sono {input}");
Console.ReadKey();
