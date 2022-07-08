using Core;

Console.WriteLine("Hello, World!");

if (args == null || args.Length < 2)
{
    throw new Exception("Input and Output path arguments have to be provided.");
}

new Sorter().Sort(args[0], args[1]);