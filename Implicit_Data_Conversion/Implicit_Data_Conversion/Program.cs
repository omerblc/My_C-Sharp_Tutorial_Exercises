// Adding two numeric values
int firstNumber = 12;
int secondNumber = 7;
Console.WriteLine(firstNumber + secondNumber);

// mixing data types
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");

/* Instead of collecting the variable widgetsSold of type int with the constant int 7,
 * the compiler treats them all as a string and concatenates them. */
Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");

/* As used in mathematical formulas, opening and closing parenthesis form the order of operations.
 * You specify that you want the innermost parentheses to be resolved first.
 * Once this is calculated, the editor implicitly converts the result to a string
 * so that it can be combined with the rest of the message. */
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

/* We should avoid doing both computation and concatenation in a single line of code.
 * The goal here is to understand how the compiler detects operators and operands. */