
Console.WriteLine("Hello, World!");


Console.WriteLine(" ");

Random rNum = new Random();

int wNum = rNum.Next(0,100);

int iNum;

bool wStatus = false;

while (wStatus == false)
{
    //Console.WriteLine("Enter a number: ");
    //iNum = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter a number : ");
    while (!int.TryParse(Console.ReadLine(), out iNum))
    {
        Console.Write("This is not valid input. Please enter an integer value: ");
    }
    Console.Clear();
    if (iNum != wNum)
    {
        Console.WriteLine("Wrong number try again!!!!");
    }
    if(iNum > wNum)
    {
        Console.WriteLine("Try lower");
    }
    else if(iNum < wNum)
    {
        Console.WriteLine("Try higher");
    }
    else
    {
        Console.WriteLine("                  Congrats You Win!!!            ");
        wStatus = true;
    }
}
Console.WriteLine("Press Any key to Finnish");
Console.ReadKey();