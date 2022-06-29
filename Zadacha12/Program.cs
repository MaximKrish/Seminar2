int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 % n2 == 0)
{
    Console.WriteLine("кратно");
    
}
else
{
     Console.WriteLine("не кратно");
     Console.WriteLine(n1 % n2);
}