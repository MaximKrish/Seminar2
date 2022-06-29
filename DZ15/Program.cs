int n = Convert.ToInt32(Console.ReadLine());
if (n % 7 == 0 || n % 7 == 6)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Рабочий день");
}