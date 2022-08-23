using GeniesFactory;
using Genies;

namespace Program
{

    class Program
    {

        static void Main(string[] args)
        {
            Lamp lamp;
            Genie randomGenie;

            int nrOfGenies = 1;

            if (args.Length > 0)
            {
                nrOfGenies = Int32.Parse(args[0]);
            }

            for (int i = 0; i < nrOfGenies; i++)
            {
                lamp = new Lamp();
                randomGenie = lamp.rub();
                randomGenie.getWish();
            }
        }


    }

}