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

            /*if (answer[i] == userAnswer[i])
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
            }*/

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

    /*public static bool CheckForYellow(int index, string userAnswer)
    {
        int letterCount = 0;
        int incorrectCountBeforeIndex = 0;
        int correctCount = 0;

        for (int i = 0; i < answer.Length; i++)
        {

            //if the any letter of the random word is equal to the current letter we are checking, it's a valid letter
            if (answer[i] == userAnswer[index])
            {
                letterCount++;
                Console.WriteLine("Letter count {0}", letterCount);
            }
            //if we are at the letter we are checking and the random word letter at the same position as the one we are checking, it's the right place
            if (userAnswer[i] == userAnswer[index] && answer[i] == userAnswer[index])
            {
                correctCount++;
                Console.WriteLine("Correct Count {0}", correctCount);
            }
            //if we aren't yet at the letter position that we want to check, the letter on the current index is the same as the letter we are trying to check, and the letter at
            //the letter - i from the random word is different from the letter we want to check, it's a wrong letter
            if (i < index && userAnswer[i] == userAnswer[index] && answer[i] != userAnswer[index])
            {
                incorrectCountBeforeIndex++;
                Console.WriteLine("Incorrect Count Before Index: {0}", incorrectCountBeforeIndex);
            }

        }

            Console.WriteLine(letterCount - correctCount - incorrectCountBeforeIndex);
            Console.WriteLine("\n================================");
        return letterCount - correctCount - incorrectCountBeforeIndex > 0;
    }*/

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