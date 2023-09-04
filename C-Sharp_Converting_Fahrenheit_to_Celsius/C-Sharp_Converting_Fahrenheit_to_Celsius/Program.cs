// C-Sharp_Converting_Fahrenheit_to_Celsius

Random rnd = new Random();
float fahrenheitDegree = rnd.Next(-10, 41);
Console.WriteLine("Fahrenheit Degree: " + fahrenheitDegree);

float celsiusResult = 100f/180f * (fahrenheitDegree - 32f);
Console.WriteLine("Celsius Degree: " + celsiusResult);