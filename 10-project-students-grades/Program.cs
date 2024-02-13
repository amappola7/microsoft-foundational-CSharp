// Exercise - Create arrays and foreach loops to calculate students grades
int currentAssignments = 5;

int[] sophiaGrades = {90, 86,  87, 98, 100};
int[] andrewGrades = {92, 89, 81, 96, 90};
int[] emmaGrades = {90, 85, 87, 88, 96};
int[] loganGrades = {90, 95, 87, 88, 96};

decimal sophiaScore = 0;
foreach (int grade in sophiaGrades)
{
  sophiaScore += (decimal)grade;
}
sophiaScore /= currentAssignments;

decimal andrewScore = 0;
foreach (int grade in andrewGrades)
{
  andrewScore += (decimal)grade;
}
andrewScore /= currentAssignments;

decimal emmaScore = 0;
foreach (int grade in emmaGrades)
{
  emmaScore += (decimal)grade;
}
emmaScore /= currentAssignments;

decimal loganScore = 0;
foreach (int grade in loganGrades)
{
  loganScore += (decimal)grade;
}
loganScore /= currentAssignments;






