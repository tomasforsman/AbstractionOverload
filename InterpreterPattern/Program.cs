class Program {
	static void Main(string[] args) {
		string filePath = "example.txt";
        
		if (File.Exists(filePath)) {
			string content = File.ReadAllText(filePath);
			IExpression expression = ParseExpression(content);
			Console.WriteLine($"The result of the expression is: {expression.Interpret()}");
		} else {
			Console.WriteLine("File not found.");
		}
	}
    
	// Simple parser to convert string to IExpression
	private static IExpression ParseExpression(string expression) {
		string[] parts = expression.Split('+');
		IExpression left = new NumberExpression(int.Parse(parts[0].Trim()));
		IExpression right = new NumberExpression(int.Parse(parts[1].Trim()));
		return new PlusExpression(left, right);
	}
}



