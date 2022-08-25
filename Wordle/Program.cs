class Program
{

    public static string answer { get; set; }
    public static int guesses { get; set; }

    static void Main(string[] args)
    {
        answer = getWord();

        Console.WriteLine("Welcome to Wordle!\nTry to guess the word!");

        guessWord();
    }

    public static string getWord()
    {
        string[] words = File.ReadAllLines("./words.txt");

        Random random = new Random();

        string answer = words[random.Next(words.Length)];

        return "lemon";
    }

    public static void guessWord()
    {

        string? userAnswer = Console.ReadLine();

        guesses++;

        Console.WriteLine("================================\n");

        if (userAnswer == null || userAnswer.Length != 5)
        {
            Console.WriteLine("Invalid word!");
            guessWord();
        }

        string[] output = new string[5];

        for (int i = 0; i < 5; i++)
        {
            switch (checkLetter(userAnswer[i], i))
            {
                case 0:
                    output[i] = "Wrong";
                    break;
                case 1:
                    output[i] = "Wrong Place";
                    break;
                case 2:
                    output[i] = "Correct";
                    break;
            }

            Console.WriteLine("Letter {0}: {1}", userAnswer[i], output[i]);
        }

        Console.WriteLine("\n================================");

        if (guesses == 6)
        {
            Console.WriteLine("The word is {0}, you lost!", answer);
            return;
        }

        if (userAnswer == answer)
        {
            Console.WriteLine("The word is {0}, you won in {1} guesses!", answer, guesses);
            return;
        }
        else
        {
            guessWord();
        }

    }

    public static int checkLetter(char letter, int currentLetter)
    {
        if (!answer.Contains(letter))
        {
            return 0;
        }

        if (answer.Contains(letter) && letter == answer[currentLetter])
        {
            return 2;
        }

        return 1;
    }
}