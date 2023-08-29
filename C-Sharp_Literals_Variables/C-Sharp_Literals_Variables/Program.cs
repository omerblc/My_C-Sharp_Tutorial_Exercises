// I am trying to learn lteral variables in csharp. 29.08.2023 Tuesday.

// string variable
Console.WriteLine("Life is beautiful.");

// char variable
Console.WriteLine('b');

/* Console.WriteLine('Hello World!');
 * gives error because when you use single quotes,
 * the C# compiler expects a single character. */

/* Console.WriteLine('123'); It gives the same error for the same reason. */

// int variable
Console.WriteLine(123);

/*
Float Type    Precision
----------------------------
float         ~6-9 digits
double        ~15-17 digits
decimal        28-29 digits
*/

// float variable
Console.WriteLine(0.25F);
// We can use lowercase f or uppercase F as a float literal suffix.

// double variable
Console.WriteLine(2.625);
// When entered without a suffix, the compiler defaults to a double literal.

// decimal variable
Console.WriteLine(12.39816m);
// You can use lowercase m or uppercase M as a decimal literal suffix.

// bool literal variables
Console.WriteLine(true);
Console.WriteLine(false);