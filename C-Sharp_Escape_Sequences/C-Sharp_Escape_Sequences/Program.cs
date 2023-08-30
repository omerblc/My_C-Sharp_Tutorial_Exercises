// C# Escape Sequences

// \n – Insert a newline
Console.WriteLine("Hello\nWorld");

// \t – Insert a tab
Console.WriteLine("Hello\tWorld");

// \” – Output a double quote
Console.WriteLine("Hello \"World\"");

// \’ – Output a Single quote
Console.WriteLine("Hello \'World\'");

// \\ – Output a Backslash
Console.WriteLine("Hello \\World\\");

// \r – Insert a carriage-return. It deletes before \r escape sequence.
Console.WriteLine("Hello \rWorld");

// \0 – Insert a null character
Console.WriteLine("\0");

// \b – Insert a backspace
Console.WriteLine("Hello \bWorld");

/* What if you need to use the backslash for other purposes, such as displaying the file path?
 * Console.WriteLine("c:\source\repos");
 * C# reserves backslashes for escape sequences, so if we run the code the compiler displays error
 * (1,22): error CS1009: Unrecognized escape sequence */

// To solve this problem, you use \\ to display a single backslash.
Console.WriteLine("c:\\source\\repos");

/* The @ directive preserves all spaces and characters without having to escape the backslash.
* To create a plain text string, we use the @ directive before the literal string. */
Console.WriteLine(@"c:\source\repos (this is where your code goes)");

// Kon'nichiwa World
/* You can also include encoded characters in literal strings using the escape sequence \u and then
 * a four-character code that represents some characters as Unicode (UTF-16).
 * Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
 * this code prints “こんにちは World!" text. */