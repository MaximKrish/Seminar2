int n;
n = Convert.ToInt32(Console.ReadLine());
if (n%100 ==n)
{
    Console.WriteLine("Третьей цифры не существует");
}
else
{
    Console.WriteLine("Третья цифра числа: ");
    Console.WriteLine(Convert.ToString(n)[2]);
}



















// int n, n1 = 0;
// n = Convert.ToInt32(Console.ReadLine());

// if (n > 10)
// {
//     Console.WriteLine("такого числа не существует");
// }
// if (n > 100)
// {
//     n1 = n%10;
// }

// if (n > 1000)
// {
//     n1 = (n%100  -n%10)/10;
// }

// if (n > 10000)
// {
//     n1 = (n%1000  -n%100)/100;
// }
// Console.WriteLine(n1);



// int n, n1;
// n = Convert.ToInt32(Console.ReadLine());
// n1 = (n%100 - n%10) / 10;
// Console.WriteLine(n1);