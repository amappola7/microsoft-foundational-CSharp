//  Exercise conditional operator

// Console.Write("What is the value of your purchase?");
// int purchaseValue = Console.Read();
int purchaseValue = 100000;
int discount = purchaseValue >= 1000 ? 100 : 50;
Console.WriteLine($"Your purchase is: {purchaseValue} dollars.");
Console.WriteLine($"Your discount is: {discount} dollars.");