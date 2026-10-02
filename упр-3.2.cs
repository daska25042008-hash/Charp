using System;
struct Банк
{
    public string Номер;
    public string Тип;
    public double Баланс;
}
class Program
{
    static void Main()
    { Банк счет;
    счет.Номер="203845657";
    счет.Тип="Сберегательный";
    счет.Баланс=878;
    Console.WriteLine("Номер счета: "+счет.Номер);
    Console.WriteLine("Тип счета: "+счет.Тип);
    Console.WriteLine("Баланс: "+счет.Баланс);
    }
}