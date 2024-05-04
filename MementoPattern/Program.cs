class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";
		FileOriginator originator = new FileOriginator();
		Caretaker caretaker = new Caretaker();

		originator.SetContent(filePath);
		caretaker.Memento = originator.Save();  // Save current state

		// Restore and display could be triggered under different conditions
		originator.Restore(caretaker.Memento);
		originator.Display();
	}
}