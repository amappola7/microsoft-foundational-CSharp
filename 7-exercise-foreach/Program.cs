// Learning to use the for each loop to iterate trough an array

int[] inventory = { 200, 450, 700, 175, 250 };
int total = 0;
int bin = 0;

foreach (int item in inventory)
{
  total += item;
  bin++;
  Console.WriteLine($"Bin {bin} = {item} items (Running total: {total})");
}

Console.WriteLine($"We have {total} items in inventory.");