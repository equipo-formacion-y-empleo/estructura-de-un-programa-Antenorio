using System.Runtime.InteropServices;
using System.Security.Cryptography;

void DemoBasicDataTypes()
{
    int age = 25;
    double price = 19.99;
    char initial = 'A';
    bool available = true;

}

void ShowDataTypeSizes()
{
    Console.WriteLine("age = " + age + "(size: " + sizeof(int)+ ")");
}   Console.WriteLine("price = "+ price + " (size: "+ sizeof(double)+ ")");
    Console.WriteLine("initial = "+ initial + " (size: "+ sizeof(char) + ")");
    Console.WriteLine("available = "+ available + "(size: "+ sizeof(bool) + ")");

DemoBasicDataTypes();
ShowDataTypeSizes();
