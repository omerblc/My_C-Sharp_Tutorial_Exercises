// We can concatenate strings by using the + operator
using System;

string firstName1 = "Bob";
string message1 = "Hello " + firstName1;
Console.WriteLine(message1);

// another solution
string firstName2 = "Bob";
string greeting2 = "Hello";
string message2 = greeting2 + " " + firstName2 + "!";
Console.WriteLine(message2);

// we can do this with less code lines
string firstName3 = "Bob";
string greeting3 = "Hello";
Console.WriteLine(greeting3 + " " + firstName3 + "!");

/* String association combines multiple values into a single literal string using a "template" and
 * one or more association expressions. The association expression is a variable enclosed in the opening
 * and closing brace { }. A literal string becomes a template when preceded by a $ character. */
string firstName4 = "Bob";
string greeting4 = "Hello";
string message4 = $"{greeting4} {firstName4}!";
Console.WriteLine(message4);

// another solution
string firstName5 = "Bob";
string message5 = $"Hello {firstName5}!";
Console.WriteLine(message5);

/* The $ symbol allows you to reference the variable inside the square brackets,
* and the @ symbol allows you to use the \ character. */
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

/* exercise for concatenate strings
* If the message is only displayed as question mark characters,
* your console does not support Unicode characters. */
string projectName1 = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.Write("View English output:\n\t");
Console.WriteLine($@"c:Exercise\{projectName1}\data.txt");

Console.Write("\n" + russianMessage + ":\n\t");
Console.WriteLine($@"c:Exercise\{projectName1}\ru-RU\data.txt");