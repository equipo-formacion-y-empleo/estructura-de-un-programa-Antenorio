double DemoImplicitConversions()
{
    int intergerNumber = 42;
    double result = intergerNumber + 0.5;

   

int DemoExplicitConversions()
{
    double decimalNumber = 15.87;
    int result = (int)decimalNumber;
}


decimal originalValue = decimal.Parse(args.Length > 0 ? args[0] : "23.89");
int targetInt = int.Parse(args.Length > 1 ? args[1] : "17");

Console.WriteLine($"Conversión explícita a int: {DemoExplicitConversions()}");
Console.WriteLine($"Conversión implícita a double: {DemoImplicitConversions()}");
