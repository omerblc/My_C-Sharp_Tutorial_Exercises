// string variable
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);

/*
string firstName = "Bob";
Console.WriteLine(firstName);
In fact, you can both declare the variable and set the value in a single line of code.
This technique is called variable initialization. */

//var variable
var message = "Hello world!";
Console.WriteLine(message);
/*Used to declare implicitly typed local variable means it tells the compiler to 
 * figure out the type of the variable at compilation time.
 * The var keyword has an important use in C#. Often times,
 * the type of a variable is evident from the initialization.
 * In such cases it is easier to use the var keyword.
 * The var keyword can also be useful when scheduling an application's code.
 * When you start developing code for a task, you may not immediately know which data type to use.
 * Using var can help you develop your solution more dynamically.*/

/* The var keyword is locked during declaration and thus can never hold values from a different data type.
 * var message = "Hello World!";
 * message = 10.703m;
 * this code will give this error because
 * (2,11): error CS0029: Cannot implicitly convert type 'decimal' to 'string'
 * var keyword locked to string variable type. */

/* If we try to use the var keyword without initializing the variable,
 * we'll get an error when you try to compile your code.
 * var message;
 * this will give this error:
 * (1,5): error CS0818: Implicitly-typed variables must be initialized
 * code must be written like this var message = "Hello World!"; */

//char variable
char userOption;
userOption = 'a';
Console.WriteLine(userOption);

//char variable
int gameScore;
gameScore = 3;
Console.WriteLine(gameScore);

// decimal variable
decimal particlesPerMillion;
particlesPerMillion = 34.4M;
Console.WriteLine(particlesPerMillion);

// boole variable
bool processedCustomer;
processedCustomer = false;
Console.WriteLine(processedCustomer);

// exercise try to write "Hello, Bob! You have 3 in your inbox. The temperature is 34.4 celsius." on screen.

string bossName = "Bob";
int mailNumber = 3;
float temperature = 34.4F;

Console.Write("Hello, ");
Console.Write(bossName);
Console.Write("! You have ");
Console.Write(mailNumber);
Console.Write(" in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");