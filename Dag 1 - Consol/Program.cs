
//Opgave 1
using System.Diagnostics;

Console.WriteLine("Hello, World!");
//Opgave 2
Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code");
//Opgave 3
Console.WriteLine("");
Console.Write("Hej med dig.");
Console.WriteLine("");
Console.Write("Hej tilbage.");
Console.WriteLine("");

//Store and retrieve data using literal and variable values in C#
//Opgave 1
Console.WriteLine("H.");
Console.Write('S');
Console.Write('i');
Console.Write('l');
Console.Write('a');
Console.Write('s');
Console.WriteLine("");
//Opgave 2
Console.WriteLine(123);
//Opgave 3
Console.WriteLine(0.25f);
//Opgave 4
Console.WriteLine(2.625);
//Opgave 5
Console.WriteLine(12.39816m);
//Opgave 6
Console.WriteLine(true);
Console.WriteLine(false);
//Opgave 7
string firstName = "Silas";
Console.WriteLine(firstName);
//Opgave 8
//var message = "Hello";
//message = 10.703m;
//Opgave 9
string name = "bob";
int num = 3;
double num2 = 34.4;

Console.Write("Hey " + name + " har du købt " + num + " kager til de " + num2 + " gæster");

//Perform basic string formatting in C#

//Exercise - Format literal strings in C#

//Character escape sequences
Console.WriteLine("Hello\nWorld");
Console.WriteLine("Hello\nWorld");

Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\source\repos");

//Format output using character escape sequences

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

//Verbatim string literal

Console.WriteLine(@"    c:\source\repos(this is were your code goes)");
Console.WriteLine(@"c:\invoices");

//Unicode escape characters

Console.WriteLine("\u3053\u3003\u3049\u3039\u3030\u302f world");

//Format output using unicode escape characters

Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");

//Exercise - Combine strings using string concatenation

//What is string concatenation?

string message = "Hello " + firstName;
Console.WriteLine(message);

//Concatenate multiple variables and literal strings

string greeting = "Hello";
string message2 = greeting + " " + firstName + "!";
Console.WriteLine(message2);

//Avoiding intermediate variables

string firstName2 = "Silas";
string greeting2 = "Hello";
Console.WriteLine(greeting2 + " " + firstName2 + "!");

//Exercise - Combine strings using string interpolation

//What is string interpolation?

string message3 = $"{greeting} {firstName}!";

//Use string interpolation to combine a literal string and a variable value

string message4 = $"Hello {firstName}!";
Console.WriteLine(message4);

//Use string interpolation with multiple variables and literal strings

int version = 11;
string updateText = "Update to windows";
String message5 = $"{updateText} {version}!";
Console.WriteLine(message5);

//Avoid intermediate variables

int version1 = 11;
string updateText1 = "Update to windows";
Console.WriteLine($"{updateText1} {version1}!");

//Combine verbatim literals and string interpolation

string projectName = "First-Project";
Console.WriteLine($@"c:\output\{projectName}\Data");

//Complete the challenge

//Challenge: Format and display instructions

string projectName1 = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string engMessage = "View English output:";
Console.WriteLine(engMessage);
Console.Write(@$"c:\Exercise\{projectName1}\data.txt");
Console.WriteLine(russianMessage);
Console.Write(@$"c:\Exercise\{projectName1}\ru-RU\data.txt");



