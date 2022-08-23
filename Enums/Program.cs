using Ranks;
using Planets;
class Program
{

    static void Main(string[] args)
    {

        Console.Write("Select a planet from 1 to 9. ");
        string? userInput = Console.ReadLine();

        if(userInput != null){
            // This kinda works like a find by ID
            int planetID = Int32.Parse(userInput);
            Console.WriteLine((Planet)planetID);
        }

        // Get the ID of a certain Rank
        Console.WriteLine((int)Rank.Bronze);

        getRankLevel(Rank.Bronze);

    }

    //Enum with a case
    public static void getRankLevel(Rank rank)
    {

        switch (rank)
        {
            case Rank.Bronze:
                Console.WriteLine("Low rank");
                return;
            case Rank.Diamond:
                Console.WriteLine("Medium rank");
                return;
            case Rank.Challenger:
                Console.WriteLine("High rank");
                return;
            default:
                Console.WriteLine("Something is wrong");
                return;
        }
    }

}