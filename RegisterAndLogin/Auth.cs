namespace Auth
{

    class Authenticator
    {
        public bool Login(string un, string pw)
        {

            int index;
            string[] users = File.ReadAllLines("./un.txt");
            string[] passwords = File.ReadAllLines("./pw.txt");

            if (users.Contains(un))
            {
                index = Array.FindIndex(users, user => user == un);
            }
            else
            {
                return false;
            }

            if (passwords[index] == pw)
            {
                return true;
            }

            return false;

        }

        public bool Register(string un, string pw)
        {
            string[] users = File.ReadAllLines("./un.txt");
            string[] passwords = File.ReadAllLines("./pw.txt");

            ArrayManager<string> arrayManager = new ArrayManager<string>();

            if (!users.Contains(un))
            {
                users = arrayManager.addToArray(users, un);
                passwords = arrayManager.addToArray(passwords, pw);
                File.WriteAllLines("./un.txt", users);
                File.WriteAllLines("./pw.txt", passwords);
                return true;
            }

            
            return false;
        }

    }
}