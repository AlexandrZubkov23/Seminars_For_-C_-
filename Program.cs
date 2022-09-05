// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int num = n;
// int t = 0, d = 1;

// while(num > 0)
// {
//     t += (num % 2) * d;
//     num = num / 2;
//     d = d * 10;
// }

// Console.WriteLine(t);





// //ДЕсятичое в двоичное
// Console.WriteLine("ВВедите число");
// int x = Convert.ToInt32(Console.ReadLine());
// int i=0;
// int z=0;
// while (x!=0) 
// {
//     i = (i*10)+(x%2);
//     if (i==0)
//     {
//         z ++;
//     }
//     x = x/2;
// }
// x = i;
// i = 0;
// while (x >0)
// {
//     i = (i*10) + (x%10);
//     x = x/10;
// }

// while (z !=0 )
// {
//     i = i * 10;
//     z--;
// }
// Console.WriteLine($"{i}");



Console.Write("Введите  число а:");
int a = Convert.ToInt32(Console.ReadLine());
String Reresult="";
for (int i=0; i<=a; i++)
while (a>0)
{
    Reresult=((a%2==0) ? "0" : 1 + Reresult);
    a/=2;
    
}
Console.Write(Reresult);








/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
string Fib(int size)
{
    int [] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        if (i == 0 || i == 1) res[i] = i;
        else res[i] = res[i-1]+res[i-2];
    }
    string fibRes = string.Empty;
    foreach (int item in res)
    {
        fibRes += item + " ";
    }
    return fibRes;
}
Console.Write("Введите число фибоначи: ");
int numb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Fib(numb));

