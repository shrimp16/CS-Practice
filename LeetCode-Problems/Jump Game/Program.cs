//Exercise:
//https://leetcode.com/problems/jump-game/

class Program
{

    static void Main(string[] args)
    {

        int[] nums = { 5, 9, 3, 2, 1, 0, 2, 3, 3, 1, 0, 0 };
        Console.WriteLine(CanJump(nums));

    }

    public static bool CanJump(int[] nums)
    {

        int possibleJump = nums.Length - 1;

        for (int i = nums.Length - 2; i >= 0; i--)
        {
            if(i + nums[i] >= possibleJump){
                possibleJump = i;
            }
        }

        return possibleJump == 0;

    }
}