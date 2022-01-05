Console.WriteLine("What is your name");
string input1 = Console.ReadLine();

Console.WriteLine(input1 + " what is your favorite color");
string input2 = Console.ReadLine();

if(input2 == "purple" || input2 == "Purple")
{
    Console.WriteLine(input2 + " huh you have good tastes");
}
else
{
    Console.WriteLine(input2 + " huh Purple is a better color");
}

Console.WriteLine(input1 + " do you scalp computer parts");
string input3 = Console.ReadLine();

if(input3 == "yes" || input3 == "Yes" || input3 == "y")
{
    Console.WriteLine("Thats not very cool of you " + input1 + " you should sell me a RTX 3080 at MSRP though. Ill pay for taxes as well.");
}
Console.ReadKey();