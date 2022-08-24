class Program {
    static void Main(string[] args)
    {
        int ans = 0;
        int[] nums = {2, 4, 2, 1, 4};

        for(int i = 0; i < nums.Length; i++){
            ans ^= nums[i];
        }

        Console.Write(ans);
    }
}