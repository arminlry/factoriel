//armin liryaee
// tamrin 5
//factoriel
char p = ' ';


do
{
    Console.WriteLine(" enter N number:");
    decimal N = Convert.ToDecimal(Console.ReadLine());
    decimal a = N;
    for (decimal i = 1; i < N; i++)
    {
        a = a * i;
    }
    Console.WriteLine(p);
    Console.WriteLine(a);
    Console.WriteLine(p);
    Console.WriteLine("do you want to continue?");

} while (Console.ReadLine() == "y");