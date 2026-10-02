using System;
enum ВУЗ
{
    КГУ,
    КАИ,
    КХТИ
}
struct Работник
{
    public string Имя;
    public ВУЗ Вуз;
}
class Program
{
    static void Main()
    {
        Работник человек;
        человек.Имя="Даша";
        человек.Вуз=ВУЗ.КГУ;
        Console.WriteLine("Имя: "+человек.Имя);
        Console.WriteLine("ВУЗ: "+человек.Вуз);
    }
}