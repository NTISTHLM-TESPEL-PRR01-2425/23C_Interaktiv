Console.WriteLine("Användarnamn:");
string name = Console.ReadLine();
name = name.ToLower();

if (name == "micke" || name == "martin")
{
  Console.WriteLine("Välkommen!");
}
else if (name == "martin")
{
  Console.WriteLine("Välkommen!");
}
else
{
  Console.WriteLine("FU");
}

Console.ReadLine();