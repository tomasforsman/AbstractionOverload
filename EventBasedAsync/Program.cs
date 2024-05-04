class Program
{
    static void Main(string[] args)
    {
        string filePath = "example.txt";
        FileReader fileReader = new FileReader(filePath);
        fileReader.FileReadCompleted += FileReader_FileReadCompleted;
        fileReader.ReadFileAsync();

        // To keep the console open and waiting for the file read to complete
        Console.WriteLine("Reading file, please wait...");
        Console.ReadLine();
    }

    private static void FileReader_FileReadCompleted(object sender, FileReadEventArgs e)
    {
        if (e.Error != null)
        {
            Console.WriteLine("Error: " + e.Error.Message);
        }
        else if (e.Cancelled)
        {
            Console.WriteLine("File read operation was cancelled.");
        }
        else
        {
            Console.WriteLine("File content:\n" + e.Content);
        }
    }
}