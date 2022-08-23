namespace Genies
{
    interface Genie
    {
        public void getWish() { }

    }

    class BadGenie : Genie
    {

        public void getWish()
        {
            Console.WriteLine("No!");
        }

    }

    class GoodGenie : Genie
    {

        public void getWish()
        {
            Console.WriteLine("Wish granted!");
        }

    }

}