using System;

public class Program
{
	public static void Main()
	{	
        bool repeat = false;
		do
		{
			string Key;
			string Answer;
			string Name;
			string Answer2;
			string Answer3;
			Console.WriteLine("Let's have a conversation. Hit enter.");
			Key = Console.ReadLine();
			Console.WriteLine("Have we met before? (yes/no)");
			Answer = Console.ReadLine();
			if (Answer == "yes")
			{
				Console.WriteLine("It's good to see you again.");
				Console.WriteLine("Please enter your name: ");
				Name = Console.ReadLine();
			    Console.WriteLine("I missed you, " + Name + ".");
			}
			if (Answer == "")
			{
				Console.WriteLine("Please answer it.");
			}
	                else if
				(Answer == "no")
			{
				Console.WriteLine("Fancy meeting you here.");
				Console.WriteLine("I believe we can be friends. " + "Please tell me your name: ");
				Name = Console.ReadLine();
				Console.WriteLine("Thank you, " + Name + ".");
				Console.ReadLine();
			}
			Console.WriteLine("How are you? (good/bad)");
			Answer2 = Console.ReadLine();
			if (Answer2 == "good")
			{
				Console.WriteLine("Glad to hear it.");
			}
			if (Answer2 == "")
			{
				Console.WriteLine("Please answer it.");
			}
			else if
				(Answer2 == "bad")
			{
				Console.WriteLine("Can I help?");
				Console.ReadLine();
			}
			Console.WriteLine("Let's play a game OK?");
			Console.ReadLine();			
			Console.WriteLine("Why did the chicken cross the road?");
			Console.WriteLine("A: It ran away.");
		        Console.WriteLine("B: The rooster was on the other side.");
			Answer3 = Console.ReadLine();
			if (Answer3 == "B")
			{
				Console.WriteLine("You got it right!");
			}
			if (Answer3 == "A")
			{
				Console.WriteLine("The answer, I quote '" + Answer3 + "' is also correct.");
			}
		}
		while (repeat);
	}
}