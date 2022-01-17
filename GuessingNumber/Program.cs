
Console.WriteLine("Hello, It's Guessing Game!");


Console.WriteLine(" ");

Random rNum = new Random();

var wNum = rNum.Next(0,100);

bool wStatus = false;

while (wStatus == false)
{
    Console.WriteLine("Enter a number: ");
    //var iNum = Convert.ToInt32(Console.ReadLine());   
    if (int.TryParse(Console.ReadLine(), out var iNum))
    {
        Console.Clear();
        if (iNum != wNum)
        {
            Console.WriteLine("Wrong number try again!!!!");
        }
        if (iNum > wNum)
        {
            Console.WriteLine("Try lower");
        }
        else if (iNum < wNum)
        {
            Console.WriteLine("Try higher");
        }
        else
        {
            Console.WriteLine("                  Congrats You Win!!!            ");
            wStatus = true;
        }
    }
    else
    {
        Console.WriteLine("Not valid number");
    }
}
Console.WriteLine("Press Any key to Finnish");
Console.ReadKey();