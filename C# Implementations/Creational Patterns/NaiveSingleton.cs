using System;

public class Singleton {
	
	private string singleton_name;
	private static Singleton s;
	
	
	private Singleton() {
			singleton_name = "joe";
	}
	
	public static Singleton getInstance() {
		if (s == null) {
			s = new Singleton();
		}
		
		return s;
	}
}

public class Program
{	
	public static void Main(string[] args)
	{
		Singleton s1 = Singleton.getInstance();
		Singleton s2 = Singleton.getInstance();
		
		if (s1 == s2) {
			Console.WriteLine("It worked :)");
		} else {
			Console.WriteLine("It didn't work :(");	
		}
	}
}
