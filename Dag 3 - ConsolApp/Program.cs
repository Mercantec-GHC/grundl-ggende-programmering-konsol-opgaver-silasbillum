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
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
} else if (product[0] == "02")
{
    type = "T-Shirt";
} else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
} else if (product[1] == "MN")
{
    color = "Maroon";
} else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
} else if (product[2] == "M")
{
    size = "Medium";
} else if (product[2] == "L")
{
    size = "Large";
} else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");