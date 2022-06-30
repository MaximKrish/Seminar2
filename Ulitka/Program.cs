Console.WriteLine("Введите высоту шеста ");
int h = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите высоту подъема за день ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите высоту спуска за ночь ");
int b = Convert.ToInt32(Console.ReadLine());
int i = 0; // дни
while (h >= 0)
{
    h = h - a + b;
    i++;
}
Console.WriteLine("Улитка доползет до вершины за ");
Console.WriteLine(i);

