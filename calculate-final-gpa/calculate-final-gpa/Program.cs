// calculate-final-gpa

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int grade1 = 4;
int grade2 = 3;
int grade3 = 3;
int grade4 = 3;
int grade5 = 4;

int creditSum = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;
int scoreSum = (grade1 * course1Credit + grade2 * course2Credit + grade3 * course3Credit + grade4 * course4Credit + grade5 * course5Credit);
decimal finalGpa = scoreSum / (decimal) creditSum; // but we need first 3 digits

int beforeComma = (scoreSum / creditSum);
int afterComma = (scoreSum * 100 / creditSum) - beforeComma*100;
string gpa3digits = $"{beforeComma}.{afterComma}";

Console.WriteLine("Student: " + studentName + "\n");
Console.WriteLine("Course\t\t    Grade\tCredit Hours");
Console.WriteLine(course1Name + "\t\t" + grade1 + "\t" + course1Credit);
Console.WriteLine(course2Name + "\t\t" + grade2 + "\t" + course2Credit);
Console.WriteLine(course3Name + "\t\t" + grade3 + "\t" + course3Credit);
Console.WriteLine(course4Name + "\t" + grade4 + "\t" + course4Credit);
Console.WriteLine(course5Name + "\t\t" + grade5 + "\t" + course5Credit);
Console.WriteLine("\nFinal GPA: \t" + gpa3digits);