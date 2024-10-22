
Console.WriteLine("Введите число x в q1-тичной системе счисления: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите систему счисления q1 в отрезке [2;10]: ");
int q1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите систему счисления q2 в отрезке [2;10]: ");
int q2 = int.Parse(Console.ReadLine());

if (q1 < 2 || q1 > 10 || q2 < 2 || q2 > 10)
{
    Console.WriteLine("Ошибка: Основание системы счисления должно быть в диапазоне от 2 до 10.");
    return;
}

if (q1 == 10)
{
    string str = "";

    int a = 0;
    int b = x;
    while (b > 0)
    {
        a = b % q2;
        b = b / q2;
        str += a.ToString();
    }
    string reversed = new string(str.Reverse().ToArray());
    Console.Write(reversed);
}if (q2 == 10)
{
    string len = Convert.ToString(x);
    int lenint = len.Length - 1;
    double aa = 0;
    int bb = x;
    while (bb > 0)
    {
        x = x % 10;
        bb = bb / 10;
        aa += x * Math.Pow(q1, lenint);
        lenint -= 1;
    }
    Console.Write(aa);
}else
{
    string len = Convert.ToString(x);
    int lenint = len.Length - 1;
    double aa = 0;
    int bb = x;
    while (bb > 0)
    {
        x = x % 10;
        bb = bb / 10;
        aa += x * Math.Pow(q1, lenint);
        lenint -= 1;
    }
    string str = "";

    double a = 0;
    double b = aa;
    while (b > 0)
    {
        a = b % q2;
        b = b / q2;
        str += a.ToString();
    }
    string reversed = new string(str.Reverse().ToArray());
    Console.Write(reversed);
}
   






