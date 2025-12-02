Random dadu1 = new Random();
Random dadu2 = new Random();

int roll1 = dadu1.Next(1, 7);  
int roll2 = dadu2.Next(1, 7);

int total = roll1 + roll2;

Console.WriteLine($"hasil penjumlahan: {roll1} + {roll2} adalah {total}");
if ((roll1 == roll2)) 
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}
if (total >= 12)
{
    Console.WriteLine("You win!");
}

if (total < 12)
{
    Console.WriteLine("Sorry, you lose.");
}       

/*bisa pakai else
else 
{
    Console.WriteLine("Sorry, you lose.");
}
*/