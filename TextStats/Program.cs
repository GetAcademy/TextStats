using TextStats;

var fileLineReader = new FileLineReader("TextFile1.txt");
var keyboardLineReader = new KeyboardLineReader();

var statService = new StatService(keyboardLineReader);

var result = statService.GetStats("Terje");
Console.WriteLine(result);