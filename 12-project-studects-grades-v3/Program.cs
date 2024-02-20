// Challenge project - Develop foreach and if-elseif-else structures to process array data in C#

// Student names
string[] studentsList = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
int[] studentScores = new int[10];
string currentStudentLetterGrade = "";

int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n----------------------------");

foreach (string student in studentsList)
{
  // Assigning the current student
  string currentStudent = student;

  // Assigning current student grades to the array of student scores
  if (currentStudent == "Sophia")
    studentScores = sophiaScores;

  else if (currentStudent == "Andrew")
    studentScores = andrewScores;

  else if (currentStudent == "Emma")
    studentScores = emmaScores;

  else if (currentStudent == "Logan")
    studentScores = loganScores;

  else if (currentStudent == "Becky")
    studentScores = beckyScores;

  else if (currentStudent == "Chris")
    studentScores = chrisScores;

  else if (currentStudent == "Eric")
    studentScores = ericScores;

  else if (currentStudent == "Gregor")
    studentScores = gregorScores;

  else
    continue;

  // Calculating the final score of the current student
  decimal studentExamScore = 0;
  decimal studentFinalScore = 0;
  decimal studentExtraCreditScore = 0;
  int gradedAssignments = 0;
  foreach (int score in studentScores)
  {
    gradedAssignments++;

    if (gradedAssignments <= 5)
    {
      studentFinalScore += (decimal)score;

      if (gradedAssignments == 5)
      {
        studentExamScore = studentFinalScore / 5;
      }
    }
    else
    {
      studentExtraCreditScore += score;
      studentFinalScore += score / 10;
    }
  }

  studentExtraCreditScore /= (studentScores.Length - 5);
  studentFinalScore /= examAssignments;

  // Defining the letter grade according to the final score of the current student
  if (studentFinalScore >= 97)
    currentStudentLetterGrade = "A+";

  else if (studentFinalScore >= 93)
    currentStudentLetterGrade = "A";

  else if (studentFinalScore >= 90)
    currentStudentLetterGrade = "A-";

  else if (studentFinalScore >= 87)
    currentStudentLetterGrade = "B+";

  else if (studentFinalScore >= 83)
    currentStudentLetterGrade = "B";

  else if (studentFinalScore >= 80)
    currentStudentLetterGrade = "B-";

  else if (studentFinalScore >= 77)
    currentStudentLetterGrade = "C+";

  else if (studentFinalScore >= 73)
    currentStudentLetterGrade = "C";

  else if (studentFinalScore >= 70)
    currentStudentLetterGrade = "C-";

  else if (studentFinalScore >= 67)
    currentStudentLetterGrade = "D+";

  else if (studentFinalScore >= 63)
    currentStudentLetterGrade = "D";

  else if (studentFinalScore >= 60)
    currentStudentLetterGrade = "D-";

  else
    currentStudentLetterGrade = "F";

  // Printing report of the current student
  Console.WriteLine($"{currentStudent}\t\t{studentExamScore}\t{studentFinalScore}\t{currentStudentLetterGrade}\t{studentExtraCreditScore} ({studentFinalScore - studentExamScore} pts.)");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();