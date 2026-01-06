Console.Write("What is your favorite flavor of ice cream?");
string? favorite = Console.ReadLine();
if (favorite == null)
{
    favorite = "vanilla";
}
if (favorite == "vanilla")
{
    Console.WriteLine("Your basic");
}
if (favorite == "strawberry")
{
    Console.WriteLine("Your fruity :(");
}
Console.WriteLine($"You said your favorite flavor of ice cream is {favorite}.");