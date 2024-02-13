// Exercise - Construct a nested loop structure for student grade calculations

string[] studentsList = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int currentAssignments = 5;

int[] sophiaGrades = { 90, 86, 87, 98, 100 };
int[] andrewGrades = { 92, 89, 81, 96, 90 };
int[] emmaGrades = { 90, 85, 87, 88, 96 };
int[] loganGrades = { 90, 95, 87, 88, 96 };

Console.WriteLine("Student\t\tGrade\n----------------------------");

foreach (string student in studentsList)
{
  if (student == "Sophia")
  {
    decimal sophiaScore = 0;
    foreach (int grade in sophiaGrades)
    {
      sophiaScore += (decimal)grade;
    }
    sophiaScore /= currentAssignments;

    Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
  }
  else if (student == "Andrew")
  {
    decimal andrewScore = 0;
    foreach (int grade in andrewGrades)
    {
      andrewScore += (decimal)grade;
    }
    andrewScore /= currentAssignments;

    Console.WriteLine("Andrew:\t\t" + andrewScore + "\tA-");
  }
  else if (student == "Emma")
  {
    decimal emmaScore = 0;
    foreach (int grade in emmaGrades)
    {
      emmaScore += (decimal)grade;
    }
    emmaScore /= currentAssignments;

    Console.WriteLine("Emma:\t\t" + emmaScore + "\tA-");
  }
  else if (student == "Logan")
  {
    decimal loganScore = 0;
    foreach (int grade in loganGrades)
    {
      loganScore += (decimal)grade;
    }
    loganScore /= currentAssignments;

    Console.WriteLine("Sophia:\t\t" + loganScore + "\tA-");
  }
}