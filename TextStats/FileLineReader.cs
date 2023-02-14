namespace TextStats
{
    internal class FileLineReader : ILineReader
    {
        private readonly StreamReader _reader;

        public FileLineReader(string filename)
        {
            var fileStream = new FileStream(filename, FileMode.Open);
            _reader = new StreamReader(fileStream);
        }

        public string GetNextLineOrNull()
        {
            return _reader.ReadLine();
        }
    }
}
