// Math Operations

int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

// for better quotient results
decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

/* To convert int to decimal, you prefix the value with a type conversion operator.
 * You use the name of the data type surrounded by parentheses in front of the value. */
int first = 7;
int second = 5;
decimal quotient2 = (decimal)first / (decimal)second;
Console.WriteLine(quotient2);

/* The modulus operator % tells you the remainder of the int division operation.
 * Actually, this tells you whether a number is divisible by another number. */
Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

// order of operations
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

// Increasing and decreasing values
int value = 1; // value is now 1

value = value + 1; // value is now 2
Console.WriteLine("First increment: " + value);

value += 1; // value is now 3
Console.WriteLine("Second increment: " + value);

value++; // value is now 4
Console.WriteLine("Third increment: " + value);

value = value - 1; // value is now 3
Console.WriteLine("First decrement: " + value);

value -= 1; // value is now 2
Console.WriteLine("Second decrement: " + value);

value--; // value is now 1
Console.WriteLine("Third decrement: " + value);

/* If you use the operator before the value (++value), the increment is performed 
 * before the value is retrieved. Similarly, value++ increments the value after it is received. */
int value3 = 1;
value3++;
Console.WriteLine("First: " + value3);
Console.WriteLine("Second: " + value3++);
Console.WriteLine("Third: " + value3);
Console.WriteLine("Fourth: " + (++value3));