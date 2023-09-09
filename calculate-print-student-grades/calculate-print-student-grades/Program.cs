// calculate-print-student-grades

/* Sophia: 93, 87, 98, 95, 100

Nicolas: 80, 83, 82, 88, 85

Zahirah: 84, 96, 73, 85, 79

Jeong: 90, 92, 98, 100, 97 */

// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sofiaSum = (sophia1 + sophia2 + sophia3 + sophia4 + sophia5);
decimal sofiaScore = (decimal) sofiaSum / currentAssignments;

int nicolasSum = (nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5);
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;

int zahirahSum = (zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5);
decimal zahirahScore = (decimal) zahirahSum / currentAssignments;

int jeongSum = (jeong1 + jeong2 + jeong3 + jeong4 + jeong5);
decimal jeongScore = (decimal) jeongSum / currentAssignments;

/*
97 - 100    A+
93 - 96     A
90 - 92     A-
87 - 89     B+
83 - 86     B
*/

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia\t\t" + sofiaScore + " A");
Console.WriteLine("Nicolas\t\t" + nicolasScore + " B");
Console.WriteLine("Zahirah\t\t" + zahirahScore + " B");
Console.WriteLine("Jeong\t\t" + jeongScore + " A");