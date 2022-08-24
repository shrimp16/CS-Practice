//Problem: 
//https://leetcode.com/problems/jump-game-ii/

class Program
{

    static void Main(string[] args)
    {
        int[] numbers = { 2, 3, 0, 1, 4 };

        Jump(numbers);
    }

    public static int Jump(int[] nums)
    {

        int max = 0;
        int currentCover = 0;
        int moves = 0;

        for (int i = 0; i < nums.Length - 1; i++)
        {
            max = Math.Max(max, i + nums[i]);

            if (i == currentCover)
            {
                moves++;
                currentCover = max;
            }

        }

        return moves;

    }

}