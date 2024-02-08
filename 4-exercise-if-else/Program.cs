// Learning how to create decision logic with if, else if and else statements

Random dice = new Random();
int dice1 = dice.Next(1, 7);
int dice2 = dice.Next(1, 7);
int dice3 = dice.Next(1, 7);

int total = dice1 + dice2 + dice3;
Console.WriteLine($"Dice roll: {dice1} + {dice2} + {dice3} = {total}");

if ((dice1 == dice2) || (dice2 == dice3) || (dice1 == dice3))
{
  if ((dice1 == dice2) && (dice2 == dice3))
  {
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
  }
  else
  {
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
  }
};

if (total >= 16)
{
  Console.WriteLine($"Your total is {total}, you win a car!");
}
else if (total >= 10)
{
  Console.WriteLine($"Your total is {total}, you win a new laptop!");
}
else if (total == 7)
{
  Console.WriteLine($"Your total is {total}, you win a trip!");
}
else {
  Console.WriteLine($"Your total is {total}, you win a kitten!");
}

