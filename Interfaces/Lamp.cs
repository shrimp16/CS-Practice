using Genies;

namespace GeniesFactory
{

    class Lamp
    {
        public Genie rub()
        {

            Random numberGenerator = new Random();

            if(numberGenerator.Next() % 2 == 0){
                return new GoodGenie();
            }

            return new BadGenie();

        }
        
    }
}