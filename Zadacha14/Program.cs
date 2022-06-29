int n;
n = Convert.ToInt32(Console.ReadLine());
if (n % 7 == 0)
{
    if (n % 23 == 0)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}
else
{
    Console.WriteLine("no");
}



// int n;
// n = Convert.ToInt32(Console.ReadLine());
// if (n % 7 == 0 && n % 23 == 0 )
// {
//      Console.WriteLine("yes");
// }
        
// else
// {
//   Console.WriteLine("no");
// }

// && условие И
// || условие ИЛИ