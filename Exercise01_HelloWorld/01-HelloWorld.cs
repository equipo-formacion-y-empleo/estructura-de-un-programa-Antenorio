string ShowMessage(string name)
{
    return name;
}
Console.WriteLine(ShowMessage(args.Length > 0 ? args[0] : "Nombre1"));
Console.WriteLine(ShowMessage(args.Length > 1 ? args[1] : "Nombre2"));
Console.WriteLine(ShowMessage(args.Length > 2 ? args[2] : "Nombre3"));