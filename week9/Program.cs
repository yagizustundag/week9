
string FileDirectory = @"C:\\Users\\
string FileName = "chuck.txt";

string FullAdress = Path.Combine(FileDirectory, FileName);

ReadFromFile(FullAdress);


static void DisplayDataFromArray(string[] data)
{
    foreach (string joke in data)
    {
        Console.WriteLine(joke);
    }
}

static void ReadFromFile(string path)
{
    if (File.Exists(path))
    {
        string[] ChuckJokes = File.ReadAllLines(path);
        Console.WriteLine($"There are {ChuckJokes.Length} lines in the file.");
        Console.WriteLine("Do you want to sea all files or pick a random one? all/random");
        string UserChoise = Console.ReadLine();

        if (UserChoise == "all")
        {
            DisplayDataFromArray(ChuckJokes);
        }
        else if (UserChoise == "random")
        {
            DisplayRandomElement(ChuckJokes);
        }
        else
        {
            Console.WriteLine("Try again.");
        }

    }
    else
    {
        Console.WriteLine($"File was not find");
    }
}

static void DisplayRandomElement(string[] data)
{
    Random random = new Random();
    int RandomIndex = random.Next(0, data.Length);
    Console.WriteLine(data[RandomIndex]);
}