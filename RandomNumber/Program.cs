Random rnd = new Random();

int myRandomNum;

int randomSum = 0;

for(int i = 0; i < 3; i++)
{
    myRandomNum = rnd.Next(0, 11);
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My Random number: {myRandomNum}");
}
Console.WriteLine($"randum sum total: {randomSum}");