// Code redability challenge: Add white spacing to organize an improve code readability

// Original
string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");

// Improved
/*
  It takes a string, reverses it and counts how many times a specific character appears in the string. Then, it prints the results into the console.
*/
string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = originalMessage.ToCharArray();
Array.Reverse(charMessage);

int count = 0;
foreach (char character in charMessage)
{
  if (character == 'o')
  {
    count++;
  }
}

string newMessage = new String(charMessage);
Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {x} times.");