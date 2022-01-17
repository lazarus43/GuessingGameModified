
Console.WriteLine("Hello, It's Guessing Game!");


Console.WriteLine(" ");

Random rNum = new Random();
var wNum = rNum.Next(0,100);
bool wStatus = false;
int nCh = 0;
Console.WriteLine("Select difficult \n" +
    "1.Hard: 3 chances \n" +
    "2.Medium: 5 chances \n" +
    "3.Easy: 10 chances ");
ST:
char nDiff = Console.ReadKey().KeyChar;

    switch (nDiff)
    {
        case '1':
            nCh = 3;
            Console.WriteLine($". You have {nCh} chances");
        break;
        case '2':
            nCh = 5;
            Console.WriteLine($". You have {nCh} chances");
        break;
        case '3':
            nCh = 10;
            Console.WriteLine($". You have {nCh} chances");
        break;
        default:
        Console.WriteLine(" is not valid, choose again pls!");
        goto ST;
    }


while (wStatus == false)
{
    Console.WriteLine($"Enter a number");
    //var iNum = Convert.ToInt32(Console.ReadLine());
    var input = Console.ReadLine();
    if (int.TryParse(input,out var iNum))
    {
        Console.Clear();
        if (iNum != wNum)
        {
            Console.WriteLine($"Wrong number try again!!!! You have {(nCh - 1)} chance left");
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
        nCh--;
    }
    else
    {
        if (input == "shownum")
        {
            Console.WriteLine("It's, " + wNum);
        }
        else
        {
            Console.WriteLine("Not valid number");
        }
    } 
    if(nCh == 0)
    {
        Console.WriteLine("You lose");
        break;
    }
}
Console.WriteLine("Press Any key to Finnish");
Console.ReadKey();