using System;
		
public interface Operation {
	public int ExecuteOperation(int a, int b);
}	

public class Addition : Operation {
	public int ExecuteOperation(int a, int b) {
		return a + b;
	}
}

public class Subtraction : Operation { 
	public int ExecuteOperation(int a, int b) {
		return a - b;	
	}
}

public class Multiplication : Operation  {
	public int ExecuteOperation(int a, int b) {
		return a * b;		
	}
}

public class Calculator {
	private Operation current_op;
	
	public void SetOperation(Operation op) {
		this.current_op = op;	
	}
	
	public int RunOperation(int a, int b) {
		return this.current_op.ExecuteOperation(a, b);	
	}
}


public class Program
{
	public static void Main()
	{
		var calculator = new Calculator();
		
		var test_add = new Addition();
		calculator.SetOperation(test_add);
		Console.WriteLine(calculator.RunOperation(3, 5));
		
		var test_sub = new Subtraction();
		calculator.SetOperation(test_sub);
		Console.WriteLine(calculator.RunOperation(3, 5));
		
		var test_mult = new Multiplication();
		calculator.SetOperation(test_mult);
		Console.WriteLine(calculator.RunOperation(3, 5));
		
	}
}
