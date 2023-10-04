// // Random diceG= new Random();
// // int roll= diceG.Next(1,7);
// // Console.WriteLine("Roll: "+roll);
// // Console.WriteLine(diceG.Next(1, 7));
// //overloading a method//
// // Random x = new Random();
// // int roll1 = x.Next();
// // int roll2 = x.Next(101);
// // int roll3 = x.Next(30,35);
// // Console.WriteLine( $"{roll1}, {roll2}, {roll3}");
// // int firstValue = 500;
// // int secondValue = 600;
// // int largerValue;
// // largerValue=Math.Max(firstValue, secondValue);

// // Console.WriteLine(largerValue);
// // &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&//

// Random dice =new Random();
// int roll1= dice.Next(1,7);
// int roll2= dice.Next(1,7);
// int roll3= dice.Next(1,7);

// int total = roll1+roll2+roll3;
// Console.WriteLine($"Dice roll {roll1}+{roll2}+{roll3}= {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     total += 2;
// }

// if (total>=15)
// { 
//     Console.WriteLine("Lucky ! You win");
// }
// if (total<15)
// {
//     Console.WriteLine("Try again, you lose");
// }
// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }
         //++++++++++++++IF ELSE////////

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop");
}
else if ((total >= 0))
{
    Console.WriteLine("You win a trip for two");

}
else
{
    Console.WriteLine("Sorry, you lose.");
}


