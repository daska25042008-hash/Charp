using System;
enum ВидСчета
{
    Текущий,
    Сберегательный
}
class Program
{
    static void Main ()
    {
        ВидСчета счет;
        счет= ВидСчета.Сберегательный;
        Console.WriteLine("Вид банковского счета: "+ счет);
    }
}