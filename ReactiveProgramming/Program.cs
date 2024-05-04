using System.Reactive.Linq;
using System.Text;

class Program
{
	static void Main(string[] args)
	{
		string filePath = "example.txt";

		var fileObservable = Observable.Create<string>(observer =>
		{
			if (File.Exists(filePath))
			{
				try
				{
					string content = File.ReadAllText(filePath, Encoding.UTF8);
					observer.OnNext(content);
					observer.OnCompleted();
				}
				catch (Exception ex)
				{
					observer.OnError(ex);
				}
			}
			else
			{
				observer.OnError(new FileNotFoundException("File not found."));
			}

			return System.Reactive.Disposables.Disposable.Empty;
		});

		fileObservable.Subscribe(
			content => Console.WriteLine(content),
			error => Console.WriteLine(error.Message)
		);
	}
}