class FileFlyweightFactory
{
	private Dictionary<string, FileFlyweight> flyweights = new Dictionary<string, FileFlyweight>();

	public FileFlyweight GetFlyweight(string filePath)
	{
		if (!flyweights.ContainsKey(filePath))
		{
			flyweights[filePath] = new FileFlyweight(filePath);
		}
		return flyweights[filePath];
	}
}