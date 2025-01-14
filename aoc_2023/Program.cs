//  Title:  Advent Of Code Template - 2023
//  Author: Chuck Staples
//


Console.Clear();
Console.WriteLine(new String('=', 80));
Console.WriteLine("");
Console.WriteLine("************       Advent Of Code 2023   ---   C# Console App       ************");
Console.WriteLine("");
Console.WriteLine(new String('=', 80));

main(args);

static void main(string[] args)
{
    Console.WriteLine("****    main    ****");

    string[] myargs = Helpers.GetArgs(args);
    if (myargs.Length < 3)
    {
        Console.WriteLine("::  insufficient arguments  ::");
        return;
    }

    Console.WriteLine(new String('-', 20));
    Console.WriteLine("**    day :  "+ myargs[0]);
    Console.WriteLine("**  phase :  "+ myargs[1]);
    Console.WriteLine("**  input :  "+ myargs[2]);
    Console.WriteLine(new String('-', 20));

}
