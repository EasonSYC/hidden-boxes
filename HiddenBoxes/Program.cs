class Program
{
    static void Main(string[] args)
    {
        int NumBox = 0;
        HiddenBox[] TheBoxes = new HiddenBox[10000];

        NewBox(TheBoxes, ref NumBox);
    }

    static void NewBox(HiddenBox[] TheBoxes, ref int NumBox)
    {
        Console.WriteLine("Enter Box Name: ");
        string? boxName = Console.ReadLine();
        Console.WriteLine("Enter Creater Name: ");
        string? creator = Console.ReadLine();
        Console.WriteLine("Enter Date Hidden: ");
        DateOnly dateHidden = DateOnly.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter Game Location: ");
        string? gameLocation = Console.ReadLine();
        TheBoxes[NumBox++] = new(boxName!, creator!, dateHidden, gameLocation!);
    }
}

class HiddenBox
{
    private string BoxName;
    private string Creator;
    private DateOnly DateHidden;
    private string GameLocation;
    private string[,] LastFinds = new string[10, 2];
    private bool Active;

    public HiddenBox(string boxName, string creator, DateOnly dateHidden, string gameLocation)
    {
        BoxName = boxName;
        Creator = creator;
        DateHidden = dateHidden;
        GameLocation = gameLocation;

        Active = false;
        LastFinds = new string[10, 2];
    }

    public string GetBoxName()
    {
        return BoxName;
    }

    public string GetGameLocation()
    {
        return GameLocation;
    }
}

class PuzzleBox : HiddenBox
{
    private string PuzzleText;
    private string Solution;

    public PuzzleBox(string boxName, string creator, DateOnly dateHidden, string gameLocation, string puzzleText, string solution) : base(boxName, creator, dateHidden, gameLocation)
    {
        PuzzleText = puzzleText;
        Solution = solution;
    }
}