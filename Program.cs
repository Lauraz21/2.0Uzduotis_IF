Console.WriteLine("Iveskite skaiciu: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0)
{
    Console.WriteLine("Skaicius yra lyginis");
}
else if (number % 5 == 0)
{
    Console.WriteLine("Skaicius dalijasi is 5");
}
else
{
    Console.WriteLine("Skaicius neatitinka jokiu salygu");
}