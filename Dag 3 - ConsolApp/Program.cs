/*
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));
// These two lines of code will create the same output

Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));
*/
/*string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));
*/
/*
int saleAmount = 1001;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
*/
Random flip = new Random();
int num = flip.Next(2);
if (num == 0)
{
    Console.WriteLine("Heads");
}
else if (num == 1)
{
    Console.WriteLine("Tails");
}
Console.WriteLine(num);