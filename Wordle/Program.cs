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

        return answer;
    }

    public static void guessWord()
    {

        string? userAnswer = Console.ReadLine();

        guesses++;

        Console.WriteLine("================================\n");

        if (userAnswer == null || userAnswer.Length != 5)
        {
            Console.WriteLine("Invalid word!");
            Console.WriteLine("\n================================");
            guessWord();
        }

        string[] output = new string[5];

        for (int i = 0; i < 5; i++)
        {
            if (answer[i] == userAnswer[i])
            {
                output[i] = "Correct";
            }
            else if (CheckForYellow(i, userAnswer))
            {
                output[i] = "Wrong Place";
            }
            else
            {
                output[i] = "Wrong";
            }

            Console.WriteLine("Letter {0}: {1}", userAnswer[i], output[i]);
        }

        Console.WriteLine("\n================================");

        if(guesses == 6) {
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

    public static bool CheckForYellow(int index, string userAnswer)
    {
        int letterCount = 0;
        int incorrectCountBeforeIndex = 0;
        int correctCount = 0;

        for (int i = 0; i < answer.Length; i++)
        {
            if (answer[i] == userAnswer[index])
            {
                letterCount++;
            }
            if (userAnswer[i] == userAnswer[index] && answer[i] == userAnswer[index])
            {
                correctCount++;
            }
            if (i < index && userAnswer[i] == userAnswer[index] && answer[i] != userAnswer[index])
            {
                incorrectCountBeforeIndex++;
            }

        }
        return letterCount - correctCount - incorrectCountBeforeIndex > 0;
    }
}