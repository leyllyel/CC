Console.WriteLine("Введите число x в 10-тичной системе счисления: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите систему счисления q в отрезке [2;9]: ");
int q = int.Parse(Console.ReadLine());

if (q < 2 || q > 9)
{
    Console.WriteLine("Ошибка: Основание системы счисления должно быть в диапазоне от 2 до 9.");
    return;
}


string s;

int a = 0;
int b = x;
while(b>0){
    a = b % 10;
    b = b / 10;
    Console.WriteLine(a);
}
