using Auth;

namespace Prog
{

    class Prog
    {

        static void Main(string[] args)
        {

            Program program = new Program();

            Console.Write("Login or Register? (1-2). ");

            int authMethod;
            Int32.TryParse(Console.ReadLine(), out authMethod);

            if (authMethod == 1)
            {
                program.Login();
            }
            else
            {
                program.Register();
            }
        }

    }

    class Program
    {

        Authenticator authenticator;
        public Program()
        {
            authenticator = new Authenticator();
        }
        public void Register()
        {
            Console.WriteLine("---Register---");
            Console.Write("New Username: ");
            string? un = Console.ReadLine();
            Console.Write("New Password: ");
            string? pw = Console.ReadLine();

            if (un == null) un = " ";
            if (pw == null) pw = " ";

            if (authenticator.Register(un, pw))
            {
                Console.WriteLine("Successful register!");
                Login();
                return;
            }
            Console.WriteLine("Username already exists or it is invalid!");
        }

        public void Login()
        {
            Console.WriteLine("---Login---");
            Console.Write("Username: ");
            string? un = Console.ReadLine();
            Console.Write("Password: ");
            string? pw = Console.ReadLine();

            if (un == null) un = " ";
            if (pw == null) pw = " ";

            if (authenticator.Login(un, pw))
            {
                Console.WriteLine("Credentials correct!");
                Console.WriteLine("Accessing very hidden data...");
                return;
            }
            Console.WriteLine("Wrong Credentials!");
            Login();
        }
    }

}
