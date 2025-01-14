using System;

public class Helpers
{
    public static string[] GetArgs(params string[] args)
    {
        Boolean debug = false;
        if (debug)
        {
            Console.WriteLine(":: GetArgs debug ::");
            Console.WriteLine(new String('-', 20));
            if (args.Length > 0)
            {
                Console.WriteLine(":: GetArgs arguments ::");
                foreach (string arg in args)
                {
                    Console.WriteLine("::  " + arg);
                }
            }
            else
            {
                Console.WriteLine(":: GetArgs - no arguments");
            }
            Console.WriteLine(new String('-', 20));

        }
        else
        {
            Console.WriteLine(":: GetArgs ::");
        }

        return args;
    }
}
