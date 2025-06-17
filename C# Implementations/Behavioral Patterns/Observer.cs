using System;
using System.Collections.Generic;

public class NewsLetter {
	public string current_name { get; set; }
	private int issue_number;
	private List<Subscriber> subscribers = new List<Subscriber>();
	
	public void Subscribe(Subscriber new_sub) {
		this.subscribers.Add(new_sub);	
	}
	
	public void Unsubscribe(Subscriber remove_sub) {
		this.subscribers.Remove(remove_sub);	
	}
	
	public void IssueNewsletter() {
		foreach (Subscriber sub in this.subscribers) {
			sub.newIssue(this.current_name);
		}	
	}
	
	public void NewNewsletter(string new_name) {
		this.current_name = new_name;
		this.IssueNewsletter();
	}
	
}

public interface Subscriber {
	public void newIssue(string issue_name);	
}

public class John : Subscriber {
	public void newIssue(string issue_name) {
		if (issue_name == "How To Gamble and Win $1 Million") {
			Console.WriteLine("I love gambling!! This will be a fun issue");	
		}
	}
}

public class Emma : Subscriber {
	public void newIssue(string issue_name) {
		if (issue_name == "Perfect Gear to Backpack Europe") {
			Console.WriteLine("I've wanted to do this for so long");
		}
	}
}

public class Program
{
	public static void Main()
	{
		NewsLetter n = new NewsLetter();
		John john = new John();
		Emma emma = new Emma();
		
		n.Subscribe(john);
		n.Subscribe(emma);
		
		Console.WriteLine("- Test Case that activates the Console Log for Emma - \n");
		n.NewNewsletter("Perfect Gear to Backpack Europe");
		
		Console.WriteLine("\n\n- Test Case that activates the Console Log for John - \n");
		n.NewNewsletter("How To Gamble and Win $1 Million");
		
		Console.WriteLine("\n\n- Test Case that won't activate either Console Log - \n");
		n.NewNewsletter("what");
	}
}
