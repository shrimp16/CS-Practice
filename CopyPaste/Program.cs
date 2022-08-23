class Program {
    static void Main(string[] args)
    {

        bool shouldOverride;

        string file = File.ReadAllText("./File.txt");

        if(Boolean.TryParse(args[2], out shouldOverride)){
            Console.WriteLine(shouldOverride);
            File.Copy(args[0], args[1], shouldOverride);
        }

    }

}