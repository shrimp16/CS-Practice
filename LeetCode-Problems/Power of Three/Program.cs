//Problem: 
//https://leetcode.com/problems/power-of-three/

class Program {

    static void Main(string[] args)
    {
        Console.WriteLine(IsPowerOfThree(Int32.Parse(args[0])));
    }

    static bool IsPowerOfThree(int n ){
        double number = n;
        while(number > 1){
            number = (double) number / 3;
        }
        return number == 1;
    }
}