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
/*
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
*/
/*
string permission = "Admin||Manager";
int level = 20;

if(level >= 55 && permission.Contains("Admin"))
{
    Console.WriteLine( "Welcome, Super Admin user.");
}
else if (level <= 55 && permission.Contains("Admin"))
{
    Console.WriteLine( "Welcome, Admin user.");
}
else if (level >= 20 && permission.Contains("Manager"))
{
    Console.WriteLine( "Contact an Admin for access.");
}
else if (level < 20 && permission.Contains("Manager"))
{
    Console.WriteLine( "You do not have sufficient privileges.");
}
else if ( !permission.Contains("Admin" + "Manager"))
{
    Console.WriteLine( "You do not have sufficient privileges.");
}
*/
/*
bool flag = true;
int value =0;
if (flag)
{
    value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}
Console.WriteLine($"Outside of code block: {value}");
*/
/*
bool flag = true;
if (flag) Console.WriteLine(flag);
*/
/*
string name = "steve";
if (name == "bob") 
    Console.WriteLine("Found Bob");

else if (name == "steve") 
    Console.WriteLine("Found Steve");
else 
    Console.WriteLine("Found Chuck");
*/
/*
int[] numbers = { 4, 8, 15, 16, 23, 42 };
bool found = true;
int total=0;
foreach (int number in numbers)
{
     

    total += number;

    if (number == 42)
    {
        found = true;

    }

}

if (found) 
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");
*/
/*
int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    
    
    case 200:
    title = "Senior Associate";
    break;
    case 300:
    title = " Manager";
    break;
    case 400:
    title = "Senior Manager";
    break;
    default:
    title = "Associate";
    break;
}
Console.WriteLine($"{employeeName}, {title}");
*/
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
/*
using System.Drawing;

string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch(product[0])
{
    case "01":
    type = "Sweat shirt";
    break;

    case "02":
    type = "T-shirt";
    break;

    case "03":
    type = "Sweat pants";
    break;

}
switch(product[1])
{
    case "BL":
    color = "Black";
    break;

    case "MN":
    color = "Maroon";
    break;
}

switch(product[2])
{
    case "S":
    size = "small";
    break;

    case "M":
    size = "Medium";
    break;

    case "L":
    size = "Large";
    break;
}

Console.WriteLine($"Product: {size} {color} {type}");
*/
/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}
*/
/*
using System.Reflection.Metadata;

string[] names = { "Ales", "Eddie", "David", "Michael"};
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
*/
/*
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)

    {if (names[i] == "David") names[i] = "Sammy";}
    
    foreach (var name in names)
    { Console.WriteLine(name);}
    */
    
   
    /*
       for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine(i + " FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine(i + " Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine(i + " Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
        */
/*
        Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);
    if (current >= 8) continue;
    Console.WriteLine(current);
} while (current != 7);
  */
  /*
  while (current >= 3)
  {
    Console.WriteLine(current);
    current = random.Next(1, 11);

  }  
  Console.WriteLine($"Last number: {current}    " );
    */
    
    int hero = 10;
        int monster = 10;
        Random random = new Random();

        do
        {
            int hit = random.Next(1, 10);

        
            monster -= hit;
            Console.WriteLine("Hero hits the monster for " + hit + " damage. Monster's HP: " + monster);

            
            if (monster <= 0)
            {
                Console.WriteLine("Hero defeats the monster!");
                break;
            }

       
            hit = random.Next(1, 10);
            hero -= hit;
            Console.WriteLine("Monster hits the hero for " + hit + " damage. Hero's HP: " + hero);

            
            if (hero <= 0)
            {
                Console.WriteLine("Monster defeats the hero!");
                break;
            }

        } while (hero > 0 && monster > 0);