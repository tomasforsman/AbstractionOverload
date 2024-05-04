class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";
		Publisher publisher = new Publisher();
		Subscriber subscriber = new Subscriber(publisher);

		publisher.CheckFileAndPublish(filePath);
	}
}